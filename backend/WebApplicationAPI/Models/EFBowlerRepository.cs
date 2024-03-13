namespace WebApplicationAPI.Models
{
	public class EFBowlerRepository : IBowlerRepository
	{
		private BowlingLeagueContext _context;
		public EFBowlerRepository(BowlingLeagueContext temp)
		{
			_context = temp;
		}

		public IEnumerable<BowlerTeamInfo> GetBowlerTeamInfo()
		{
			var query = from bowler in _context.Bowlers
						join team in _context.Teams on bowler.TeamId equals team.TeamId
						where team.TeamName == "Marlins" || team.TeamName == "Sharks"
						select new BowlerTeamInfo
						{
							BowlerFullName = bowler.BowlerFirstName + " " +
											 (string.IsNullOrEmpty(bowler.BowlerMiddleInit) ? "" : bowler.BowlerMiddleInit + " ") +
											 bowler.BowlerLastName,
							TeamName = team.TeamName,
							Address = bowler.BowlerAddress,
							City = bowler.BowlerCity,
							State = bowler.BowlerState,
							Zip = bowler.BowlerZip,
							PhoneNumber = bowler.BowlerPhoneNumber
						};

			return query.ToList();
		}
	}
}

