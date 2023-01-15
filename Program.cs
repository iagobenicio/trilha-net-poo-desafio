using DesafioPOO.Models;

//implementado

Nokia nokia = new Nokia(numero: "902165", modelo: "NK232344", imei: "112111112211", memoria: 64);

Console.WriteLine("\n Smartphone Nokia: ");
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Iphone iPhone = new Iphone(numero: "302575", modelo: "IPH242764", imei: "222344412211", memoria: 128);

Console.WriteLine("\n Smartphone iPhone: ");
iPhone.Ligar();
iPhone.ReceberLigacao();
iPhone.InstalarAplicativo("Instagram");
Console.WriteLine("\n");