using Zeiss.DL;

namespace Zeiss.BL
{
    public class CustomerBL
    {
        public string GetTodayDate()
        {
            string date = CustomerDL.GetDate();
            return date;
        }
    }
    public class CustomerBA
    {
        public string FirstName;
        public string LastName;
        public Int64 MobileNumber;
        public string Gender;
        public string City;

        public CustomerBA GetCustomerByMobileNum(Int64 MobileNumber)
        {
            CustomerDA cstmrDA = CustomerDA.GetCustomerByMobileNum(MobileNumber);

            CustomerBA cstmrBA=new CustomerBA();
            cstmrBA.FirstName = cstmrDA.FirstName;
            cstmrBA.LastName = cstmrDA.LastName;
            cstmrBA.MobileNumber = cstmrDA.MobileNumber;
            cstmrBA.Gender = cstmrDA.Gender;
            cstmrBA.City = cstmrDA.City;
            return cstmrBA;
        }
    }
}