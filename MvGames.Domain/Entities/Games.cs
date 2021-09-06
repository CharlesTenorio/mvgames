using System;
namespace MvGames.Domain.Entities
{
    public  sealad class Games :Base
    {
        public DateTime DateGame{get; private set};
        public String LocalGame{get; private set};
        public  bool Accomplished {get; private set};
        public String Result{get; private set};
        public int ScoreboardTeamHome {get; private set};
        public int ScoreboardTeamVisit {get; private set};
        public DateTime StartGame {get; private set};
        public DateTime EndGame {get; private set};
    }
}