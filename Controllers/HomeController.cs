using System;
using System.Web.Mvc;
using VisitorsInvites.Models;

namespace VisitorsInvites.Controllers {

    public class HomeController : Controller {

        public ViewResult Index() {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good morning" : "Good afternoon";
            return View();
        }

        [HttpGet]
        public ViewResult RsvpForm() {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse) {
            if (ModelState.IsValid) {
                // Send guestResponse to admin email.
                return View("Thanks", guestResponse);
            } else {
                // Fault check is found - repeat the form display.
                return View();
            }
        }
    }
}
