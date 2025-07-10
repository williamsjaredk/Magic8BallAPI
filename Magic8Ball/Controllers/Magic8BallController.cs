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
		public ActionResult<Wisdom> GetAnswer(string question)
		{
			IAnswer answer = new Answer();
			IWisdom response = new Wisdom(answer);

			response.Question = question;
			response.Id = Guid.NewGuid();
			
			if (response.GetAnswer() == null)
			{
				return BadRequest();
			}

			return Ok(response);
		}
	}
}
