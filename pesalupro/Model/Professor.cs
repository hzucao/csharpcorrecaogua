namespace pesalupro.Model
{
    public class Professor: Pessoa
    {
        public double Salario { get; set; }

        public override void Apresentar(){
            base.Apresentar();
            Console.WriteLine("Salario: "+ Salario);
        }
    }
}