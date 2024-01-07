using DesafioPOO.Models;

// Implementei

Console.WriteLine("Smartphone Nokia:");
Smartphone Nokia = new Nokia(numero:"12345", modelo:"Modelo 01", imei: "11111111", memoria: 64 );
Nokia.Ligar();
Nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone Iphone = new Iphone(numero:"11111", modelo: "Modelo 02", imei: "2222222", memoria:128);
Iphone.ReceberLigacao();
Iphone.InstalarAplicativo("Telegram");
