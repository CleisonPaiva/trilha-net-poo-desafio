using DesafioPOO.Models;

Smartphone iphone = new Iphone("123", "Iphone", "123", 64);
iphone.InstalarAplicativo("Telegram");
iphone.InstalarAplicativo("Twitter");

iphone.ReceberLigacao();
iphone.Ligar();


Console.WriteLine("\n");

Smartphone nokia = new Nokia("123", "Nokia", "123", 64);

nokia.InstalarAplicativo("WhatsApp");
nokia.InstalarAplicativo("Instagram");

nokia.ReceberLigacao();
nokia.Ligar();



