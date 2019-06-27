using System;
using OrderProcessing;
namespace TestExplicitIntrApp
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderDetails details = new OrderDetails();
            
           IOrderDetails iOrder = details;
           iOrder.ShowDetails();

          //  ICustomerDetails iCustomer = details;
          //  iCustomer.ShowDetails();



        }
    }
}
