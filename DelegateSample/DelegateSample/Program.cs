using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateSample
{
    class Program
    {
        static void Main(string[] args)
        {
            CreatProduct creatProduct = new CreatProduct();
            WarpFaction warpFaction = new WarpFaction();
            Logger logger=new Logger();

            Func<Product> func1 = new Func<Product>(creatProduct.CreatPizza);
            Func<Product> func2 = new Func<Product>(creatProduct.CreatToyCar);

            Action<Product> log = new Action<Product>(logger.logger);

            Box box1= warpFaction.WarpProuduct(func1,log);
            Box box2 = warpFaction.WarpProuduct(func2,log);

            Console.WriteLine(box1.product.Name);
            Console.WriteLine(box2.product.Name);
        }
    }
    class Logger
    {
        public void logger(Product product)
        {
            Console.WriteLine("Product{0} creat at{1} ,price is {2}",product.Name,DateTime.Now,product.Price);
        }
    }

    class Product
    {
        public string Name { get; set; }
        public int Price {get;set;}
    }

    class Box
    {
        public Product product { get; set; }
    }

    class WarpFaction
    {
        public Box WarpProuduct(Func<Product> getProudct,Action<Product> loggerCallBack)
        {
            Box box = new Box();
            Product product = getProudct();
            if(product.Price>=50)
            {
                loggerCallBack(product);
            }
            box.product = product;
            return box;
        }
    }
    class CreatProduct
    {
        public Product CreatPizza()
        {
            Product product = new Product();
            product.Name = "Pizza";
            product.Price = 12;
            return product;
        }

        public Product CreatToyCar()
        {
            Product product = new Product() { Name="ToyCar",Price=100};
            return product;

        }
    }

   
 
}
