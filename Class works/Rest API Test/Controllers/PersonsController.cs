using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Rest_API_Test.Controllers
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
    }
    public class PersonsController : ApiController
    {
        static List<Person> people = new List<Person>()
        {
            new Person{Id=101, Name="Rahim", Salary=1000.0 },
            new Person{Id=102, Name="karim", Salary=1100.0 },
            new Person{Id=103, Name="Tuhin", Salary=2100.0 }
        };

        public IHttpActionResult Get()
        {
            return Ok(people);
        }

        public IHttpActionResult Get(int id)
        {
            var person = people.Find(x => x.Id == id);
            if (person != null)
                return Ok(person);
            else
                return StatusCode(HttpStatusCode.NoContent);
        }
        public IHttpActionResult Post(Person person)
        {
            people.Add(person);
            return Created("ABC", person);
        }

        public IHttpActionResult Put(Person person, int id)
        {
            var personToEdit = people.Find(x => x.Id == id);
            personToEdit.Name = person.Name;
            personToEdit.Salary = person.Salary;

            return Ok(personToEdit);
        }

        public IHttpActionResult Delete(int id)
        {
            var person = people.Find(x => x.Id == id);
            people.Remove(person);
            return StatusCode(HttpStatusCode.NoContent);
        }

    }
}
