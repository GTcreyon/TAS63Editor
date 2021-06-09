using NUnit.Framework;
using DataManagerCore;
using System.Linq;

namespace DataManagerTests
{
	public class DataManagerFixture
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void saves_properly()
		{
			// Arrange
			//TODO: Figure out using mappath
			DataManager dataManager = new DataManager(@"C:\Users\Tricia\source\repos\TAS63Editor\DataManager.Tests\TestFiles\test.txt", false);

			// Act
			var data = dataManager.ReadKeys();
			dataManager.SaveTxt(@"C:\Users\Tricia\source\repos\TAS63Editor\DataManager.Tests\TestFiles\test2.txt", data.ToList<string>());

			// Assert
			Assert.That(data, Is.Not.Null);
			FileAssert.AreEqual(@"C:\Users\Tricia\source\repos\TAS63Editor\DataManager.Tests\TestFiles\test.txt", @"C:\Users\Tricia\source\repos\TAS63Editor\DataManager.Tests\TestFiles\test2.txt");
		}

		[Test]
		public void extracts_sol_properly()
		{
			// Arrange
			DataManager dataManager = new DataManager(@"C:\Users\Tricia\source\repos\TAS63Editor\DataManager.Tests\TestFiles\testSol.sol", true);

			// Act
			var data = dataManager.ReadKeys();
			dataManager.SaveTxt(@"C:\Users\Tricia\source\repos\TAS63Editor\DataManager.Tests\TestFiles\testSol.txt", data.ToList<string>());

			// Assert
			FileAssert.AreEqual(@"C:\Users\Tricia\source\repos\TAS63Editor\DataManager.Tests\TestFiles\test.txt", @"C:\Users\Tricia\source\repos\TAS63Editor\DataManager.Tests\TestFiles\testSol.txt");
		}
	}
}