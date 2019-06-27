using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constitution
{
   public interface IAccountingService
    {
             double Balance { get; set; }
             
    }


    public interface ICorporateAccountingService:IAccountingService
    {
        void FllowCSR();


    }

}
