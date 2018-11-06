using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dot_net_core_webapi_lesson.Models;
using Microsoft.AspNetCore.Mvc;

namespace dot_net_core_webapi_lesson.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private AppDbContext db = null;
        public UsersController(AppDbContext db) {
            this.db = db;
        }
        // GET api/values
        [HttpGet]
        public JsonResp Get()
        {
            return new JsonResp { Code = 0, Message = "Ok", Data =  db.Users.ToList()};
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public JsonResp Get(int id)
        {
            return new JsonResp { Code = 0, Message = "Ok", Data = db.Users.Find(id) };
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
        }

        // PUT api/values/5
        [HttpPut]
        public void Put([FromBody] User user)
        {
            db.Entry(user).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var user = db.Users.Find(id);
            db.Users.Remove(user);
            db.SaveChanges();
        }
    }
}
