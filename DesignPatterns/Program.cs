// See https://aka.ms/new-console-template for more information

#region Factory Implementaion
using DesignPatterns;
using DesignPatterns.AbstractFactory.Concretes;
using DesignPatterns.AbstractFactory.Constants;
using DesignPatterns.AbstractFactory.Factories;
using DesignPatterns.Adapter;
using DesignPatterns.Builder;
using DesignPatterns.Factory;
using DesignPatterns.Factory.Factories;
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
ISalaryServiceAdapter salaryAdapter = new SalaryServiceAdapter();
IEmployeeService employeeService = new EmployeeService(salaryAdapter);
employeeService.PaySalaries();
#endregion
Console.ReadLine();
