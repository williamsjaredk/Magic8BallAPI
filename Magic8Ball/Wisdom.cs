namespace Magic8Ball
{
	public class Wisdom : IWisdom
	{
		public Guid Id { get; set; }
		public string Question { get; set; }
		public string Answer { get; set; } = string.Empty;

		private readonly IAnswer _answer;

		public Wisdom()
		{
			_answer = new Answer();
		}

		public Wisdom(IAnswer answer)
		{
			_answer = answer;
			Answer = _answer.GetRandomAnswer();
		}

		public string GetAnswer()
		{
			if (Question == string.Empty)
			{
				return Question;
			}
			return _answer.GetRandomAnswer();
		}
	}
}