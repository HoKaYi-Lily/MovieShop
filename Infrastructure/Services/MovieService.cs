using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Models;
using ApplicationCore.ServiceInterface;

namespace Infrastructure.Services
{
    public class MovieService : IMovieService
    {
        public List<MovieCardResponseModel> GetTopRevenueMovies()
        {
            // 3 ways to pass data from controller to view
            // 1 Strongly Typed Models ******
            // 2 ViewBag
            // 3 ViewData
            // get top revenue movie and display on the view
            // localhost:5001/movies/details/2
            // call repositories and get the real data from database
            var movies = new List<MovieCardResponseModel>()
            {
                          new MovieCardResponseModel {Id = 1, Title = "Avengers: Infinity War"},
                          new MovieCardResponseModel {Id = 2, Title = "Avatar"},
                          new MovieCardResponseModel {Id = 3, Title = "Star Wars: The Force Awakens"},
                          new MovieCardResponseModel {Id = 4, Title = "Titanic"},
                          new MovieCardResponseModel {Id = 5, Title = "Inception"},
                          new MovieCardResponseModel {Id = 6, Title = "Avengers: Age of Ultron"},
                          new MovieCardResponseModel {Id = 7, Title = "Interstellar"},
                          new MovieCardResponseModel {Id = 8, Title = "Fight Club"},
                          new MovieCardResponseModel {Id = 9, Title = "The Lord of the Rings: The Fellowship of the Ring" }


            };

            return movies;

        }


    }
}
