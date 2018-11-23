using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PatientsWebApp.Controllers
{
    [Route("api/[controller]")]
    public class PatientController : Controller
    {
        [HttpGet("/api/getpatients")]
        public IEnumerable<Patient> GetPatients()
        {
            List<Patient> patients = new List<Patient>();
            patients.Add(new Patient()
            {
                PatientId = 1,
                FirstName = "Kamlesh",
                LastName = "Joshi",
                Gender = "Male",
                DOB = DateTime.Now.Date,
                State = "Maharastra",
                City = "Pune"
            });
            patients.Add(new Patient()
            {
                PatientId = 1,
                FirstName = "Subhi",
                LastName = "Joshi",
                Gender = "Female",
                DOB = DateTime.Now.AddDays(-10).Date,
                State = "Maharastra",
                City = "Pune"
            });

            return patients;
        }

        [HttpGet("/api/getstates")]
        public IEnumerable<State> GetStates()
        {
            List<State> states = new List<State>();
            states.Add(new State()
            {
                Id = 1,
                Name = "Maharastra"

            });
            states.Add(new State()
            {
                Id = 2,
                Name = "Rajasthan"

            });

            return states;
        }

        [HttpGet("/api/getcities/{id}")]
        public IEnumerable<City> GetCities(int id)
        {
            List<City> cities = new List<City>();
            if (id == 1)
            {
                cities.Add(new City()
                {
                    Id = 1,
                    Name = "Maharastra"

                });
            }
            else
            {
                cities.Add(new City()
                {
                    Id = 2,
                    Name = "Rajasthan"

                });
            }
            return cities;
        }
        [HttpPost]
        public JsonResult SavePatient(Patient patient)
        {
            List<Patient> patients = new List<Patient>();
            patients.Add(new Patient()
            {
                PatientId = 1,
                FirstName = "Kamlesh",
                LastName = "Joshi",
                Gender = "Male",
                DOB = DateTime.Now.Date,
                State = "Maharastra",
                City = "Pune"
            });
            patients.Add(new Patient()
            {
                PatientId = 1,
                FirstName = "Subhi",
                LastName = "Joshi",
                Gender = "Female",
                DOB = DateTime.Now.AddDays(-10).Date,
                State = "Maharastra",
                City = "Pune"
            });

          
            if (!patients.Where(p=> patient.FirstName.Contains(p.FirstName)).Any())
            {
                return Json(new { success = true });
            }
            else
            {
                return Json(new { success = false });
            }
        }
    }

    public class Patient
    {
        public int PatientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime DOB { get; set; }
        public string State { get; set; }
        public string City { get; set; }
    }

    public class Patients
    {
        public static List<Patient> List { get; set; }
    }

    public class State
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}