using CRUD_web_api.Models;
using CRUD_web_api.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_web_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        private readonly IUserRepository UserRepository;

        public UserController(IUserRepository userRepository)
        {
            this.UserRepository = userRepository;
        }

        [HttpGet(Name ="GetAll")]
        public async Task<ActionResult<List<User>>> GetAll()
        {
            IEnumerable<User> users = await UserRepository.GetAll();
            return Ok(users);
        }

        [HttpPost]
        public async Task<ActionResult<User>> Add([FromBody] User model)
        {
            await UserRepository.Add(model);
            return Ok(model);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<User>> Update([FromBody] User model, long id)
        {
            model.Id = id;
            await UserRepository.Update(model, id);
            return Ok(model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> Remove(long id)
        {
            bool apagado = await UserRepository.Remove(id);
            return Ok(apagado);
        }
    }
}
