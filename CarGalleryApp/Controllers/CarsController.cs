using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarGalleryApp.Models;
using CarGalleryApp.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarGalleryApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly CarService carService;

        public CarsController(CarService carService) 
        {
            this.carService = carService;
        }

        // GET: api/Cars
        [HttpGet]
        public List<Car> Get()
        {
            return carService.Get();            
        }

        // GET: api/Cars/5
        [HttpGet("{id}", Name = "Get")]
        public Car Get(string id)
        {
            return carService.Get(id);
        }

        // POST: api/Cars
        [HttpPost]
        public void Post([FromBody] Car car)
        {
            carService.Create(car);
        }

        // PUT: api/Cars/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody] Car car)
        {
            carService.Update(id, car);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            carService.Remove(id);
        }
    }
}
