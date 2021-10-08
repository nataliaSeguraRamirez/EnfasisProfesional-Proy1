using Proy1.Shared.Entity;
using System.Collections.Generic;
using System;

namespace Proy1.Client.Services
{
    public class ServiceMovie:IServiceMovie
    {
        public List<Movie> GetMovies()
        {
            return new List<Movie>(){
                new Movie(){ Name="Movie1",Sinopsis="Descripcion Movie1", Image="/Images/movies/movie1.jpg", Category="Action", Score=100,    Premier= new DateTime(2021,09,24)},
                new Movie(){Name="Movie2", Sinopsis="Descripcion Movie2", Image="/Images/movies/movie2.jpg", Category="Action", Score=100, Premier= new DateTime(2021,09,24)},
                new Movie(){Name="Movie3", Sinopsis="Descripcion Movie3", Image="/Images/movies/movie3.jpg", Category="Action", Score=100, Premier= new DateTime(2021,09,24)},
                new Movie(){Name="Movie4", Sinopsis="Descripcion Movie4", Image="/Images/movies/movie4.jpg", Category="Action", Score=100, Premier= new DateTime(2021,09,24)},
                new Movie(){Name="Movie5", Sinopsis="Descripcion Movie5", Image="/Images/movies/movie5.jpg", Category="Action", Score=100, Premier= new DateTime(2021,09,24)}
            };
        }
    }
}