using Proy1.Shared.Entity;
using System.Collections.Generic;
namespace Proy1.Client.Services
{
    public interface IActorService
    {
        List<Actor> GetActors();
    }
}