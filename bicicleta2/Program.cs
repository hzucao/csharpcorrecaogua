// See https://aka.ms/new-console-template for more information
using bicicleta2.Model;
namespace bicicleta2{
    //atividade 28/08/2023
    public class Program{
        public static void Main(){
            var bicicleta = new Bicicleta();

            bicicleta.Cor = "Branca";
            bicicleta.Aro = 27;
            bicicleta.Marca = "Caloi";

            bicicleta.Apresentar();
        }
    }
}
