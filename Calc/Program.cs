using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the amount of celsius: ");
            int celsius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kelvin = {0}", ConvertToKelvin(celsius));
            Console.WriteLine("Fahrenheit = {0}", ConvertToFahrenheit(celsius));

            User testUser = new User("test", "1234", "eaaa@aa.aa", 521421323);

            String userToJson = Json.Net.JsonNet.Serialize(testUser);
            Console.WriteLine(userToJson);
			Console.ReadLine();
        }

        public static int ConvertToKelvin(int value)
        {
            return value + 273;
        }

        public static int ConvertToFahrenheit(int value)
        {
            return value * 18 / 10 + 32;
        }
    }

    public class User
    {
        public string login;
        public string password;
        public string email;
        public int phoneNumber;

        public User(string login, string password, string email, int phoneNumber)
        {
            this.login = login;
            this.password = password;
            this.email = email;
            this.phoneNumber = phoneNumber;
        }

    }
}
