
namespace OrderProcessing
{
   public  interface IOrderDetails
    { void ShowDetails();   }

    public   interface ICustomerDetails
    {  void ShowDetails();    }

    //Explicit Interface Inheritance

    public class OrderDetails:ICustomerDetails,IOrderDetails
    {   void ICustomerDetails.ShowDetails()
        {
           
        }

        void IOrderDetails.ShowDetails()
        {
        }
    }
}
