namespace redesocial.Model{
    public class Instagram: RedeSocial{
        public string UltimaPublicacao{get;set;}

        public void GetUltimaPubli(){
            Console.WriteLine(UltimaPublicacao);
        }
    }
}