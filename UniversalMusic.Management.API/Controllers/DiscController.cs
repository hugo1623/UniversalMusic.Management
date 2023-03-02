using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UniversalMusic.Management.Application.Dtos;
using UniversalMusic.Management.Application.Interfaces;
using UniversalMusic.Management.Entity;

namespace UniversalMusic.Management.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscController : ControllerBase
    {
        private IDiscsApplication discsApplication;

        public DiscController(IDiscsApplication discsApplication)
        {
            this.discsApplication = discsApplication;
        }

        [HttpGet]
        public async Task<ActionResult<List<DiscForListDto>>> GetAll()
        {
            var discs = await discsApplication.GetDiscs();
            return discs;
        }
        [HttpGet("id:int")]
        public async Task<ActionResult<DiscForDetailDto>> GetById(int id)
        {
            var disc = await discsApplication.GetDisc(id);
            return disc;
        }
    }
}
