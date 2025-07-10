using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.Extensions.Hosting;
using System;
using System.Drawing;
using System.Runtime.Intrinsics.X86;
using System.Threading.Tasks;

namespace Magic8Ball
{
	public  class Answer : IAnswer
	{
		private List<string> AnswerList { get; } = new List<string>()
		{
			"It is certain.",
			"It is decidedly so.",
			"Without a doubt.",
			"Yes, definitely.",
			"You may rely on it.",
			"As I see it, yes.",
			"Most likely.",
			"Outlook good.",
			"Yes.",
			"Signs point to yes.",
			"Don't count on it.",
			"My reply is no.",
			"My sources say no.",
			"Outlook not so good.",
			"Very doubtful.",
			"Reply hazy, try again.",
			"Ask again later.",
			"Cannot predict now.",
			"Concentrate and ask again.",
			"Better not tell you now."
		};
		
		public string GetRandomAnswer()
		{
			Random random = new();
			return(AnswerList[random.Next(AnswerList.Count)]);
		}
	}

}