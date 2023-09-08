// See https://aka.ms/new-console-template for more information
using animal.Model;
namespace animal{
    public class Program{
        //atividade 29/08/2023 08
        public static void Main(){
              var cachorro = new Cachorro();
              cachorro.EmitirSom();
              cachorro.ExecutarComando("Deitar", "Rolar");
              var cat = new Gato();
              cat.EmitirSom();
        }
    }
}
