using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Esercizio.BL.DTO;
using Esercizio.BL.Manager;
using Esercizio.BL.Mapper;
using Esercizio.DAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Esercizio.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FiguraProfessionaleController : ControllerBase
    {
        private readonly ManagerFigureProfessionali ManagerFigureProfessionali;
        public FiguraProfessionaleController(IUnitOfWork iunitofwork)
        {
            ManagerFigureProfessionali = new ManagerFigureProfessionali(iunitofwork);
        }

        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(ManagerFigureProfessionali.GetAll());

            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPost]
        [Route("Add")]
        public IActionResult Add([FromBody] DTOFiguraProfessionale dTOFiguraProfessionale)
        {
            try
            {
                return Ok(ManagerFigureProfessionali.Add(dTOFiguraProfessionale));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPost]
        [Route("Delete")]
        public IActionResult Delete([FromBody] DTOFiguraProfessionale dTOFiguraProfessionale)
        {
            try
            {
                return Ok(ManagerFigureProfessionali.Delete(dTOFiguraProfessionale));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPut]
        [Route("Update")]
        public IActionResult Update([FromBody] DTOFiguraProfessionale dTOFiguraProfessionale)
        {
            try
            {
                return Ok(ManagerFigureProfessionali.Update(dTOFiguraProfessionale));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}