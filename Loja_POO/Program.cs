namespace Loja_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Welcome to XÔPI, type your option!");
            Console.WriteLine("- LOG IN (1) ---- SIGN UP (2) ---- SEE OUR PRODUCTS (3) -");
            int option = 1; //alterar READLINE

            //adicionar lista de usuarios e senha
            

            //usar recursividade invés de while
            //dentro de um metodo

            
            Console.Clear();
            switch (option)
            {
                case 1:
                    Console.WriteLine("LogIn");
                    UserPassword(option);

                    break;
                case 2:
                    Console.WriteLine("SignUp");

                    break;
                case 3:
                    Console.WriteLine("Back");

                    break;
                default:
                    Console.WriteLine("Oops! Something went wrong");
                    break;

            }
            */

            meuMenu();

        }
        public static int meuMenu(int option) //recursividade, verificar se funciona, alterar nome? precisa ter recursividade aqui?
        {
            Console.WriteLine("Welcome to XÔPI, type your option!");
            Console.WriteLine("- LOG IN (1) ---- SIGN UP (2) ---- SEE OUR PRODUCTS (3) -");
            option = 1; //alterar READLINE

            Console.Clear();
            switch (option)
            {
                case 1:
                    Console.WriteLine("LogIn");
                    UserPassword(option); //chama a função que digita usuário e senha
                    break;
                case 2:
                    Console.WriteLine("SignUp");
                    break; 
                case 3:
                    Console.WriteLine("Back");
                    break;
                default:
                    Console.WriteLine("Oops! Something went wrong");
                    break;
            }

            return meuMenu(option-1);
        }

        public static void UserPassword(int i) //alterar, usa o outro métdo aqui dentro?
        {
            Menu createUser = new Menu();
            Console.WriteLine("Type your USERNAME;");
            createUser.user = "Joaninha";
            Console.WriteLine("Type your PASSWORD (only numbers);");
            Console.WriteLine("To go back to the menu type literally anything else than numbers");
            createUser.password = 5342;

        }


    }
}
  
  


/*
        //funcionário

        Funcionario funcionario1 = new Funcionario();

            funcionario1.nomeF = "Paola";
            funcionario1.dadosBancarios = 0;
            funcionario1.dataVencimento = 0;

            Funcionario funcionario2 = new Funcionario();

            funcionario2.nomeF = "Isabelle";
            funcionario2.dadosBancarios = 0;
            funcionario2.dataVencimento = 0;

            Console.WriteLine("Prestador de Serviço 1");
            Console.WriteLine(funcionario1.nomeF);
            Console.WriteLine(funcionario1.dadosBancarios);
            Console.WriteLine(funcionario1.dataVencimento);


            Console.WriteLine("Prestador de Serviço 2");
            Console.WriteLine(funcionario2.nomeF);
            Console.WriteLine(funcionario2.dadosBancarios);
            Console.WriteLine(funcionario2.dataVencimento);

            //cliente

            Cliente cliente1 = new Cliente();

            cliente1.nomeC = "Laura";
            cliente1.servicoUtilizado = "Maquiagem";

            Cliente cliente2 = new Cliente();

            cliente2.nomeC = "Ana";
            cliente2.servicoUtilizado = "Perfume";

            Console.WriteLine("Cliente 1");
            Console.WriteLine(cliente1.nomeC);
            Console.WriteLine(cliente1.servicoUtilizado);

            Console.WriteLine("Cliente 2");
            Console.WriteLine(cliente2.nomeC);
            Console.WriteLine(cliente2.servicoUtilizado);

            Console.ReadLine();
*/