using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapi.Repository;

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumController : ControllerBase
    {

        private AlbumRepository Repository { get; init; }


        public AlbumController(AlbumRepository repository)
        {
            this.Repository = repository;
        }


        [HttpGet]
        public IActionResult GetAlbuns()
        {
            return Ok(this.Repository.GetAlbumsAsync());
        }

    }
}
