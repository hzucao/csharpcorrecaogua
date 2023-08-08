// See https://aka.ms/new-console-template for more information

//Atividade 4 (desafio) - 08/08/2023
using System;
class Program{
    public static void Main(){
        Console.WriteLine("Digite a Placa");
        string placa = Console.ReadLine();
        
        int final = int.Parse(placa.Substring(6,1));
        string dia;
        switch(final){
            case 1: dia = "Segunda";break;
            case 2: dia = "Segunda";break;
            case 3: dia = "Terça";break;
            case 4: dia = "Terça";break;
            case 5: dia = "Quarta";break;
            case 6: dia = "Quarta";break;
            case 7: dia = "Quinta";break;
            case 8: dia = "Quinta";break;
            case 9: dia = "Sexta";break;
            case 0: dia = "Sexta";break;
            default: dia = "Placa Invalida";break;
        }
        Console.WriteLine(dia);
       
}
}
