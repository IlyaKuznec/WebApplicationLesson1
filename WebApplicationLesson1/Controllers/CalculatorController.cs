using Microsoft.AspNetCore.Mvc;

namespace WebApplicationLesson1.Controllers
{
    public class CalculatorController : Controller
    {
        public string Index(double num1, double num2, char oper)
        {
            if (oper == '*')
                return $"{num1} {oper} {num2} = {num1 * num2}";
            if (oper == '-')
                return $"{num1} {oper} {num2} = {num1 - num2}";
            if (oper != '+' && oper != 0)
                return "Некорректная операция";
            return $"{num1} + {num2} = {num1 + num2}";            
        }
    }
}
