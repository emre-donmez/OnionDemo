﻿using OnionDemo.Application.Abstractions.Category;

namespace OnionDemo.MVC.Models
{
    public class ProductViewModel
    {
        public Guid Id { get; set; }
        public Guid CategoryId { get; set; }
        public CategoryDto Category { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public bool IsDel { get; set; }
    }
}
