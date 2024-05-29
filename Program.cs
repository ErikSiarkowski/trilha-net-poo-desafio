using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia nokia= new Nokia("11 96729-7777","A1", "1A2B", 8);
Iphone iphone= new Iphone("11 97777-7777","XR", "2A1B", 16);

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("uber");
iphone.DadosDoAparelho();

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("ifood");
nokia.DadosDoAparelho();