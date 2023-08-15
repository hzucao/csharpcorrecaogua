// See https://aka.ms/new-console-template for more information
class Program{
    public static void Main(){
        Console.WriteLine("Digite a temperatura em ºC:");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("A temperatura em ºF é: " + Converte(c));

    }

    public static double Converte(double c){
        double f = c * 1.8 +32;
        return f;
    }
}
