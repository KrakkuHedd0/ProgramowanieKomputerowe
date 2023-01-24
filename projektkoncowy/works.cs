using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projektkoncowy
{
    internal class works
    {
        private string chef = "chef";
        private string doctor = "doctor";
        private string graphic_designer = "graphic";
        private string developer = "developer";
        private string accountant = "accountant";
        private string trainer = "trainer";
        private string lawyer = "lawyer";


        public string Offer(string offers)
        {
            if (offers == chef)
            {
                return chef;
            }

            if (offers == doctor)
            {
                return doctor;
            }

            if (offers == graphic_designer)
            { 
                return graphic_designer;
            }

            if (offers == developer)
            {
                return developer;
            }

            if (offers == accountant)
            {
                return accountant;
            }

            if (offers == trainer)
            {
                return trainer;
            }

            if (offers == lawyer)
            {
                return lawyer;
            }

            else 
            {
                return "there is no such offer";
            }


        }
        
    }
}
