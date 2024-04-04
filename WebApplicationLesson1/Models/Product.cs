﻿using System;

namespace WebApplicationLesson1.Models
{
    public class Product
    {
        private static int instanceCounter = 0;
        public int Id { get; set; }
        public string Name { get; set; }        
        public decimal Cost { get; set; }
        public string Description { get; set; }

        public Product(string name, decimal cost, string description)
        {
            Id = instanceCounter;
            Name = name;
            Cost = cost;
            Description = description;
            instanceCounter += 1;
        }

        public override string ToString() 
        {
            return $"{Id}\n{Name}\n{Cost}";
        }
    }
}
