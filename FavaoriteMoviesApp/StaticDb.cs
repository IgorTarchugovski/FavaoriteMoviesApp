using FavaoriteMoviesApp.Models;
using FavaoriteMoviesApp.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FavaoriteMoviesApp
{
    public static class StaticDb
    {
        public static List<Movie> Movies = new List<Movie>()
        {
            new Movie()
            {
                Id = 1,
                Title = "Titanik",
                Description = "A seventeen-year-old aristocrat falls in love with a kind but poor artist aboard the luxurious, ill-fated R.M.S. Titanic.",
                Genre = Genre.Romance,
                Year = 1997
            },

            new Movie()
            {
                Id = 2,
                Title = "Interstellar",
                Description = "A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival.",
                Genre = Genre.SciFi,
                Year = 2014
            },

            new Movie()
            {
                Id = 3,
                Title = "Avatar",
                Description = "A paraplegic Marine dispatched to the moon Pandora on a unique mission becomes torn between following his orders and protecting the world he feels is his home.",
                Genre = Genre.SciFi,
                Year = 2009
            },

            new Movie()
            {
                Id = 4,
                Title = "The Ring",
                Description = "A journalist must investigate a mysterious videotape which seems to cause the death of anyone one week to the day after they view it.",
                Genre = Genre.Horror,
                Year = 2002
            },

            new Movie()
            {
                Id = 5,
                Title = "The Shawshank Redemption",
                Description = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.",
                Genre = Genre.Drama,
                Year = 1994
            },

            new Movie()
            {
                Id = 6,
                Title = "Dune",
                Description = "Feature adaptation of Frank Herbert's science fiction novel, about the son of a noble family entrusted with the protection of the most valuable asset and most vital element in the galaxy.",
                Genre = Genre.Adventure,
                Year = 2021
            },

            new Movie()
            {
                Id = 7,
                Title = "The Matrix",
                Description = "When a beautiful stranger leads computer hacker Neo to a forbidding underworld, he discovers the shocking truth--the life he knows is the elaborate deception of an evil cyber-intelligence.",
                Genre = Genre.Action,
                Year = 1999
            },

            new Movie()
            {
                Id = 8,
                Title = "Free Guy",
                Description = "A bank teller discovers that he's actually an NPC inside a brutal, open world video game.",
                Genre = Genre.Comedy,
                Year = 2021
            },

            new Movie()
            {
                Id = 9,
                Title = "Tombstone",
                Description = "A successful lawman's plans to retire anonymously in Tombstone, Arizona are disrupted by the kind of outlaws he was famous for eliminating.",
                Genre = Genre.Western,
                Year = 1993
            },

            new Movie()
            {
                Id = 10,
                Title = "The Quick and the Dead",
                Description = "A female gunfighter returns to a frontier town where a dueling tournament is being held, which she enters in an effort to avenge her father's death.",
                Genre = Genre.Thriller,
                Year = 1995
            }
        };
    }
}
