using НОНТОН.РФ;

ProductsImpl productsImpl = new ProductsImpl();
Console.WriteLine("test addProduct:");
Console.WriteLine(productsImpl.addProduct(null));
Console.WriteLine(productsImpl.addProduct(new Product("0001", "Nike")));
Console.WriteLine(productsImpl.addProduct(new Product("0002", "Sasha")));
Console.WriteLine(productsImpl.addProduct(new Product("0003", "Sasha")));
Console.WriteLine();
Console.WriteLine("test deleteProduct:");
Console.WriteLine(productsImpl.deleteProduct(new Product("0003", "Sasha")));
Console.WriteLine(productsImpl.deleteProduct(new Product("0003", "Sasha")));
Console.WriteLine();
Console.WriteLine("test getName:");
Console.WriteLine(productsImpl.getName("0002"));
Console.WriteLine(productsImpl.getName("0006"));
Console.WriteLine();

Console.WriteLine("test findByName:");
productsImpl.addProduct(new Product("0003", "Sasha"));
Console.WriteLine(String.Join("; ",productsImpl.findByName("Sasha")) );

Console.WriteLine();
Console.WriteLine("show all productsImpl:");
Console.WriteLine(productsImpl);