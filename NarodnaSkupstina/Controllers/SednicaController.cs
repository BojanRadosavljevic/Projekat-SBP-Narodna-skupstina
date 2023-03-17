using Microsoft.AspNetCore.Mvc;
using System;
using DatabaseAccess;
using Microsoft.AspNetCore.Http;

namespace NarodnaSkupstina.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class SednicaController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiSednice")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetSednice()
        {
            try
            {
                return new JsonResult(DTOManager.VratiSveSednice());
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpPost]
        [Route("DodajSednicu")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult AddSednica([FromBody] SednicaBasic sednica)
        {
            try
            {
                DTOManager.DodajSednicu(sednica);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpPost]
        [Route("DodajVandrednuSednicu/{tip}/{inicijativa}/{broj}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult AddVandrednaSednica(SednicaBasic sed, string tip, string inicijativa, int broj)
        {
            try
            {
                DTOManager.DodajSednicuVandrednu(sed, tip, inicijativa, broj);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpPut]
        [Route("IzmeniTipSednice/{id}/{tip}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult ChangeTipSednice(int id, string tip)
        {
            try
            {
                DTOManager.izmeniTipSednice(id, tip);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpPut]
        [Route("IzmeniBrojSazivaSednice/{id}/{brojSaziva}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult ChangeBrojSazivaSednice(int id, int brojSaziva)
        {
            try
            {
                DTOManager.izmeniBrojSazivaSednice(id, brojSaziva);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpPut]
        [Route("IzmeniBrojZasedanjaSednice/{id}/{brojZasedanja}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult ChangeBrojZasedanjaSednice(int id, int brojZasedanja)
        {
            try
            {
                DTOManager.izmeniBrojZasedanjaSednice(id, brojZasedanja);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpDelete]
        [Route("IzbrisiSednicu/{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult DeleteSednice(int id)
        {
            try
            {
                DTOManager.izbrisiSednicu(id);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }


    }
}
