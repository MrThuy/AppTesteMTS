﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTesteMTS.Entities.Base
{
    class EntityPage<T>
    {
        public int PageCount { get; set; }
        public int TotalItemCount { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public bool HasPreviousPage { get; set; }
        public bool HasNextPage { get; set; }
        public bool IsFirstPage { get; set; }
        public bool IsLastPage { get; set; }
        public int FirstItemOnPage { get; set; }
        public int LastItemOnPage { get; set; }
        public IEnumerable<T> Items { get; set; }
    }
}
