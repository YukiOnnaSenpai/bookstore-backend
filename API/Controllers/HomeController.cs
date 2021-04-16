using API.DAO.Classes;
using API.Service;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IService<UserAccountDAO> _service;

        public HomeController(IService<UserAccountDAO> service)
        {
            _service = service;
        }

        [HttpPost]
        public void SignUp([FromBody] UserAccountDAO dao)
        {
            
        }

        [HttpPost]
        public void SignIn([FromBody] UserAccountDAO dao)
        {
        }

        [HttpPost]
        public void UsernameIsUnique([FromBody] string username)
        {
            //return _service.IsUsernameUnique();
        }
    }
}
