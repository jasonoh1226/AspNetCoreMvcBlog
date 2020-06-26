using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


using AspNetCoreMvcBlog.Models;
using AspNetCoreMvcBlog.Data;

namespace AspNetCoreMvcBlog.Controllers
{

    [Route("users")]
    public class UserController : Controller
    {

        private readonly DataContext _dataContext;

        public UserController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpGet("")]
        public IActionResult GetUsers()
        {
            var users = _dataContext.Users.ToList();
            return Json(users);
        }

    }
}
