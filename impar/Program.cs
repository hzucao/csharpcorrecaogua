// See https://aka.ms/new-console-template for more information
class Program{
    public static void Main(){
        Console.WriteLine("Digite um numero");
        int num = int.Parse(Console.ReadLine());
        
        int cont = 1;
        while(num >= cont){
           if(eimpar(cont)){
            Console.WriteLine(cont);
           }
           cont++;
        }
    }

    public static bool eimpar(int numero){
        if(numero%2 >0){
            return true;
        }
        else{
            return false;
        }
    }
}
