using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Entities
{
    public class BaseEntity
    {
        protected BaseEntity()
        {
           
            Active = true;
        }

        public int Id { get; private set; }
        public bool Active { get; private set; }

        public void Deactivate()
        {
            Active = false;
        }
    }
}
