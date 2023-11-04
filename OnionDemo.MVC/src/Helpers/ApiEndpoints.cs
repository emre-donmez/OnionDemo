﻿namespace OnionDemo.MVC
{
    public static class ApiEndpoints
    {
        public const string BaseEndpoint = "https://localhost:44313/api/";

        public const string ProductEndpoint = BaseEndpoint + "Product/";
        public const string GetProductsEndpoint = ProductEndpoint + "GetProducts";
        public const string CreateProductEndpoint = ProductEndpoint + "Create";
        public const string UpdateProductEndpoint = ProductEndpoint + "Update";
        public const string GetProductByIdEndpoint = ProductEndpoint + "GetProductById";
        public const string DisableProductEndpoint = ProductEndpoint + "Disable";
        public const string EnableProductEndpoint = ProductEndpoint + "Enable";


    }
}