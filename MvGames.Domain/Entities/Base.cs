using System.Dynamic;
namespace MvGames.Domain.Entities
{
    public abstract class Base
    {
        public int Id{get; private set;}
        public DateTime dateCreate{get; protected set;}
        
    }
}