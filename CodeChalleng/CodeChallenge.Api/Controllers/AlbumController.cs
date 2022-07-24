using Album.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Processor.Repository.Interfaces;

namespace CodeChallenge.Api.Controllers
{
    [Route("api/albums")]
    [ApiController]
    public class AlbumController : ControllerBase
    {
        private readonly IProcessorAlbum _processorAlbum;

        public AlbumController(IProcessorAlbum processorAlbum)
        {
            _processorAlbum = processorAlbum;
        }

        // get selected title from search function 
        [HttpGet]
        public async Task<ActionResult<List<AlbumTitleVM>>> GetAlbums([FromQuery] string search = "")
        {
            var AlbumTitles = await _processorAlbum.LoadInfo(search);

            return Ok(AlbumTitles);

        }


    }
}
