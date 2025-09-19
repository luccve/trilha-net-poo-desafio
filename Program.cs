using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Smartphone nokiaTeste = new Nokia("11113123123", "1100", "21021231", 512);

Smartphone iphoneTeste = new Iphone("11113123123", "31", "21021231", 312);

Console.WriteLine("Operando o Nokia");
nokiaTeste.Ligar();
nokiaTeste.ReceberLigacao();
nokiaTeste.InstalarAplicativo("Whatsapp");

Console.WriteLine("\nOperando o Iphone");
iphoneTeste.Ligar();
iphoneTeste.InstalarAplicativo("Whatsapp");
iphoneTeste.ReceberLigacao();