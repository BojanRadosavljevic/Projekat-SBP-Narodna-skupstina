using Microsoft.AspNetCore.Mvc;
using System;
using DatabaseAccess;
using Microsoft.AspNetCore.Http;
using NarodnaSkupstinaSBP.Entiteti;

namespace NarodnaSkupstina.Controllers
{
    public class PravniAktController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiAkte")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetAkte()
        {
            try
            {
                return new JsonResult(DTOManager.VratiSveAkte());
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiZakone")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetZakone()
        {
            try
            {
                return new JsonResult(DTOManager.VratiSveZakone());
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpPost]
        [Route("DodajBiraca")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult AddBiraca([FromBody] Biraci birac)
        {
            try
            {
                DTOManager.DodajBiraca(birac);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpPut]
        [Route("IzmeniTipAkta/{id}/{tip}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult ChangeTipAkta(int id, string tip)
        {
            try
            {
                DTOManager.izmeniTipAkt(id, tip);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpDelete]
        [Route("IzbrisiAkt/{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult DeleteAkt(int id)
        {
            try
            {
                DTOManager.izbrisiAkt(id);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }
    }
}
