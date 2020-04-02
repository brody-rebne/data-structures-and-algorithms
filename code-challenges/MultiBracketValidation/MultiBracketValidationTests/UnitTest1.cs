using System;
using Xunit;
using BracketValidation;

namespace MultiBracketValidationTests
{
    public class UnitTest1
    {
        //can parse simple parens
        [Fact]
        public void CanParseParens()
        {
            Assert.True(Program.MultiBracketValidation("()"));
        }

        //can parse simple brackets
        [Fact]
        public void CanParseBrackets()
        {
            Assert.True(Program.MultiBracketValidation("[]"));
        }

        //can parse simple curlies
        [Fact]
        public void CanParseCurlies()
        {
            Assert.True(Program.MultiBracketValidation("{}"));
        }

        //can parse empty string
        [Fact]
        public void CanParseEmpty()
        {
            Assert.True(Program.MultiBracketValidation(""));
        }

        //can parse parens with text
        [Fact]
        public void CanParseParensWithText()
        {
            Assert.True(Program.MultiBracketValidation("text(test)lol"));
        }

        //can parse complex syntax
        [Fact]
        public void CanParseComplex()
        {
            Assert.True(Program.MultiBracketValidation("(a[b{c}d]e)d"));
        }

        //can parse extra close brackets
        [Fact]
        public void CanParseExtraClose()
        {
            Assert.False(Program.MultiBracketValidation("())"));
        }

        //can parse extra close brackets
        [Fact]
        public void CanParseExtraOpen()
        {
            Assert.False(Program.MultiBracketValidation("())"));
        }
    }
}
