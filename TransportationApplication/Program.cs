using Base.Models;
using TransportationApplication.Services;

Service service = new Service();
string a=service.CardControl();
string b=service.AddMoneyToPrivateCard(25, new PrivateCard { Money = 20, });
string c=service.AddMoneyToPrivateCard(25,new PrivateCard { Money = 35, });
string d=service.AddMoneyToPrivateCard(25,new PrivateCard { Money = 85, });
string f=service.AddMoneyToPrivateCard(25,new PrivateCard { Money = 77, });
string g=service.AddMoneyToPrivateCard(25,new PrivateCard { Money = 65, });
string e=service.AddMoneyToPrivateCard(25,new PrivateCard { Money = 95, });

Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(d);
Console.WriteLine(c);
Console.WriteLine(e);
Console.WriteLine(f);
Console.WriteLine(g);
