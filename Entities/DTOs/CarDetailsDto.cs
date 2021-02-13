using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class CarDetailsDto:IDto
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public string Description { get; set; }
        public decimal DailyPrice { get; set; }
        public override string ToString()
        {
            return $"{BrandId,-10}{Description,-10}{DailyPrice,-10}";
        }
    }
}
