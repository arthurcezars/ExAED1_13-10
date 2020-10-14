using System;
using System.Collections.Generic;

class Aeronave{
private string NomeAeronave;
private int CapacidadeTanqueCombustivel;
private int NivelCombustivelAtual;
private int QtdPassageiros;
private int AutonomiaAeronave = 5000;
private int HorasDeVoo;
private string NomePiloto;
private string AeroportoAtual;
 
public string Nome
{
  get{return NomePiloto;}
  set{NomePiloto = value;}
}

public string Aeroporto
{
  get{return AeroportoAtual;}
  set{NomePiloto = value;}
}

public int AbastecerAeronave(int quantidade_de_litros_abastecidos){
if (NivelCombustivelAtual < CapacidadeTanqueCombustivel)
 NivelCombustivelAtual+=quantidade_de_litros_abastecidos;
return quantidade_de_litros_abastecidos;
}

public int Voar(int Distancia){
  if (Distancia <= AutonomiaAeronave)
    HorasDeVoo = HorasDeVoo + Distancia;
    Console.WriteLine(HorasDeVoo);
return HorasDeVoo;
}

public Aeronave(string NomeAeronave, int CapacidadeTanqueCombustivel, int NivelCombustivelAtual, int QtdPassageiros, int AutonomiaAeronave, int HorasDeVoo, string NomePiloto, string AeroportoAtual){
   Console.WriteLine("Nome da Aeronave >> {0} \n Capacidade do Tanque de Combustivel >> {1} \n Nivel Atual do Combustivel >> {2} \n Quantidade de Passageiros >> {3} \n Autonomia da Aeronave >> {4} \n Kilometragem da Nave >> {5} \n Nome do Piloto >> {6} \n Aeroporto Atual >> {7}", NomeAeronave, CapacidadeTanqueCombustivel, NivelCombustivelAtual, QtdPassageiros, AutonomiaAeronave, HorasDeVoo, NomePiloto, AeroportoAtual);
}
public Aeronave(){
  NomeAeronave = "teste";  
 }

}