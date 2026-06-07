namespace MVCTrain.Models
{
    public class ProductBL
    {
        public List<Product> Products { get; }

        public ProductBL(List<Product> products)
        {
            this.Products = products;
        }

        public  Product getProductById(int id)
        {
            return Products.FirstOrDefault((product) => product.Id == id);
        }
        
    }
}
