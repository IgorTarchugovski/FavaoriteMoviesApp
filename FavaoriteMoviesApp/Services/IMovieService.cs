using FavaoriteMoviesApp.Models;
using FavaoriteMoviesApp.Models.DtoModels;
using FavaoriteMoviesApp.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FavaoriteMoviesApp.Services
{
    public interface IMovieService
    {
        List<MovieDto> GetAllMovies();
        MovieDto GetById(int id);
        List<MovieDto> GetByGenre(Genre genre);
        void Add(MovieDto entity);
        void Delete(int id);
        void Update(MovieDto entity);
    }
}
