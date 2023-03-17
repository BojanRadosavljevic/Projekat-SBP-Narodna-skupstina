using Microsoft.AspNetCore.Mvc;
using System;
using DatabaseAccess;
using Microsoft.AspNetCore.Http;

namespace NarodnaSkupstina.Controllers
{
    public class RadniDaniController : ControllerBase
    {
        [HttpPost]
        [Route("DodajRadniDan")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult AddRadniDan(RadniDanBasic sed, int dan)
        {
            try
            {
                DTOManager.DodajRadniDan(sed, dan);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpPut]
        [Route("IzmeniPocetakRadaRadniDan/{pocetakRada}/{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult ChangePocetakRadaRadniDan(string pocetakRada, int id)
        {
            try
            {
                DTOManager.izmeniPocetakRadaRadniDan(pocetakRada, id);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpDelete]
        [Route("IzbrisiRadniDan/{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult DeleteRadniDan(int id)
        {
            try
            {
                DTOManager.izbrisiRadniDan(id);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiRadneDane")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetRadniDani()
        {
            try
            {
                return new JsonResult(DTOManager.vratiSveRadneDane());
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

    }
}
