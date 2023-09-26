
namespace Shop.Models
{
    public static class ProductManager
    {
        private static ShopDataBaseEntities _shopDbContext;
        public static ShopDataBaseEntities ShopDbContext
        {
            get
            {
                if (_shopDbContext == null)
                {
					_shopDbContext = new ShopDataBaseEntities();
                    return _shopDbContext;
                }
                else
                {
                    return _shopDbContext;
                }
            }
        }

        public static int GetNumberProduct()
        {
            return ShopDbContext.Products.Count();
        }
    }
}
