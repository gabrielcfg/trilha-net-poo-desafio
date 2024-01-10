using DesafioPOO.Models;

Console.WriteLine("Celular Nokia");
Smartphone nokia = new Nokia (numero: "940028922", imei: "1231231231", modelo: "Nokia X30", memoria: 64);

nokia.Ligar();
nokia.InstalarAplicativo("Twitter");

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();


Console.WriteLine("Celular Iphone");
Smartphone Iphone = new Iphone (numero: "995050117", imei: "22312312311", modelo: "Iphone 15 Pro Max", memoria: 512);



Iphone.ReceberLigacao();
Iphone.InstalarAplicativo("Instagram");