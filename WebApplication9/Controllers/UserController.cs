using Microsoft.AspNetCore.Mvc;
using WebApplication9.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication9.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        IUser _iuser;

        public UserController(IUser iuser)
        {
            _iuser = iuser;
        }
        // GET: api/<UserController>
        [HttpGet]
        public  IActionResult Get()
        {

           var respond = _iuser.GetAll();
            if (respond.isok)
            {
                return Ok(respond.user);
            }
            return BadRequest();
        }
        /*
        [HttpGet("[action]")]
        public  IActionResult GetSelected()
        {

            var respond =  _iuser.GetSelected();

            var respond2 = from myuser in respond.user
                           select new
                           {
                               name = myuser.Name
                           };

            if (respond.isok)
            {
                return Ok(respond2);
            }
            return BadRequest();
        }
        */


        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UserController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
