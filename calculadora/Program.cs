// See https://aka.ms/new-console-template for more information
class Program{
    public static void Main(){
        bool continua = true;
        do{
        Console.WriteLine("Qual operação desja fazer + - * /?");
        string operacao = Console.ReadLine();
        Console.WriteLine("Digite o primeiro numero:");
        float num1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite o Segundo numero:");
        float num2 = float.Parse(Console.ReadLine());
        float resultado;
        bool opOk = true;

        if(operacao == "/" && num2 <=0){
            opOk = false;
        }        
        
        if (opOk){
        switch(operacao){
            case "+": resultado = Adicao(num1, num2); break;
            case "-": resultado = Subtracao(num1, num2); break;
            case "*": resultado = Multiplicacao(num1, num2); break;
            case "/": resultado = Divisao(num1, num2); break;
            default: resultado = 0; break;
        }
        Console.WriteLine("Resultado: " + resultado);
        Console.WriteLine("Deseja fazer outra operação? S-Sim N-Não");
        string simNao = Console.ReadLine();
        if(simNao == "N" || simNao == "n"){}
            continua = false;
        }
        
        else
        {Console.WriteLine("Vovê selecionou divisão e o divisor 0");}

        }while(continua);

    }

    public static float Adicao(float num1, float num2){
        return num1+num2;
    }
    public static float Subtracao(float num1, float num2){
        return num1-num2;
    }
    public static float Multiplicacao(float num1, float num2){
        return num1*num2;
    }
    public static float Divisao(float num1, float num2){
        return num1/num2;
    }
}
