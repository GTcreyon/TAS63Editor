using NUnit.Framework;
using DataManagerCore;

namespace DataManagerTests
{
	public class DataManagerFixture
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void can_get_correct_number_of_rows()
		{
			// Arrange
			//TODO: Figure out using mappath
			var dataManager = new DataManager(@"C:\Users\Tricia\source\repos\TAS63Editor\DataManager.Tests\TestFiles\test.txt");

			// Act
			var data = dataManager.ReadKeys();

			// Assert
			Assert.That(data, Is.Not.Null);
			Assert.That(data.Count, Is.EqualTo(1404));
		}
	}
}