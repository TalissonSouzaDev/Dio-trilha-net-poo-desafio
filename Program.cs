using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

// Nokia
Console.WriteLine("******* Nokia **************");
Smartphone nokia = new  Nokia("99665887","X254M","998885447",64);
nokia.Ligar();
nokia.InstalarAplicativo("Facebook ✅");
Console.WriteLine("");
// Iphone
Console.WriteLine("******* Iphone **************");
Smartphone iphone = new Iphone("2545454","Iphone 13 Pro Max", "854574452",256);

iphone.ReceberLigacao();
iphone.InstalarAplicativo("TikTok ✅");


