using System.Reflection;
using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "962584", modelo: "Modelo G85", imei: "586321486", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Duolingo");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "854126", modelo: "Modelo Is", imei: "85148568", memoria: 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");