﻿using CodeWars._7kyu;
using NUnit.Framework;

namespace CodeWarsTests._7kyu
{
    [TestFixture]
    public class BandNameGeneratorTest
    {
        [Test]
        public void BandName_dolphin_ShouldBe_The_Dolphin()
        {
            AssertBankName("dolphin","The Dolphin");
        }

        [TestCase("europe", "The Europeurope",TestName = "europe_ShouldBe_The_Europeurope")]
        [TestCase("alaska", "The Alaskalaska", TestName = "alaska_ShouldBe_The_Alaskalaska")]
        public void BandName_With_StartAndEnd_InSameLetter(string orginialName,string expected)
        {
            AssertBankName(orginialName, expected);
        }

        private static void AssertBankName(string orginialName, string expected)
        {
            var target = new BandNameGenerator();
            var actual = target.GetBandName(orginialName);
            Assert.AreEqual(expected, actual);
        }
    }
}
