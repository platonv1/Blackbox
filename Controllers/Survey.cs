using Blackbox.Models;
using Microsoft.AspNetCore.Mvc;

namespace Blackbox.Controllers
{
    public class Survey :Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult BasicInfo()
        {
            BasicInfo person1 = new BasicInfo();
            List<BasicInfo> PersonsList = new List<BasicInfo>();
            person1.Name = "Tom Cruise";
            person1.Age =  30;
            person1.Location = "Singapore";
            PersonsList.Add(person1);

            BasicInfo person2 = new BasicInfo();
            person2.Name = "Dwyne Johnson";
            person2.Age = 26;
            person2.Location = "Malaysia";
            PersonsList.Add(person2);

            BasicInfo person3 = new BasicInfo();
            person3.Name = "Nicolas Cage";
            person3.Age = 31;
            person3.Location = "Philippines";
            PersonsList.Add(person3);


            BasicInfo person4 = new BasicInfo();
            person4.Name = "Ellen DeGeneres";
            person4.Age = 38;
            person4.Location = "Thailand";
            PersonsList.Add(person4);

            return View(PersonsList);
        }

        public IActionResult LastPage()
        {
            return View();
        }
    }
}
