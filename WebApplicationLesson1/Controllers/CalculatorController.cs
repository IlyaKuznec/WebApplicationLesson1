using Microsoft.AspNetCore.Mvc;

namespace WebApplicationLesson1.Controllers
{
    public class CalculatorController : Controller
    {
        public string Index(int num1, int num2)
        {
            return $"{num1} + {num2} = {num1 + num2}";
        }
    }
}
