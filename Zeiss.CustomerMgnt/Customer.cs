using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeiss.BL;

namespace Zeiss.CustomerMgnt
{
    internal class Customer
    {
        string FirstName;
        string LastName;
        string Gender;
        string City;

        public void PrintCustomerDetails(Int64 MobileNumber)
        {
            CustomerBL customerBL = new CustomerBL();
            Console.WriteLine(customerBL.GetTodayDate());
            Console.WriteLine("Fetching Customer Details......");

            CustomerBA customerBA = new CustomerBA();
            customerBA=customerBA.GetCustomerByMobileNum(MobileNumber);
            FirstName=customerBA.FirstName;
            LastName=customerBA.LastName;
            Gender=customerBA.Gender;
            City=customerBA.City;

            Console.WriteLine("Queried Number: "+customerBA.MobileNumber);
            Console.WriteLine("Name: "+FirstName+" "+LastName);
            Console.WriteLine("Gender: "+Gender+"  City: "+City);

            Console.WriteLine("Thanks");
         }
        
    }
}
