using indexators;

Shop laptops = new Shop(3);

laptops[0] = new Laptop {Vendor = "Samsung", Price = 5200};
laptops[1] = new Laptop {Vendor = "Asus", Price = 5300};
laptops[2] = new Laptop {Vendor = "LG", Price = 5200000000000000000};

Console.WriteLine(laptops["Asus"]); 

