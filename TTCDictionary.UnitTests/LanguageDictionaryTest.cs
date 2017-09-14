using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace TTCDictionary.UnitTests
{
    [TestFixture]
    public class LanguageDictionaryTest
    {
        private LanguageDictionary SUT;

        private Dictionary<string, List<string>> list;

        [SetUp]
        public void Setup()
        {
            list = new Dictionary<string, List<string>>();

            SUT = new LanguageDictionary(list);
        }

        ////[Test]
        ////public void When_adding_a_word_which_does_not_exist_should_return_true()
        ////{
        ////    // Arrange.
        ////    var word = "test";
        ////    var lang = "English";

        ////    // Act.
        ////    var result = this.SUT.Add(lang, word);

        ////    // Assert.
        ////    Assert.IsTrue(result);

        ////    ////var listCheck = this.list.FirstOrDefault(i => i.Key == lang && i.Value == word);

        ////    ////Assert.IsTrue(listCheck.Key == lang);
        ////    ////Assert.IsTrue(listCheck.Value == word);
        ////}

        ////[Test]
        ////public void When_adding_a_word_which_does_exist_should_return_false()
        ////{
        ////    // Arrange.
        ////    var word = "test";
        ////    this.SUT.Add("English", word);

        ////    // Act.
        ////    var result = this.SUT.Add("English", word);

        ////    // Assert.
        ////    Assert.IsFalse(result);
        ////}

        ////[Test]
        ////public void When_adding_a_word_which_does_exist_but_in_a_different_language_should_return_true()
        ////{
        ////    // Arrange.
        ////    var word = "test";
        ////    this.SUT.Add("English", word);

        ////    // Act.
        ////    var result = this.SUT.Add("German", word);

        ////    // Assert.
        ////    Assert.IsTrue(result);
        ////}

        ////[Test]
        ////public void When_checking_a_word_which_does_not_exist_should_return_false()
        ////{
        ////    // Arrange.
        ////    var word = "test";

        ////    // Act.
        ////    var result = this.SUT.Check("English", word);

        ////    // Assert.
        ////    Assert.IsFalse(result);
        ////}

        ////[Test]
        ////public void When_checking_a_word_which_does_exist_should_return_true()
        ////{
        ////    // Arrange.
        ////    var word = "test";
        ////    this.SUT.Add("English", word);

        ////    // Act.
        ////    var result = this.SUT.Check("English", word);

        ////    // Assert.
        ////    Assert.IsTrue(result);
        ////}

        #region MyTest Cases

        [Test]
        public void Should_return_true_When_Add_Success()
        {
            var word = "Hello";
            // Act.
            var result = this.SUT.Add("English", word);

            // Assert.
            Assert.IsTrue(result);
        }

        [Test]
        public void Should_return_False_When_Add_IsNotSuccess()
        {
            var word = "Hello";

            // Act.
            var result = this.SUT.Add("English", word);

            // Assert.
            Assert.IsTrue(result);
        }

        [Test]
        public void Should_return_true_When_Add_Success_OtherValue()
        {
            var word = "First";

            // Act.
            var result = this.SUT.Add("English", word);

            // Assert.
            Assert.IsTrue(result);
        }

        [Test]
        public void Should_return_true_When_Add_Success_OtherLanguage()
        {
            var word = "Hola";

            // Act.
            var result = this.SUT.Add("Spanish", word);

            // Assert.
            Assert.IsTrue(result);
        }

        //// check

        [Test]
        public void Should_return_true_When_Check_Success()
        {
            var word = "Hello";
            list.Add("English", new List<string> { "Hello" });

            // Act.
            var result = this.SUT.Check("English", word);

            // Assert.
            Assert.IsTrue(result);
        }


        [Test]
        public void Should_return_False_When_Check_IsNotSuccess()
        {
            var word = "Hello2";
            // Act.
            var result = this.SUT.Check("English", word);

            // Assert.
            Assert.IsFalse(result);
        }


        [Test]
        public void Should_return_true_When_Check_OtherValueSuccess()
        {
            var word = "Hola";

            list.Add("Spanish", new List<string> { "Hola" });
            // Act.
            var result = this.SUT.Check("Spanish", word);

            // Assert.
            Assert.IsTrue(result);
        }

        [Test]
        public void Should_return_False_When_Check_IsNotSuccess_With_SameValue()
        {
            var word = "Amigo";
            // Act.
            var result = this.SUT.Check("Spanish", word);

            // Assert.
            Assert.IsFalse(result);
        }


        [Test]
        public void Should_return_True_When_Search_ReturnsData()
        {
            var word = "Word";

            list.Add("English", new List<string> { "Word" });
            // Act.
            var result = this.SUT.Search("Wor");

            // Assert.
            Assert.IsTrue(result.ToList().Count > 0);
        }

        [Test]
        public void Should_return_False_When_Search_ReturnsData_DoesNot_Exists()
        {
            var word = "Word";

            list.Add("English", new List<string> { "Word" });
            // Act.
            var result = this.SUT.Search("Hello");

            // Assert.
            Assert.IsTrue(result.ToList().Count == 0);
        }
        #endregion

    }
}
