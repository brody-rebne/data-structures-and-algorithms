using System;
using System.Diagnostics.CodeAnalysis;
using Xunit;
using RepeatedWord;

namespace RepeatedWordTests
{
    public class UnitTest1
    {
        Program testMe = new Program();
        //repeated word is found
        [Fact]
        public void CanGetRepeatedWord()
        {
            string testString = "boats eat boats";
            string result = testMe.RepeatedWordChecker(testString);

            Assert.Equal("boats", result);
        }

        //repeated word is found WITH CAPS!!!!
        [Fact]
        public void CanGetRepeatedWordCaps()
        {
            string testString = "boats eat Boats";
            string result = testMe.RepeatedWordChecker(testString);

            Assert.Equal("boats", result);
        }

        //no repeating words returns null
        [Fact]
        public void NoRepeatReturnsNull()
        {
            string testString = "boats eat sleeves";
            string result = testMe.RepeatedWordChecker(testString);

            Assert.Null(result);
        }

        //only finds first repeat
        [Fact]
        public void OnlyFindsFirstRepeat()
        {
            string testString = "boats eat boats eat";
            string result = testMe.RepeatedWordChecker(testString);

            Assert.Equal("boats", result);
        }
    }
}
