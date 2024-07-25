namespace _04._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            

            if (password.Length <= 6 || password.Length >= 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            foreach (int i in password)
            {
                if (i < 2)
                {
                    Console.WriteLine("Password must have at least 2 digits");
                    break;
                }
            }
        }
    }
}
