using Repeat2;

Product product1 = new Product();
product1.Id = 1;
product1.Name = "Seker tozu";
product1.IsSale = true;
product1.Price = 2.50m;

Product product2 = new Product();
product2.Id = 2;
product2.Name = "Beta-Tea";
product2.IsSale = false;
product2.Price = 2.78m;

// Encapsulation-->Burada product1 veya product2 bir kapsuldur yeni icinde birden cox datalari saxlayir 
//ve bir yerde kapsul seklinde cagirilir 
ProductManager productManager = new ProductManager();
productManager.AddProduct(product1);//Polymorphisim-->Bir metodun product1 ve product2 kimi ozunu aparir
productManager.AddProduct(product2);//yeni Addproduct metodunu cox yerde cagirdiqda bas verir

Person person1 = new Person();
person1.FirstName = "Cingiz";
person1.LastName = "Zaidov";

Person person2 = new Person();
person2.FirstName = "Fuad";
person2.LastName = "Atashov";

PersonManager personManager = new PersonManager();
personManager.GetPerson(person1.FirstName);
person2.FirstName = "Murad";
person1 = person2;


Console.WriteLine(person2.FirstName);

