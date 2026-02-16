namespace EcommerceMVC.Models;

public class ProductBL
{
    List<Product> products;

    public ProductBL()
    {
        products = new List<Product>()
        {
            new Product 
            { 
                ProductId = 1, 
                ProductName = "iPhone 15 Pro Max", 
                ProductDescription = "Apple's latest flagship with a 48MP camera and the powerful A17 Pro chip.", 
                ProductPrice = 1199.00m, 
                ImageURL = "iphone-15-pro-max.jpg" 
            },
            new Product 
            { 
                ProductId = 2, 
                ProductName = "Samsung Galaxy S24 Ultra", 
                ProductDescription = "Samsung's premium phone featuring the S-Pen and advanced AI capabilities.", 
                ProductPrice = 1299.00m, 
                ImageURL = "s24-ultra.jpg" 
            },
            new Product 
            { 
                ProductId = 3, 
                ProductName = "Google Pixel 8 Pro", 
                ProductDescription = "Google's signature phone with exceptional cameras and an AI-powered Android experience.", 
                ProductPrice = 999.00m, 
                ImageURL = "pixel-8-pro.jpg" 
            },
            
            new Product 
            { 
                ProductId = 4, 
                ProductName = "OnePlus 12", 
                ProductDescription = "Incredible performance with a smooth interface and a long-lasting battery.", 
                ProductPrice = 799.00m, 
                ImageURL = "oneplus-12.jpg" 
            },
            new Product 
            { 
                ProductId = 5, 
                ProductName = "Samsung Galaxy Z Fold 5", 
                ProductDescription = "Samsung's best foldable phone for immersive big-screen experiences and multitasking.", 
                ProductPrice = 1799.00m, 
                ImageURL = "z-fold-5.jpg" 
            },
            
        };
    }
    
    public List<Product> GetProducts()
    {
        return products;
    }

    public Product GetProductById(int id)
    {
        return products.Where(x => x.ProductId == id).FirstOrDefault();
    }
    
    
    
}