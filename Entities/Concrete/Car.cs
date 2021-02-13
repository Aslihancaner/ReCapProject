
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class Car : IEntity
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public string ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"{Id,-10}{BrandId,-10}{ColorId,-10}{ModelYear,-10}{DailyPrice,-10}{Description,-10}";
        }

    }
}
