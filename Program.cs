﻿using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Nokia");
Smartphone nokia = new Nokia("981455568", "8478fa5fa496g5", "Nokia", "C92", 6, 128);
nokia.Ligar();
nokia.InstalarAplicativo("Teams");

Console.WriteLine($"Meu número atual é: {nokia.Numero}.");
nokia.Numero = "999865888";
Console.WriteLine($"Número alterado para: {nokia.Numero}.");

Console.WriteLine("\n");

Console.WriteLine("Apple");
Smartphone iphone = new Apple("992544477", "9q48uwuicnq09cnwq", "Apple", "Iphone 11", 4,256);
nokia.Ligar();
nokia.ReceberLigacao();
iphone.InstalarAplicativo("telegram");

