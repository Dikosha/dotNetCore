using System;
using System.Text;
using Microsoft.AspNetCore.Mvc;

namespace Gradebook.Controllers
{
    
        public class MainController : Controller
        {
            // GET
            public IActionResult Index()
            {
                return View();
            }
            
            [HttpPost]
            public IActionResult Index(string name, string surname, string day, int month, int year, int group)
            {
                StringBuilder id = new StringBuilder(" ");

                char[] n = name.ToUpper().ToCharArray();
                char[] sn = surname.ToUpper().ToCharArray();

                string y = year.ToString();
                char[] yr = y.ToCharArray();
                
                string g = group.ToString();
                char[] gr = g.ToCharArray();
                Console.WriteLine(g);
                id.Append(sn[0]);
                id.Append(sn[1]);
                id.Append(n[0]);
                id.Append(g);
                id.Append(day); 
                id.Append(month);
                id.Append(yr[2]);
                id.Append(yr[3]);

            string genId = id.ToString();

                ViewData["GenId"] = genId;
                return View();
                
                /*
                 My ID Generator is very very simple: 
                 first symbol is First letter of the name, 
                 second - first letter of the surname,
                 next - sum of day and moth of birth
                 then - last digit of year of birth
                 fifth, sixth, seventh and eight - last three digits of group number 
                */
                
            }    
            
            
        }
    
}