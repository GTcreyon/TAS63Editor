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
			var data = DataManager.LoadFile(@"C:\Users\Tricia\source\repos\TAS63Editor\DataManager.Tests\TestFiles\test.txt", false);

			// Act
			DataManager.SaveTxt(@"C:\Users\Tricia\source\repos\TAS63Editor\DataManager.Tests\TestFiles\test2.txt", data[0].ToList(), data[1].ToList(), data[2].ToList());

			// Assert
			FileAssert.AreEqual(@"C:\Users\Tricia\source\repos\TAS63Editor\DataManager.Tests\TestFiles\test.txt", @"C:\Users\Tricia\source\repos\TAS63Editor\DataManager.Tests\TestFiles\test2.txt");
		}

		[Test]
		public void extracts_sol_properly()
		{
			// Arrange
			var data = DataManager.LoadFile(@"C:\Users\Tricia\source\repos\TAS63Editor\DataManager.Tests\TestFiles\testSol.sol", true);

			// Act
			DataManager.SaveTxt(@"C:\Users\Tricia\source\repos\TAS63Editor\DataManager.Tests\TestFiles\testSol.txt", data[0].ToList(), data[1].ToList(), data[2].ToList());

			// Assert
			FileAssert.AreEqual(@"C:\Users\Tricia\source\repos\TAS63Editor\DataManager.Tests\TestFiles\test.txt", @"C:\Users\Tricia\source\repos\TAS63Editor\DataManager.Tests\TestFiles\testSol.txt");
		}
	}
}