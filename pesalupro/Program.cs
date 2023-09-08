// See https://aka.ms/new-console-template for more information
using pesalupro.Model;
namespace pesalupro{
    public class Program{
        //atividade 29/08/2023 08
        public static void Main(){
            var pessoa = new Pessoa();
             pessoa.Nome = "Heitor Pessoa";
             pessoa.Cpf = 12345678910;
             pessoa.Apresentar();
             pessoa.Dormir(8);
             Console.WriteLine("----------------------------");
            var aluno = new Aluno();
            aluno.Nome = "Heitor Aluno";
            aluno.Cpf = 12345678910;
            aluno.Rm = 1234;
            aluno.Apresentar();
            aluno.Dormir(8);
            var teacher = new Professor();
            teacher.Nome = "HEitor Professor";
            teacher.Cpf = 12345678910;
            teacher.Salario = 10000;
            teacher.Dormir(4);
            teacher.Apresentar();

        }
    }
}
