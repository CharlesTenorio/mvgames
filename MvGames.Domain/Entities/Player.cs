using System.Runtime.Intrinsics.Arm.Arm64;
namespace MvGames.Domain.Entities
{
    public class Player : Base
    { 
      public String Name{get; private set;}
      public String Position{get; private set;}
      public int SocceId { get; set; }
      public SoccerTeam SoccerTeam { get; set; }

      public Player(int id, String name, String position)
      {
        DomainExceptionValidation.When(id < 0, "Invalid Id value");
            Id=id;
            ValidateDomain(name, position);
          
      }
        

        private void ValidateDomain(string name,  String position)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name),
                "Invalid name.Name is required");

            DomainExceptionValidation.When(string.IsNullOrEmpty(position),
                "Invalid name.Name is required");
    
            Name=name;
            Position= position;
           

        }
    }
}