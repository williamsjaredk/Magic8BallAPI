namespace Magic8Ball.Models
{
	public class Wisdom
	{
		public Guid Id { get; set; }
		public required string Question { get; set; }
		public string Answer { get; set; } = string.Empty;

		public static string GetAnswer()
		{
			return Answers.GetRandomAnswer();
		}
	}
}