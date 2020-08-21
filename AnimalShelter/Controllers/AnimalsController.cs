using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using AnimalShelter.Models;

namespace AnimalShelter.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AnimalsController : ControllerBase
  {
    private AnimalShelterContext _db;

    public AnimalsController(AnimalShelterContext db)
    {
      _db = db;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Animal>> Get()
    {
      return _db.Animals.ToList();
    }

    [HttpPost]
    public void Post([FromBody] Animal animal)
    {
      _db.Animals.Add(animal);
      _db.SaveChanges();
    }

    [HttpGet("{id}")]
    public ActionResult<Animal> Get(int id)
    {
      return _db.Animals.FirstOrDefault(entry => entry.AnimalId == id);
    }
    
  }
}