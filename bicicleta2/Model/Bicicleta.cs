namespace bicicleta2.Model{
    public class Bicicleta{
         //Atributos
         public string Cor { get; set; }
         public int Aro { get; set; }
         public string Marca { get; set; }
         Rodar rodar = new Rodar();


         //Método
         public void Apresentar(){
            Console.WriteLine("Cor: "+ Cor);
            Console.WriteLine("Aro: "+ Aro);
            Console.WriteLine("Marca: "+ Marca);
            Console.WriteLine("A distancia percorida foi"+ rodar.Distancia(200));
         }
         //Classe Interna
         public class Rodar{
            public double Distancia(int pedaladas){
                return pedaladas *1.5;
            }
         }
        
    }
}