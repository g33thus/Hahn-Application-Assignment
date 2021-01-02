using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hahn.ApplicatonProcess.December2020.Domain.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Hahn.ApplicatonProcess.December2020.Web.Controllers
{
    [Route("api/[controller]")]
    public class ApplicantController : Controller
    {
        private readonly ILogger<ApplicantController> _logger;
        //private readonly IApplicantManager _applicantManager;

        public ApplicantController(ILogger<ApplicantController> logger 
            //IApplicantEngine applicantManager
            )
        {
            //_userManager = userManager;
        }


        [HttpGet]
        public async Task<IActionResult> GetAllApplicants([FromQuery]int id)
        {
            
            //if (true)
            //{
            //    return Ok(userList);
            //}
            //else
            //{
    return NoContent();
            //}
        }

        [HttpPost]
        public async Task<IActionResult> PostApplicant([FromBody] ApplicantDTO applicantDTO)
        {
            //bool isUserAddOrEdit = await _userManager.AddOrEditUser(userDTO);
            //if (isUserAddOrEdit)
            //{
            //    return Ok(isUserAddOrEdit);
            //}
            //else
            //{
                return NoContent();
            //}
        }
        [HttpPut]
        public async Task<IActionResult> UpdateApplicant([FromBody] ApplicantDTO applicantDTO)
        {
            return NoContent();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteUser([FromQuery] int id)
        {
            //bool deleteUser = await _userManager.DeleteUser(userId);
            //if (deleteUser)
            //{
            //    return Ok(deleteUser);
            //}
            //else
            //{
               return NoContent();
            //}
        }
    }
}
