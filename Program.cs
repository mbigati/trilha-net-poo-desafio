using DesafioPOO.Models;

//Implementado
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("123456", "Nokia 3310", "111111111111111", 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone("654321", "iPhone 13", "222222222222222", 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");




