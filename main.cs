using System;

class MainClass {
  public static void Main () {
    string nome;
    Aeronave a = new Aeronave("Gol", 10000, 5000, 50, 8000, 15000, "Joao", "RJ");

    //Console.WriteLine("Informe o nome do piloto :");
    nome = Console.ReadLine();
    a.Nome = nome;
    a.Aeroporto = "Vitoria";
    a.Voar(3000);
    
    Console.ReadKey();
  }
}