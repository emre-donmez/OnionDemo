﻿using OnionDemo.Domain.Entities.Common;
using OnionDemo.Domain;
namespace OnionDemo.Domain
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

    }
}
