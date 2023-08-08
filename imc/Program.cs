// See https://aka.ms/new-console-template for more information

//atividade 03- 08/08/2023
using System;
class Program{
    public static void Main(){
        Console.WriteLine("Digite sua altura");
        double altura = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite seu Peso");
        double peso = double.Parse(Console.ReadLine());

        double imc = peso/ Math.Pow(altura, 2);
        
        if(imc < 17){
            Console.WriteLine("Muito abaixo do peso");
        }
        else if(imc <= 18.49){
            Console.WriteLine("Abaixo do peso");
        }
        else if(imc <= 24.99){
            Console.WriteLine("Peso normal");
        }
        else if(imc <= 29.99){
            Console.WriteLine("Acima do peso");
        }
        else if (imc <= 34.99){
            Console.WriteLine("Obesidade I");
        }
        else if (imc <= 39.99){
            Console.WriteLine("Obesidade II (severa)");
        }
        else{
            Console.WriteLine("Obesidade III (mórbida)");
        }
    }
}
