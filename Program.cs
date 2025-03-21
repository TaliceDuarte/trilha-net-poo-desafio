using DesafioPOO.Models;

// **IMPLEMENTADO** TODO: Realizar os testes com as classes Nokia e Iphone

Iphone iphone = new("1199999999", "X10", "ADGG546448GH", 500);
Nokia nokia = new("229999999", "S30", "ME485859969", 500);

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Dio");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Dio");
