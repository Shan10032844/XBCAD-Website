using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using SCHOOL.Models;

namespace SCHOOL.Controllers
{
    public class VolunteerController : Controller
    {
        // Static list to simulate database (for demonstration)
        private static List<VolunteerOpportunity> opportunities = new List<VolunteerOpportunity>
        {
            new VolunteerOpportunity
            {
                Id = 1,
                Title = "Bus Monitor",
                Description = "Assist in monitoring students on the bus.",
                ContactInfo = "contact@school.org"
            },
            new VolunteerOpportunity
            {
                Id = 2,
                Title = "Event Helper",
                Description = "Help organize school events.",
                ContactInfo = "events@school.org"
            }
        };

        // Display events
        public IActionResult Opportunities()
        {
            return View(opportunities);
        }

        // Handle form submission
        [HttpPost]
        public IActionResult Create(string EventName, string Duration, string EventDate, string Description)
        {
            var newOpportunity = new VolunteerOpportunity
            {
                Id = opportunities.Count + 1,
                Title = EventName,
                Description = $"{Description} (Duration: {Duration}, Date: {EventDate})",
                ContactInfo = "new.event@school.org" // Default contact info, update as needed
            };

            opportunities.Add(newOpportunity);

            return RedirectToAction("Opportunities");
        }
    }
}
