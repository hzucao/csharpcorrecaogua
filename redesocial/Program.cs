// See https://aka.ms/new-console-template for more information
using redesocial.Model;
namespace redesocial{
    public class Program{
        //atividade 29/08/2023
        public static void Main(){
            var instagram = new Instagram();
            instagram.Login = "heitor";
            instagram.Senha = "123";
            instagram.UltimaPublicacao = "Ultima Publi";
            instagram.GetUltimaPubli();
        }
    }
}
