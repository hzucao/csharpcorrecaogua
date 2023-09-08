namespace bicicleta.Model{
    public class Bicicleta{
         //Atributos
         public string Cor { get; set; }
         public int Aro { get; set; }
         public string Marca { get; set; }

         //Método
         public void Apresentar(){
            Console.WriteLine("Cor: "+ Cor);
            Console.WriteLine("Aro: "+ Aro);
            Console.WriteLine("Marca: "+ Marca);
         }
    }
}