// See https://aka.ms/new-console-template for more information

#region Factory Implementaion
using DesignPatterns;
using DesignPatterns.AbstractFactory.Concretes;
using DesignPatterns.AbstractFactory.Constants;
using DesignPatterns.AbstractFactory.Factories;
using DesignPatterns.Adapter;
using DesignPatterns.Builder;
using DesignPatterns.Decorator;
using DesignPatterns.Facade;
using DesignPatterns.Factory;
using DesignPatterns.Factory.Factories;
using DesignPatterns.Observer;
using DesignPatterns.Prototype;

/*IAccountService accountService = new AccountService(new ForeignBankAccountFactory());
var businessAccount = accountService.RegisterBusinessAccount();
var personalAccount = accountService.RegisterPersonalAccount();


IAccountService accountServiceForLocalBank = new AccountService(new LocalBankAccountFactory());
var businessAccountLocal = accountServiceForLocalBank.RegisterBusinessAccount();
var personalAccountLocal = accountServiceForLocalBank.RegisterPersonalAccount();*/
#endregion
#region Abstract Factory Implementation
/*var orderManagementService = new OrderManagementService(new FurnitureFactoryBuilder());
Console.WriteLine("What type of furniture do you want ?");
Console.WriteLine("Press M for modern, C for classic");
char typeOfModel = (char)Console.Read();
orderManagementService.OrderLivingRoomFurniture(EnumTypeHelper.GetFurnitureTypeByChar(typeOfModel));*/
#endregion
#region Builder
/*ICarBuilder<Car> _carBuilder = new CarBuilder();
var carConfigurator = new CarConfigurator(_carBuilder);
Console.WriteLine(carConfigurator.CraeteMercedesBenzC200());
Console.WriteLine(carConfigurator.CraeteMercedesBenzE450BalckEdition());*/
#endregion
#region Prototype
//var student = new Student()
//{
//    Age = 22,
//    Name = "Receb",
//    Surname = "Qarayev",
//    GroupName = "G23",
//    Course = new Course() { Name = "DataStructure and Algorithms", Credit = 6 }
//};
//student.SetGrade(2);
//Console.WriteLine(student);
//var copy = student.DeepClone();
//student.Course.Name = "Changed";
//Console.WriteLine("---------------------------------------------------------------------------------------------");
//Console.WriteLine(student);
//Console.WriteLine(copy);
#endregion
#region Singleton
/*Earth_DoubleCheckLocking.SetWeight(5.235M);
Earth_DoubleCheckLocking.SetRadius(52355.64M);
Console.WriteLine($"Earth_DoubleCheckLocking:{Earth_DoubleCheckLocking.Instance}");
Console.WriteLine("--------------------------------------------------------------------------------");
Earth_StaticBuNotLazy.SetWeight(5.235M);
Earth_StaticBuNotLazy.SetRadius(52355.64M);
Console.WriteLine($"Earth_StaticBuNotLazy:{Earth_StaticBuNotLazy.Instance}");
Console.WriteLine("--------------------------------------------------------------------------------");
Earth_StaticWithFotNetLazyImplementation.SetWeight(5.235M);
Earth_StaticWithFotNetLazyImplementation.SetRadius(52355.64M);
Console.WriteLine($"Earth_StaticWithFotNetLazyImplementation:{Earth_StaticWithFotNetLazyImplementation.Instance}");
Console.WriteLine("--------------------------------------------------------------------------------");
Earth_StaticWithLazyInit.SetWeight(5.235M);
Earth_StaticWithLazyInit.SetRadius(52355.64M);
Console.WriteLine($"Earth_StaticWithLazyInit:{Earth_StaticWithLazyInit.Instance}");*/
#endregion
//The Adapter Design Pattern is a Structural Design Pattern that allows incompatible interfaces (objects) to work together.
//The Adapter Design Pattern acts as a bridge between two incompatible objects.
#region Adapter
/*ISalaryServiceAdapter salaryAdapter = new SalaryServiceAdapter();
IEmployeeService employeeService = new EmployeeService(salaryAdapter);
employeeService.PaySalaries();*/
#endregion
//The Decorator pattern is a design pattern that allows you to dynamically add behavior to an object by wrapping it in an object of a decorator class.
//The decorator class provides additional functionality to the original object without changing its interface or structure.
#region Decorator
//var textEditor = new TextEditor();
//var upperLetterDecorator = new TextEditorWithUpperLettersDecorator(textEditor);
//var grammerCheckDecorator = new TextEditorWithGrammerCheckDecorator(upperLetterDecorator);
//var spellCheckEditor = new TextEditorWithSpellCheckDecorator(grammerCheckDecorator);
//spellCheckEditor.WriteText("My name is Robot");
#endregion

//The Facade pattern is a design pattern used in software engineering to provide a simple and unified interface to a complex system.
//The pattern is based on the principle of encapsulation, which involves hiding the implementation details of a subsystem from its clients. 
#region Facade
/*var restaurant = new OnlineRestaurantService();
var shippingService = new ShippingService();
var facade = new OrderManagementFacadeService(restaurant, shippingService);
var chickenOrder = new Order() { DishName = "Chicken with rice", DishPrice = 20.0, User = "User1", ShippingAddress = "Random street 123" };
var sushiOrder = new Order() { DishName = "Sushi", DishPrice = 52.0, User = "User2", ShippingAddress = "More random street 321" };
facade.OrderFood(new List<Order>() { chickenOrder, sushiOrder });*/
#endregion


//The Observer pattern is a design pattern that enables objects to be notified automatically when the state of another object changes.
//In this pattern, there are two types of objects: Observers and Subjects.
//Observers are objects that need to be notified when the state of the Subject changes. The Subject is the object that is being observed.
#region Observer
var user = new User() { Id = 1,Name = "Receb" , Surname = "Qarayev" };
var user2 = new User() { Id = 2,Name = "Qeshem" , Surname = "Qarayev" };

var product = new Product("Iphone14",0);
var product2 = new Product("Iphone14 Pro",0);

user.SubscribeToProduct(product);
user.SubscribeToProduct(product2);
user2.SubscribeToProduct(product);
user2.SubscribeToProduct(product2);

product.AddProduct(2);
product2.AddProduct(3);

#endregion
Console.ReadLine();
