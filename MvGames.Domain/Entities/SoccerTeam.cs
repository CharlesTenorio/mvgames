using System;
using System.Collections.Generic;
using MvGames.Domain.Validation;

namespace MvGames.Domain.Entities
{
    public sealad class SoccerTeam : Base
    {
        public String NameTeam{get; private set;}
        public String? Img{get; set}
        public int NumberPlayers{get; private set;}
        public ICollection<Player> Playes { get; set; }
        
        public SoccerTeam(int id, String nameTeam, String img, int numberPlayers)
        {
            DomainExceptionValidation.When(id < 0, "Invalid Id value");
            Id=id;
            ValidateDomain(nameTeam, img, numberPlayers);
            
        }



         public void Update(String nameTeam, String img, int numberPlayers)
        {
           
            ValidateDomain(nameTeam, img, numberPlayers);
            
        }


         private void ValidateDomain(string nameTeam,  String img, int numberPlayers)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(nameTeam),
                "Invalid name.Name is required");

            DomainExceptionValidation.When(numberPlayers < 5, "number of players must be five ");
            
            DomainExceptionValidation.When(img.Length > 250,
                "Invalid image name, too long, maximum 250 characters");
            
            NameTeam=nameTeam;
            NumberPlayers= numberPlayers;
            Img=img;

        }
    }
}