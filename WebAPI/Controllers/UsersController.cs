using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }
       // [HttpGet]
        //public IActionResult GetAll()
        //{
        //    var result = _userService.GetAll();           REFACTOR 
        //    if (result.Success)
        //    {
        //        return Ok(result);
        //    }
        //    return BadRequest(result);
        //}

        [HttpGet("GetByUserEmail")]
        public IActionResult GetByUserEmail(string email)
        {
            var result = _userService.GetByMail(email);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

       // [HttpGet]
        //public IActionResult GetByCustomerId(int id)
        //{
        //    var result = _userService.GetByCustomerId(id);
        //    if (result.Success)
        //    {
        //        return Ok(result);
        //    }
        //    return BadRequest(result);
        //}


        //[HttpPost]
        //public IActionResult UserAdd([FromBody] User user)
        //{
        //    var result = _userService.AddUser(user);
        //    if (result.Success)
        //    {
        //        return Ok(result);
        //    }
        //    return BadRequest(result.Message);
        //}

        //[HttpPost]
        //public IActionResult UserUpdate([FromBody] User user)
        //{
        //    var result = _userService.Update(user);
        //    if (result.Success)
        //    {
        //        return Ok(result);
        //    }
        //    return BadRequest(result.Message);
        //}


        
        //[HttpPost]
        //public IActionResult CustomerDelete([FromBody] User user)
        //{
        //    var result = _userService.Delete(user);
        //    if (result.Success)
        //    {
        //        return Ok(result);
        //    }
        //    return BadRequest(result.Message);
        //}

        //[HttpPost]
        //public IActionResult ChangeUserPassword(ChangePasswordDto changeUserPassword)
        //{
        //    var result = _userService.ChangeUserPassword(changeUserPassword);
        //    if (result.Success)
        //    {
        //        return Ok(result);
        //    }

        //    return BadRequest(result);
        //}
    }
}
