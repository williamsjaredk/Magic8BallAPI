using Magic8Ball;
using Microsoft.AspNetCore.Authorization;
using Moq;

namespace UnitTests
{
	[TestClass]
	public sealed class WisdomTests
	{

		private readonly Wisdom wisdom;
		private readonly Mock<IAnswer> _answerMoq = new Mock<IAnswer>();

		public WisdomTests()
		{
			wisdom = new Wisdom(_answerMoq.Object);
		}

		[TestMethod]
		public void GetAnswer_ShouldReturnAnswer()
		{
			// Arrange
			string question = "Is this a question?";
			string expectedResult = "This is the random response.";
			wisdom.Question = question;
			_answerMoq.Setup(x => x.GetRandomAnswer()).Returns(expectedResult);

			// Act

			string answer = wisdom.GetAnswer();

			// Assert

			Assert.AreEqual(expectedResult, answer);
		}

		[TestMethod]
		public void GetAnswer_ShouldReturnEmptyString()
		{
			// Arrange
			string question = string.Empty;
			string expectedResult = string.Empty;
			wisdom.Question = question;
			_answerMoq.Setup(x => x.GetRandomAnswer()).Returns(expectedResult);

			// Act

			string answer = wisdom.GetAnswer();

			// Assert

			Assert.AreEqual(expectedResult, answer);
		}
	}
}
