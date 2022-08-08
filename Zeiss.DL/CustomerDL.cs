namespace Zeiss.DL
{
    public class CustomerDL
    {
        public static string GetDate()
        {
            return "09-07-2022";
        }
    }

    public class CustomerDA
    {
        public string FirstName;
        public string LastName;
        public Int64 MobileNumber;
        public string Gender;
        public string City;

        public static CustomerDA GetCustomerByMobileNum(Int64 MobileNumber)
        {
            CustomerDA cstmr = new CustomerDA();
            
            cstmr.FirstName = "Manorama";
            cstmr.LastName = "Rathore";
            cstmr.MobileNumber = MobileNumber;
            cstmr.Gender = "Female";
            cstmr.City = "Raipur";
            return cstmr;
        }

    }
}