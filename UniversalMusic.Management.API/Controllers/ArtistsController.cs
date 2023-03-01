using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UniversalMusic.Management.Application.Interfaces;
using UniversalMusic.Management.Entity;

namespace UniversalMusic.Management.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtistsController : ControllerBase
    {
        private IArtistsApplication artistsApplicarion;

        public ArtistsController( IArtistsApplication artistsApplication)
        {
            this.artistsApplicarion= artistsApplication;  
        }

        [HttpGet]
        public async Task<ActionResult<List<Artist>>> GetAll()
        {
            var artists = await artistsApplicarion.GetArtists();
            return artists;
        }
        [HttpGet("id:int")]
        public async Task<ActionResult<Artist>> GetById(int id)
        {
            var artist = await artistsApplicarion.GetArtist(id);
            return artist;
        }

    }
}
