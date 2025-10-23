namespace Catalog.Data.Seed
{
    public static class InitialData
    {
        public static IEnumerable<Product> Products =>
            new List<Product>
            {
                Product.Create(Guid.NewGuid(), "IPhone X", ["category1"], "Long description", "imageFile", 500),
                Product.Create(Guid.NewGuid(), "Samsung 10", ["category1"], "Long description", "imageFile", 400),
                Product.Create(Guid.NewGuid(), "Huawei Plus", ["category2"], "Long description", "imageFile", 650),
                Product.Create(Guid.NewGuid(), "Xiaomi Mi", ["category2"], "Long description", "imageFile", 450)
            };
    }
}
