namespace WebApplicationAPI.Models
{
    public interface IBowlerRepository
    {
        IEnumerable<BowlerTeamInfo> GetBowlerTeamInfo(); 
    }
}
