// See https://aka.ms/new-console-template for more information

#region Factory Implementaion
using DesignPatterns.AbstractFactory.Concretes;
using DesignPatterns.AbstractFactory.Constants;
using DesignPatterns.AbstractFactory.Factories;
using DesignPatterns.Builder;
using DesignPatterns.Factory;
using DesignPatterns.Factory.Factories;

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

Console.ReadLine();
