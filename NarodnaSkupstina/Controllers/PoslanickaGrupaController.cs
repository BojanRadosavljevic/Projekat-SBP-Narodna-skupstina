using Microsoft.AspNetCore.Mvc;
using System;
using DatabaseAccess;
using Microsoft.AspNetCore.Http;
using NarodnaSkupstinaSBP.Entiteti;

namespace NarodnaSkupstina.Controllers
{
    public class PoslanickaGrupaController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiGrupe")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetGrupe()
        {
            try
            {
                return new JsonResult(DTOManager.vratiSveGrupe());
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpPost]
        [Route("DodajPoslanickGrupu")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult AddPoslanickaGrupa([FromBody] PoslanickaGrupa pgrupa)
        {
            try
            {
                DTOManager.dodajGrupu(pgrupa);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpPut]
        [Route("IzmeniImePoslanickeGrupe/{id}/{ime}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult ChangeImePoslanickeGrupa(int id, string ime)
        {
            try
            {
                DTOManager.izmeniImePoslanickeGrupe(id, ime);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpDelete]
        [Route("IzbrisiPoslanickuGrupe/{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult DeletePoslanickuGrupa(int id)
        {
            try
            {
                DTOManager.izbrisiPoslanickeGrupe(id);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

    }
}
