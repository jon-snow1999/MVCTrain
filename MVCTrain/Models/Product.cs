namespace MVCTrain.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }

        public Product(int id, string name, string description, string imageUrl)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.ImageUrl = imageUrl;
        }

        public override string ToString()
        {
            return $"this product has Id: {this.Id} and it's called {this.Name}, it {this.Description}";
        }
        
    }
}
