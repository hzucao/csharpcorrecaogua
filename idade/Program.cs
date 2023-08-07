// See https://aka.ms/new-console-template for more information
class Program
{
    public static void Main(){
        Console.WriteLine("Digite sua idade");
        int idade = int.Parse(Console.ReadLine());
        int idade10 = idade+10;

        if(idade10 <12){
            Console.WriteLine("Criança");
        }
        else if(idade10 <18){
            Console.WriteLine("Adolecente");
        }
        else if (idade10 <60){
            Console.WriteLine("Adulto");
        }
        else{
            Console.WriteLine("Idoso");
        }
    }
}
