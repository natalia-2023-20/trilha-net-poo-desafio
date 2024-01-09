using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "13999999999", modelo: "Modelo tijolão", imei: "999999999", memoria: 256);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "13999999999", modelo: "15 PRO MAX", imei: "999999991", memoria: 1025);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Tik Tok");

// TODO: Realizar os testes com as classes Nokia e Iphone
