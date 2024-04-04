using Microsoft.AspNetCore.Mvc;

namespace WebApplicationLesson1.Controllers
{
    public class CalculatorController : Controller
    {
        public string Index(double a, double b, char c)
        {            
            if (c == '*')
                return $"{a} {c} {b} = {a * b}";
            if (c == '-')
                return $"{a} {c} {b} = {a - b}";
            if (c == '/' && b != 0)
                return $"{a} {c} {b} = {a / b}";
            if (c == '/' && b == 0)
                return "Ошибка: деление на ноль.";
            if (c != '+' && c != 0)
                return "Некорректная операция.";
            return $"{a} + {b} = {a + b}";
        }
    }
}
