namespace ChallengeWeek2Number3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string storedUserName = "Josh";
            const string storedPassword = "password";
            bool success = false;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Please enter your username: ");
                string username = Console.ReadLine();
                Console.WriteLine("Please enter your password: ");
                string password = Console.ReadLine();

                if (username == storedUserName && password == storedPassword)
                {
                    success = true;
                    break;
                }
                Console.WriteLine(i);
           
            }

            if (success) 
            {
                Console.WriteLine("Login success. Welcome!");
            }
            else 
            {
                Console.WriteLine("Login attempt failed. Please reset password");
            }


        }
    }
}
