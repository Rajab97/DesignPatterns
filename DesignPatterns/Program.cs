// See https://aka.ms/new-console-template for more information

#region Factory Implementaion
using DesignPatterns.AbstractFactory.Concretes;
using DesignPatterns.AbstractFactory.Constants;
using DesignPatterns.AbstractFactory.Factories;
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
var student = new Student()
{
    Age = 22,
    Name = "Receb",
    Surname = "Qarayev",
    GroupName = "G23",
    Course = new Course() { Name = "DataStructure and Algorithms", Credit = 6 }
};
student.SetGrade(2);
Console.WriteLine(student);
var copy = student.DeepClone();
student.Course.Name = "Changed";
Console.WriteLine("---------------------------------------------------------------------------------------------");
Console.WriteLine(student);
Console.WriteLine(copy);
#endregion
Console.ReadLine();
