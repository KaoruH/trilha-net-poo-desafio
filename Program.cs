using DesafioPOO.Models;

Console.WriteLine(">>Iniciando teste no Iphone:");

var iphone = new Iphone("123456789", "iPhone 13", "IMEI123456789", 128);

iphone.Ligar();
iphone.InstalarAplicativo("WhatsApp");

Console.WriteLine();
Console.WriteLine("Dados do Iphone:");

Console.WriteLine($"Número: {iphone.Numero}");
Console.WriteLine($"Modelo: {iphone.Modelo}");
Console.WriteLine($"IMEI: {iphone.Imei}");
Console.WriteLine($"Memória: {iphone.Memoria}GB");

Console.WriteLine(new string('-', 30));
Console.WriteLine();
Console.WriteLine(">>Iniciando teste no Nokia:");

Nokia nokia = new Nokia("987654321", "Nokia 3310", "IMEI987654321", 32);

nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine();
Console.WriteLine("Dados do Nokia:");

Console.WriteLine($"Número: {nokia.Numero}");
Console.WriteLine($"Modelo: {nokia.Modelo}");
Console.WriteLine($"IMEI: {nokia.Imei}");
Console.WriteLine($"Memória: {nokia.Memoria}GB");

