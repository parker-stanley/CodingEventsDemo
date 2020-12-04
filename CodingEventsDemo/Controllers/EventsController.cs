using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodingEventsDemo.Data;
using CodingEventsDemo.Models;
using CodingEventsDemo.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace coding_events_practice.Controllers
{
    public class EventsController : Controller
    {
<<<<<<< HEAD
        static private Dictionary<string, string> Events = new Dictionary<string, string>();

=======
>>>>>>> 838dc503f348ec653d85ad4ca948f9a13b665aeb
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            List<Event> events = new List<Event>(EventData.GetAll());

            return View(events);
        }

        //GET /<controller>/
        [HttpGet]
        public IActionResult Add()
        {
<<<<<<< HEAD
=======
            AddEventViewModel addEventViewModel = new AddEventViewModel();

            return View(addEventViewModel);
        }

        [HttpPost]
        public IActionResult Add(AddEventViewModel addEventViewModel)
        {
            if (ModelState.IsValid)
            {
                Event newEvent = new Event
                {
                    Name = addEventViewModel.Name,
                    Description = addEventViewModel.Description,
                    ContactEmail = addEventViewModel.ContactEmail,
                    Type = addEventViewModel.Type
                };

                EventData.Add(newEvent);

                return Redirect("/Events");
            }

            return View(addEventViewModel);
        }

        public IActionResult Delete()
        {
            ViewBag.events = EventData.GetAll();
>>>>>>> 838dc503f348ec653d85ad4ca948f9a13b665aeb

            return View();
        }

        [HttpPost]
<<<<<<< HEAD
        [Route("/Events/Add")]
        public IActionResult NewEvent(string name, string description)
        {
            Events.Add(name, description);
=======
        public IActionResult Delete(int[] eventIds)
        {
            foreach (int eventId in eventIds)
            {
                EventData.Remove(eventId);
            }
>>>>>>> 838dc503f348ec653d85ad4ca948f9a13b665aeb

            return Redirect("/Events");
        }

    }
}
