using Microsoft.AspNetCore.Mvc;
using SCHOOL.Models;
using System.Collections.Generic;

namespace SCHOOL.Controllers
{
    public class BusController : Controller
    {
        public IActionResult Schedule()
        {
            // Example data
            var buses = new List<Bus>
            {
                new Bus { BusNumber = "101", Route = "Route A", DepartureTime = "8:00 AM", ArrivalTime = "9:00 AM", Status = "On Time" },
                new Bus { BusNumber = "102", Route = "Route B", DepartureTime = "9:30 AM", ArrivalTime = "10:30 AM", Status = "Delayed" }
            };

            return View(buses);
        }

        public IActionResult Status()
        {
            // Example data
            var busStatus = new List<Bus>
            {
                new Bus { BusNumber = "101", Status = "In Transit" },
                new Bus { BusNumber = "102", Status = "Delayed" }
            };

            return View(busStatus);
        }
    }
}
