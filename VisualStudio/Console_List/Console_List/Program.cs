﻿// See https://aka.ms/new-console-template for more information
using Console_List;

List<Datuak> datuak = new List<Datuak>();
datuak.Add(new Datuak("Aulkia"));
datuak.Add(new Datuak("Laranja"));

Datuak barria = new Datuak("Sagarrak");
datuak.Add((Datuak)barria);

//Consolan ikusten ditugu, “for” egitura erabiliz:

for (int i = 0; i < datuak.Count; i++)
{
    Console.WriteLine(datuak[i].Izena);
}
Console.ReadLine();

//Consolan ikusten ditugu, “foreach” egitura

foreach (Datuak datua in datuak)
{
    Console.WriteLine(datua.Izena);
}
Console.ReadLine();

Console.WriteLine(Datuak.DatuenZerrenda(datuak));