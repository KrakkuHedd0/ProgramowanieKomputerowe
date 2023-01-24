using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace projektkoncowy
{
    internal class Offers
    {

        public void Off()
        {
            Login login = new Login();

            Console.Write("Whats your name: ");
            login.Name = Console.ReadLine();

            Console.Write("Whats your surname: ");
            login.Surname = Console.ReadLine();

            Console.Write("what's is your education: ");
            login.Ed = Console.ReadLine();

            //offers

            Offers offers = new Offers();

           
            Console.Write("chef doctor graphic_designer\n developer accountant trainer lawyer\n what offer you choose?: ");
            string offer = Console.ReadLine();

            Console.WriteLine("Great mate you choose");
            Console.WriteLine("Your Name is:" + login.Name);
            Console.WriteLine("Your Surname: " + login.Surname);
            Console.WriteLine("Education: " + login.Ed);
            Console.WriteLine("Offer: " + offer);
            Console.WriteLine("the work as " + offer + " is waiting for you!");
            Console.ReadKey();


        }
    }
}
