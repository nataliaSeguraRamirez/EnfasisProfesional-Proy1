using Proy1.Shared.Entity;
using System.Collections.Generic;
using System;
namespace Proy1.Client.Services
{
    public class ActorService:IActorService
    {
         public List<Actor> GetActors()
        {
            return new List<Actor>()
            {
                new Actor(){Name="Actor1",BirthDate= new DateTime(2021,09,24), Photo = "/Images/Actors/actor1.jpg", Biography="Biografía"},
                new Actor(){Name="Actor2",BirthDate= new DateTime(2021,09,24), Photo = "/Images/Actors/actor2.jpg", Biography="Biografía"},
                new Actor(){Name="Actor3",BirthDate= new DateTime(2021,09,24), Photo = "/Images/Actors/actor3.jpg", Biography="Biografía"},
                new Actor(){Name="Actor4",BirthDate= new DateTime(2021,09,24), Photo = "/Images/Actors/actor4.jpg", Biography="Biografía"},
                new Actor(){Name="Actor5",BirthDate= new DateTime(2021,09,24), Photo = "/Images/Actors/actor5.jpg", Biography="Biografía"}
            };
        }        
    }
}