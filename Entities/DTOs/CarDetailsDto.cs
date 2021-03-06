﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class CarDetailsDto:IDto
    {
        public int Id { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public decimal DailyPrice { get; set; }

        public override string ToString()
        {
            return $"{BrandName,-10}{ColorName,-10}{DailyPrice,-10}";
        }
    }
}
