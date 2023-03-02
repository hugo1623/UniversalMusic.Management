using Microsoft.AspNetCore.Mvc;
using UniversalMusic.Management.Application.Dtos;
using UniversalMusic.Management.Application.Interfaces;
using UniversalMusic.Management.Entity;

namespace UniversalMusic.Management.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtistsController : ControllerBase
    {
        private IArtistsApplication artistsApplication;

        public ArtistsController( IArtistsApplication artistsApplication)
        {
            this.artistsApplication= artistsApplication;  
        }

        [HttpGet]
        public async Task<ActionResult<List<ArtistForListDto>>> GetAll()
        {
            var artists = await artistsApplication.GetArtists();
            return artists;
        }
        [HttpGet("id:int")]
        public async Task<ActionResult<ArtistDetailDto>> GetById(int id)
        {
            var artist = await artistsApplication.GetArtist(id);
            return artist;
        }
        [HttpPost]
        public async Task<ActionResult> Insert([FromBody] ArtistForCreateDto artistForCreateDto)
        {
            await artistsApplication.InsertArtist(artistForCreateDto);
            return Ok();
        }
        [HttpPut("id:int")]
        public async Task<ActionResult> Update(int id,[FromBody] ArtistForEditDto artistForEditDto)
        {
            await artistsApplication.UpdateArtist(id, artistForEditDto);
            return Ok();
        }

    }
}
