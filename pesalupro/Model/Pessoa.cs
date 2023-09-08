namespace pesalupro.Model
{
    public class Pessoa
    {
        //Atributos
        public string Nome { get; set; }
        public long Cpf { get; set; }
        
        //Métodos
        public virtual void Apresentar(){
            Console.WriteLine("Nome: "+ Nome);
            Console.WriteLine("CPF: "+ Cpf);
        }
        public void Dormir(int horas){
            Console.WriteLine("Deite, fechei os olhos e dormi por "+ horas+ " horas");
        }

    }
}