using Microsoft.AspNetCore.Mvc;
using System;
using DatabaseAccess;
using Microsoft.AspNetCore.Http;

namespace NarodnaSkupstina.Controllers
{
    public class RadnaTelaController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiRadnaTela")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetRadnaTela()
        {
            try
            {
                return new JsonResult(DTOManager.vratiSvaRadnaTela());
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpPost]
        [Route("DodajRadnoTelo")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult AddRadnoTelo(RadnoTeloBasic sed, string dan)
        {
            try
            {
                DTOManager.DodajRadnoTelo(sed, dan);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpPut]
        [Route("IzmeniSpratRadnoTelo/{sprat}/{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult ChangeSpratRadnoTelo(int sprat, int id)
        {
            try
            {
                DTOManager.izmeniSpratRadnoTelo(sprat, id);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpPut]
        [Route("IzmeniBrojRadnoTelo/{broj}/{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult ChangeBrojRadnoTelo(int broj, int id)
        {
            try
            {
                DTOManager.izmeniBrojRadnoTelo(broj, id);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpDelete]
        [Route("IzmeniBrojRadnoTelo/{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult DeleteRadnoTelo(int id)
        {
            try
            {
                DTOManager.izbrisiRadnoTelo(id);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }
    }
}
