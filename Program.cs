using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "123456", modelo: "plpl", imei: "oooo", memoria: 121);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero: "123323456", modelo: "uypl", imei: "iioo", memoria: 200);
iphone.Ligar();
iphone.InstalarAplicativo("linkedin");