using FavaoriteMoviesApp.Helpers.Mappers;
using FavaoriteMoviesApp.Helpers.Validators;
using FavaoriteMoviesApp.Models;
using FavaoriteMoviesApp.Models.DtoModels;
using FavaoriteMoviesApp.Models.Enums;
using FavaoriteMoviesApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FavaoriteMoviesApp.Services
{
    public class MovieService : IMovieService
    {
        private readonly IRepository<Movie> _movieRepo;

        public MovieService(IRepository<Movie> movieRepo)
        {
            _movieRepo = movieRepo;
        }

        public void Add(MovieDto entity)
        {
            Movie movie = MovieMapper.MovieDtoToMovie(entity);
            if (movie.Title == string.Empty || movie.Title == null)
            {
                throw new Exception("Please enter a movie title.");
            }
            _movieRepo.Add(movie);
        }

        public void Delete(int id)
        {
            Movie movie = _movieRepo.GetById(id);
            if (movie == null)
            {
                throw new Exception($"Not such movie with ID: {id}");
            }
            _movieRepo.Delete(id);
        }

        public List<MovieDto> GetAllMovies()
        {
            List<Movie> movies = _movieRepo.GetAll();
            List<MovieDto> moviesDto = movies
                .Select(movie => MovieMapper.MovieToMovieDto(movie))
                .ToList();
            return moviesDto;
        }

        public List<MovieDto> GetByGenre(Genre genre)
        {
            List<Movie> movies = _movieRepo.GetAll();
            List<MovieDto> moviesDto = movies
                .Where(movie => movie.Genre == genre)
                .Select(x => MovieMapper.MovieToMovieDto(x))
                .ToList();
            return null;
        }

        public MovieDto GetById(int id)
        {
            Movie movie = _movieRepo.GetById(id);
            if (movie == null)
            {
                throw new Exception("No such movie with that id");
            }
            return MovieMapper.MovieToMovieDto(movie);
        }

        public void Update(MovieDto entity)
        {
            Movie movie = _movieRepo.GetById(entity.Id);
            if (movie == null)
            {
                throw new Exception($"Not such movie with ID: {entity.Id}");
            }
            if (!MovieValidator.ValidateTitle(movie.Title))
            {
                throw new Exception("Title cant be empty.");
            }
            Movie smt = MovieMapper.MovieDtoToMovie(entity);
            _movieRepo.Update(smt);
        }
    }
}
