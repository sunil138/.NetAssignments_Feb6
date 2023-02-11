using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDetails_Feb6
{
    public class BankOne
    {
        protected void PersonalDetailsOne()
        {
            Console.WriteLine("Personal details");
        }
        private void SalaryDetailsOne()
        {
            Console.WriteLine("salary details"); 
        }
    }
    class CardDetails:BankOne
    {
        static void Main(string[] args)
        {
           CardDetails card= new CardDetails();
            card.PersonalDetailsOne();
            //card.SalaryDetailsOne();  
            
        }
    }
}
