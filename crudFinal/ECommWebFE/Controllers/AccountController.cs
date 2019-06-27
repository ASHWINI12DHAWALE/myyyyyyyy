using BLL;
using System.Web.Mvc;
using System.Web.Security;

namespace ECommWebFE.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }
        //POST:Account
        [HttpPost]
        public ActionResult Login(string username,string password,string returnUrl)
        {

            if (AccountManager.Validate(username,password))
            {
                FormsAuthentication.SetAuthCookie(username, false);
                return Redirect(returnUrl ?? Url.Action("Msg", "Home"));
            }
            else
            {
                return View();
            }
        }
        public ActionResult Demo()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(int id,string name,string city,string email,string password, string mob,string returnUrl)
        {
            if(AccountManager.Insert(id,name,city,email, password, mob))
            {
                return Redirect(returnUrl ?? Url.Action("Msg", "Home"));
            }
            else
            {
                return View();
            }
        }

        public ActionResult Update()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Update(int id,string password,string returnUrl)
        {
            if(AccountManager.update(id,password))
            {
                return Redirect(returnUrl ?? Url.Action("Msg", "Home"));
            }
            else
            {
                return View();
            }
        }
        public ActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Delete(int Id,string returnUrl)
        {
            if (AccountManager.Delete(Id))
            {
                return Redirect(returnUrl ?? Url.Action("Msg", "Home"));
            }
            else
            {
                return View();
            }
        }
     
        }
        }
    

