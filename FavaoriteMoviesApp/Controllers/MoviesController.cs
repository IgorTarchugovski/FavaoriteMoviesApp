using FavaoriteMoviesApp.Models.DtoModels;
using FavaoriteMoviesApp.Models.Enums;
using FavaoriteMoviesApp.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FavaoriteMoviesApp.Controllers
{
    [Route("api/[controller]")] //localhost/api/movies
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieService _movieService;
        public MoviesController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        // GET: api/<MovieController>
        [HttpGet]
        public ActionResult<List<MovieDto>> GetAll([FromQuery] Genre genre) 
        { 
            try
            {
                if (genre == 0)
                {
                    return Ok(_movieService.GetAllMovies());
                }
                return Ok(_movieService.GetByGenre(genre));
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, new { Message = ex.Message });
            }
        }

        // GET api/<MovieController>/5
        [HttpGet("{id}")] // localhost/api/movies/5
        public ActionResult<MovieDto> Get(int id)
        {
            try
            {
                return Ok(_movieService.GetById(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet] //api/movies?genre=comedy
        public ActionResult<List<MovieDto>> GetByGenre([FromQuery] Genre genre)
        {
            try
            {
                return Ok(_movieService.GetByGenre(genre));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        // POST api/<MovieController>
        [HttpPost]
        public ActionResult Post([FromBody] MovieDto movieDto)
        {
            try
            {
                _movieService.Add(movieDto);
                return StatusCode(StatusCodes.Status201Created, new { Message = "Movie created succesfully"});
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<MovieController>/5
        [HttpPut("{id}")] // api/movies/update
        public ActionResult Put([FromBody] MovieDto moviesDto)
        {
            try
            {
                _movieService.Update(moviesDto);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<MovieController>/5
        [HttpDelete("{id}")] // api/movies/id
        public ActionResult Delete(int id)
        {
            try
            {
                _movieService.Delete(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
