using NUnit.Framework;

namespace CodeWarsTests._7kyu
{
    [TestFixture]
    public class BandNameGeneratorTest
    {
        [Test]
        public void BandName_dolphin_ShouldBe_The_Dolphin()
        {
            var target = new BandNameGenerator();
            var actual = target.GetBandName("dolphin");
            Assert.AreEqual("The Dolphin", actual);
        }
    }

    public class BandNameGenerator
    {
        public string GetBandName(string originalName)
        {
            var firstLetter = originalName[0].ToString().ToUpper();
            var formattedName = "The " + firstLetter + originalName.Substring(1);
            return formattedName;
        }
    }
}
