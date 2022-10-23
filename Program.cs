using system_abstracting_cell_poo.Models;

Console.WriteLine("IPhone - Instalação App");
Console.WriteLine("--------------------------");
Iphone iphone = new Iphone(number: "22447788", model: "Iphone F20", imei: "12345", memory: 64);
iphone.TurnOn();
iphone.InstallApp("App1");

Console.WriteLine("\n");

Console.WriteLine("Nokia - Instalação App");
Console.WriteLine("--------------------------");
Nokia nokia = new Nokia(number: "11223344", model: "Nokia F20", imei: "1234", memory: 128);
nokia.ReceiveCall();
nokia.InstallApp("App2");