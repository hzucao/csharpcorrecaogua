// See https://aka.ms/new-console-template for more information

//Atividade 1- dia 08/08/2023
class Program{
    public static void Main(){
        Console.WriteLine("Digite a idade");
        int idade = int.Parse(Console.ReadLine());

        string retorno = (idade > 18) ? "Maior de idade" : "Menor de Idade";
        Console.WriteLine(retorno);
    }
}
