// See https://aka.ms/new-console-template for more information
using bicicleta.Model;
namespace bicicleta{
    //atividade 28/08/2022
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
