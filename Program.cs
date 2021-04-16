using System;

namespace dotnet_oop
{
    class Product
    {
        //Attributes
        public int pid;
        public string name;
        public int price;

        public Product()
        {
            Console.WriteLine(">> Product object constructerd.");
        }

        //This method write data to the product object.
        public void setProductDetails(int pid, string name, int price)
        {
            this.pid = pid;
            this.name = name;
            this.price = price;
        }

        public void showProductDetails()
        {
            Console.WriteLine("-----Product ID: " + pid + "-----");
            Console.WriteLine("Name:\t" + name);
            Console.WriteLine("Price:\t" + price);
            Console.WriteLine("--------------------------");
        }

        public void setPid(int pid)
        {
            this.pid = pid;
        }

        public int getPid()
        {
            return pid;
        }

    }

    class Mobile : Product
    {
        int ram;
        string os;
        int cardSize;
        public Mobile()
        {
            Console.WriteLine(">> Mobile object constructerd.");
        }

        //Method Overloading
        public void setProductDetails(int pid, string name, int price, int ram, string os, int cardSize)
        {
            this.pid = pid;
            this.name = name;
            this.price = price;
            this.ram = ram;
            this.os = os;
            this.cardSize = cardSize;
            Console.WriteLine(">> Data Written in product object");
        }

        //Method Overriding
        public void showProductDetails()
        {
            Console.WriteLine("-----Product ID: " + pid + "-----");
            Console.WriteLine("Name:\t" + name);
            Console.WriteLine("Price:\t" + price);
            Console.WriteLine("RAM:\t" + ram);
            Console.WriteLine("OS:\t" + os);
            Console.WriteLine("Card:\t" + cardSize);
            Console.WriteLine("--------------------------");
        }
    }
    public class ProgramOop
    {
        static void Main(string[] args)
        {
            /*
            Product product1 = new Product();
            //Console.WriteLine("Product is: " + product1);

            product1.setProductDetails(1001, "Apple iMac", 5000);
            product1.showProductDetails();

            Product product2 = new Product();
            product2.setPid(1002);
            product2.name = "iPhoneX";
            product2.price = 4000;

            Console.WriteLine(product2.getPid());
            product2.showProductDetails();
            */
            Mobile mobile = new Mobile();
            //mobile.setProductDetails(1003, "Apple Iphone 11", 7000);

            mobile.setProductDetails(1004, "IPad2", 3000, 2, "IOS", 2);
            mobile.showProductDetails();
        }
    }
}
