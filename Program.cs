using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia1 = new Nokia(numero: "1354", modelo: "131", imei: "123123", memoria: 64);
Console.WriteLine($"Numero: {nokia1.Numero}, Modelo: {nokia1.Modelo}, IMEI: {nokia1.IMEI}, Memória: {nokia1.Memoria}");
nokia1.Ligar();
nokia1.InstalarAplicativo("Orkut");

Console.WriteLine("\n");

Console.WriteLine("Iphone:");
Smartphone iphone1 = new Iphone(numero: "2222", modelo: "740", imei: "618534", memoria: 124);
Console.WriteLine($"Numero: {iphone1.Numero}, Modelo: {iphone1.Modelo}, IMEI: {iphone1.IMEI}, Memória: {iphone1.Memoria}");
iphone1.Ligar();
iphone1.InstalarAplicativo("Instagram");