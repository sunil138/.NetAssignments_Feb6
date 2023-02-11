using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDetails_Feb6
{
    class Bank
    {
        protected class Personal : Bank 
        { 
            public void PersonalDetails()
            {
                Console.WriteLine("Personal Details for the bank");
            }
        }

        private class Salary : Bank
        {
            public void SalaryDetails()
            {
                Console.WriteLine("Salary details for the bank"); 
            }
        }

    }
    class Program:Bank 
    {
        static void Main(string[] args)
        {
            Personal personal = new Personal();
            personal.PersonalDetails();
            
        }
    }
}
