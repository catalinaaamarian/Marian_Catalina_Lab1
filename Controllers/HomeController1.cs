using Microsoft.AspNetCore.Mvc;

namespace Marian_Catalina_Lab1.Controllers
{
    public class HomeController1 : Controller
    {
 
        public string Index()
        {
            return "Welcome to our application! We're glad to have you here.";
        }

        public string Greeting()
        {
            return "Hello! Thank you for visiting our website.";
        }

    
        public string DisplayUserInfo(string userName, int userId)
        {
            return $"User Information - Name: {userName}, User ID: {userId}";
        }
    }
}