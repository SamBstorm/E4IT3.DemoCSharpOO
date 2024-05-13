namespace Demo_Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countTry = 0;
            Login log1 = new Login();
            //log1.username = "SamBStorm";
            log1.Username = "   Admin ";
            //log1.Password = "password";

            Console.WriteLine($"Le login est sauvegardé!");

            Console.WriteLine("Veuillez vous identifier :");
            string user_username = Console.ReadLine();
            Console.WriteLine("Veuillez introduire votre mot de passe :");
            string user_pwd = Console.ReadLine();
            countTry++;
            while (!log1.CheckUser(user_username, user_pwd) && countTry < 3)
            {
                Console.WriteLine("Veuillez réessayer ...");
                Console.WriteLine("Veuillez vous identifier :");
                user_username = Console.ReadLine();
                Console.WriteLine("Veuillez introduire votre mot de passe :");
                user_pwd = Console.ReadLine();
                countTry++;
            }
            if(log1.CheckUser(user_username, user_pwd))
            {
                Console.WriteLine($"Bonjour {user_username}");
            }
            else
            {
                Console.WriteLine("Votre compte est bloqué");
            }
        }
    }
}
