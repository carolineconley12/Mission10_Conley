using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplicationAPI.Models;


namespace WebApplicationAPI.Controllers
{
	[Route("[controller]")]
	[ApiController]
	public class BowlerController : ControllerBase
	{
		private IBowlerRepository _bowlerRepository;
		public BowlerController(IBowlerRepository temp)
		{
			_bowlerRepository = temp;
		}

		public IEnumerable<BowlerTeamInfo> Get()
		{
			var bowlerData = _bowlerRepository.GetBowlerTeamInfo();

			return bowlerData;
		}
	}
}
