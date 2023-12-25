using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("\n\nSmartphone Nokia\n");
var nokia = new Nokia("123456", "modelo 1", "111111", 64);

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n\nSmartphone Iphone\n");
var iphone = new Iphone("123456", "modelo 1", "111111", 64);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Facebook");


