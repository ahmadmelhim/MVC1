using Microsoft.AspNetCore.Mvc;

namespace Session1.Controllers
{
    public class UsersController : Controller
    {
        public ViewResult GetAll()
        {
            List<string> users = new List<string>()
            {
                 "Ahmad","Tareq","anas","Ali","mohammad"
             };
            var age = 30;
            return View("Index", users);
        }

        public ViewResult Create()
        {
            return View("Create");
        }
        public ViewResult Details()
        {
            return View("Details");
        }
    }
}
