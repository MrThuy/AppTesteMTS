using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Net.Http.Json;
using AppTesteMTS.Entities.Base;
using Teste;

namespace AppTesteMTS
{
    class UtilAPI
    {
        static readonly HttpClient client = new HttpClient();

        public static void ConfigureClient(string aURL)
        {
            if (string.IsNullOrEmpty(aURL))
            {
                throw new ArgumentException($"'{nameof(aURL)}' não pode ser nulo nem vazio.", nameof(aURL));
            }

            // Update port # in the following line.  https://localhost:44319/api/Produto
            //aURL "https://localhost:44319/api/"
            client.BaseAddress = new Uri(aURL);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static async Task<Uri> CreateAsync<T>(T aObjeto) where T : IEntity
        {
            HttpResponseMessage response = await client.PostAsJsonAsync($"{aObjeto}", aObjeto);
            response.EnsureSuccessStatusCode();

            aObjeto.Options.Status = StatusRecord.Updating;

            // return URI of the created resource.
            return response.Headers.Location;
        }

        public static async Task<T> CreateAndGetAsync<T>(T aObjeto) where T : IEntity
        {
            Uri url = await CreateAsync(aObjeto);
            return await GetAsync(aObjeto, url.PathAndQuery);
        }

        public static T CreateAndGetSync<T>(T aObjeto) where T : IEntity
        {
            Task<T> task = Task.Run(() => CreateAndGetAsync(aObjeto));
            task.Wait();
            return task.Result;
        }

        public static async Task<T> GetAsync<T>(T aObjeto, string aId) where T : IEntity
        {
            /*if (!path.StartsWith("/api"))
            {
                path = $"/api/{aObjeto.GetType().Name}/{path}";
            }*/
            
            HttpResponseMessage response = await client.GetAsync( $"{aObjeto}/{aId}" );

            if (response.IsSuccessStatusCode)
            {
                aObjeto = await response.Content.ReadAsAsync<T>();
                aObjeto.Options.Found = true;
                aObjeto.Options.Status = StatusRecord.Updating;
            }
            else
            {
                aObjeto.Options.Found = false;
                aObjeto.Options.Status = StatusRecord.Inserting;
            }
            return aObjeto;
        }

        public static T Get<T>(T aObjeto, string aId) where T : IEntity
        {
            Task<T> task = Task.Run(() => GetAsync(aObjeto, aId));
            task.Wait();
            return task.Result;
        }

        public static async Task<T> UpdateAsync<T>(T aObjeto, String path) where T : IEntity
        {
            /*if (!path.StartsWith("/api"))
            {
                path = $"/api/{aObjeto.GetType().Name}/{path}";
            }*/

            HttpResponseMessage response = await client.PutAsJsonAsync(
                path, aObjeto);

            response.EnsureSuccessStatusCode();

            // Deserialize the updated product from the response body.
            aObjeto = await response.Content.ReadAsAsync<T>();
            return aObjeto;
        }

        public static async Task<HttpStatusCode> DeleteAsync<T>(T aObjeto, string aId) where T : IEntity
        {
            /* if (!path.StartsWith("/api"))
             {
                 path = $"/api/{aObjeto.GetType().Name}/{path}";
             }*/
            HttpResponseMessage response = await client.DeleteAsync( $"{aObjeto}/{aId}" );
            return response.StatusCode;
        }

        public static async Task<T> GetAllAsync<T>(Object aObjeto)
        {
            HttpResponseMessage response = await client.GetAsync($"{aObjeto}/");
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<T>();
            }
            else
            {
                return default;
            }
        }

        public static async Task<T> PostFilterAsync<T, T2>(T2 aObjeto)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync(
                $"{aObjeto}/Filter", aObjeto);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<T>();
            }
            else
            {
                return default;
            }
        }

        public static async Task<EntityPage<T>> PostFilterAsyncPage<T, T2>(T2 aObjeto, decimal? aPage, decimal? aSize)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync(
                $"{aObjeto}/FilterPage/?size={aSize}&page={aPage}", aObjeto);
            if (response.IsSuccessStatusCode)
            {
                EntityPage<T> r = await response.Content.ReadAsAsync<EntityPage<T>>();
                if (r.PageNumber > r.PageCount)
                {
                    r.PageNumber = r.PageCount;
                    r = await PostFilterAsyncPage<T, T2>(aObjeto, 1, aSize);
                }
                return r;
            }
            else
            {
                return default;
            }
        }
    }
}
