using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiLibrary.Models;
using ApiLibrary.Service.Interface;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
namespace ApiSisProducts.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly IUserService UserService;

        public UserController(IUserService UserService)
        {
            this.UserService = UserService;
        }

        // GET: api/values
        [HttpGet]
        

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public ActionResult<bool> Post([FromBody]User user)
        {
            if (user != null)
            {
                UserService.AddUser(user);
                return true;
            }
            else
            {
                return BadRequest();
            }

        }

        [HttpPost("login")]
        public ActionResult<bool> Login([FromBody]User user)
        {
            if (user == null)
            {
                return true;
            }
            else
            {
                return BadRequest();
            }

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}