using Magic8Ball.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Magic8Ball.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class Magic8BallController : ControllerBase
	{
		[Route("v1/ask")]
		[HttpGet]
		public ActionResult<Wisdom> Get(string question)
		{
			if(question == null)
			{
				return NotFound();
			}

			if(question == string.Empty) 
			{ 
				return BadRequest(); 
			}

			Wisdom response = new Wisdom
			{
				Question = question,
				Id = Guid.NewGuid(),
				Answer = Wisdom.GetAnswer()
			};
			return Ok(response);
		}
	}
}
