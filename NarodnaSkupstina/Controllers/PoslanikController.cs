using Microsoft.AspNetCore.Mvc;
using System;
using DatabaseAccess;
using Microsoft.AspNetCore.Http;
using static DatabaseAccess.DTOs;
using NarodnaSkupstinaSBP.Entiteti;

namespace NarodnaSkupstina.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PoslanikController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiPoslanike")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetPoslanike()
        {
            try
            {
                return new JsonResult(DTOManager.vratiSvePoslanike());
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpPost]
        [Route("DodajPoslanika")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult AddPoslanika([FromBody]Poslanik poslanik)
        {
            try
            {
               DTOManager.dodajPoslanika(poslanik);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpDelete]
        [Route("IzbrisiPoslanika/{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult DeletePoslanika(int id)
        {
            try
            {
                DTOManager.obrisiPoslanika(id);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpPut]
        [Route("IzmeniAdresuPoslanika/{id}/{adresa}/{mesto}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult ChangeAdresuPoslanika(int id, string adresa, string mesto)
        {
            try
            {
                DTOManager.IzmeniAdresuPoslanika(id, adresa, mesto);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpPut]
        [Route("IzmeniIzbornuListuPoslanika/{id}/{izbornaLista}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult ChangeAdresuPoslanika(int id, string izbornaLista)
        {
            try
            {
                DTOManager.IzmeniIzbornuListuPoslanika(id, izbornaLista);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }
    }
}
