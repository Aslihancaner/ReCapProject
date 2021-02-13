using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class Brand: IEntity
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public override string ToString()
        {
            return $"{BrandId,-10}{BrandName,-10}";
        }
    }
}
