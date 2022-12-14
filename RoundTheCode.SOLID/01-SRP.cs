namespace RoundTheCode.SOLID.SRP
{
    // SINGLE RESPONSIBILITY PRINCIPAL
    public class Team
    {

    }

    public class TeamService
    {
        public void Create(Team team) { }
        public void Update(int id, Team team) { }
        public void Delete(int id) { }
        public void AddToCompetition(int teamId, int competitionId) { }
    }

    public class CompetitionService
    {
        public void AddToCompetition(int teamId, int competitionId) { }
    }
}