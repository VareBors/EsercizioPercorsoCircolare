using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Esercizio.BL.Manager;
using Esercizio.BL.DTO;
using Esercizio.DAL;

namespace Esercizio.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RisorsaController : ControllerBase
    {
        private readonly ManagerRisorse managerRisorse;
        public RisorsaController(IUnitOfWork iunitOfWork)
        {
            managerRisorse = new ManagerRisorse(iunitOfWork);
        }

        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(managerRisorse.GetAll());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPost]
        [Route("Add")]
        public IActionResult Add([FromBody] DTORisorsa dTORisorsa)
        {
            try
            {
                return Ok(managerRisorse.Add(dTORisorsa));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPost]
        [Route("Delete")]
        public IActionResult Delete([FromBody] DTORisorsa dTORisorsa)
        {
            try
            {
                return Ok(managerRisorse.Delete(dTORisorsa));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPut]
        [Route("Update")]
        public IActionResult Update([FromBody] DTORisorsa dTORisorsa)
        {
            try
            {
                return Ok(managerRisorse.Update(dTORisorsa));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}