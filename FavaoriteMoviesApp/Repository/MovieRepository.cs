using FavaoriteMoviesApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FavaoriteMoviesApp.Repository
{
    interface MovieRepository : IRepository<Movie>
    {
        public void Add(Movie entity)
        {
            entity.Id = StaticDb.Movies.Count + 1;
            StaticDb.Movies.Add(entity);
        }

        public void Delete(int id)
        {
            Movie movie = GetById(id);
            /*if (movie == null)
            {
                throw new Exception($"Not such movie with ID: {id}");
            }*/
            StaticDb.Movies.Remove(movie);
        }

        public List<Movie> GetAll()
        {
            return StaticDb.Movies;
        }

        public Movie GetById(int id)
        {
            return StaticDb.Movies.SingleOrDefault(movie => movie.Id == id);
        }

        public void Update(Movie entity)
        {
            Movie movie = GetById(entity.Id);
            /*if (movie == null)
            {
                throw new Exception($"Not such movie with ID: {entity.Id}");
            }*/
            int idxOfMovie = StaticDb.Movies.IndexOf(movie);
            StaticDb.Movies[idxOfMovie] = entity;
        }
    }
}
