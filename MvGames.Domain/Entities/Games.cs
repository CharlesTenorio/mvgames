using System;
namespace MvGames.Domain.Entities
{
    public  sealed class Games : ClassBase
    {
        public DateTime DateGame {get; private set;}
        public string LocalGame{get; private set;}
        public  bool Accomplished {get; private set;}
        public string Result{get; private set;}
        public int ScoreboardTeamHome {get; private set;}
        public int ScoreboardTeamVisit {get; private set;}
        public DateTime StartGame {get; private set;}
        public DateTime EndGame {get; private set;}
    }
}