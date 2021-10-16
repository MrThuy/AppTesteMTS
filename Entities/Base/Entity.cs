using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTesteMTS.Entities.Base
{
    public abstract class Entity: IEntity
    {
        public EntityOptions Options { get; set; }

        public Entity()
        {
            Options = new EntityOptions
            {
                Found = false,
                Status = StatusRecord.Inserting
            };
        }

        //public override string ToString()
        //{
        //    return GetType().Name;
        //}

    }
}
