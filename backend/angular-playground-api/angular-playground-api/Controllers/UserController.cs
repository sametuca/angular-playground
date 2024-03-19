using Microsoft.AspNetCore.Mvc;

namespace angular_playground_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {

        [HttpGet(Name = "GetAllUser")]
        public UserViewModel GetAllUser()
        {
            return new UserViewModel
            {
                Users = new List<User>
                {
                    new User
                    {
                        UserId = 1,
                        UserName = "John",
                        UserSurname = "Doe"
                    },
                    new User
                    {
                        UserId = 2,
                        UserName = "Jane",
                        UserSurname = "Doe2"
                    }
                }
            };
        }
    }

    public class UserViewModel
    {
        public List<User> Users { get; set; }
    }

    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserSurname { get; set; }
        public string FullName
        {
            get
            {
                return $"{UserName} {UserSurname}";
            }
            set
            {

            }
        }
    }
}
