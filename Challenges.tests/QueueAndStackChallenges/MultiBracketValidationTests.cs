using Challenges.StackAndQueueChallenges;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Challenges.tests.QueueAndStackChallenges
{
    public class MultiBracketValidationTests
    {
        [Fact]
        public void CheckBracketBalance_returns_false_for_an_empty_string()
        {
            // arrange
            string input = "";
            // act
            bool result = MultiBracketValidation.CheckBracketBalance(input);
            // assert
            Assert.False(result);
        }
        [Fact]
        public void CheckBracketBalance_returns_false_for_a_single_character_string()
        {
            // arrange
            string input = "{";
            // act
            bool result = MultiBracketValidation.CheckBracketBalance(input);
            // assert
            Assert.False(result);
        }
        [Fact]
        public void CheckBracketBalance_returns_false_for_a_string_with_no_brackets()
        {
            // arrange
            string input = "tests";
            // act
            bool result = MultiBracketValidation.CheckBracketBalance(input);
            // assert
            Assert.False(result);
        }
        [Fact]
        public void CheckBracketBalance_returns_false_for_a_string_with_unbalanced_brackets()
        {
            // arrange
            string input = "{[}]";
            // act
            bool result = MultiBracketValidation.CheckBracketBalance(input);
            // assert
            Assert.False(result);
        }
        [Fact]
        public void CheckBracketBalance_returns_false_for_an_uneven_number_of_brackets()
        {
            // arrange
            string input = "{{}";
            // act
            bool result = MultiBracketValidation.CheckBracketBalance(input);
            // assert
            Assert.False(result);
        }
        [Fact]
        public void CheckBracketBalance_returns_false_for_a_string_of_only_opening_brackets()
        {
            // arrange
            string input = "{[(";
            // act
            bool result = MultiBracketValidation.CheckBracketBalance(input);
            // assert
            Assert.False(result);
        }
        [Fact]
        public void CheckBracketBalance_returns_false_for_a_string_of_only_closing_brackets()
        {
            // arrange
            // act
            // assert
        }
        [Fact]
        public void CheckBracketBalance_returns_true_for_balanced_brackets()
        {
            // arrange
            // act
            // assert
        }
        [Fact]
        public void CheckBracketBalance_returns_true_for_balanced_brackets_with_words()
        {
            // arrange
            // act
            // assert
        }

    }
}
