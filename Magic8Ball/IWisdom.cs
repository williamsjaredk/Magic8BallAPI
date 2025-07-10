namespace Magic8Ball
{
	public interface IWisdom
	{
		Guid Id { get; set; }
		string Question { get; set; }
		string Answer { get; set; }
		string GetAnswer();
	}
}
