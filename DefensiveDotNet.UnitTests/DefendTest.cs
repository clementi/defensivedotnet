namespace DefensiveDotNet.UnitTests
{
    using System;
    using DefensiveDotNet;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class DefendTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void When_defending_against_a_null_parameter_and_it_gets_a_null_parameter_it_should_throw_an_ArgumentNullException()
        {
            string nullParameter = null;

            Defend.AgainstNullParameter(nullParameter, "parameterName");
        }

        [TestMethod]
        public void When_defending_against_a_null_parameter_and_it_does_not_get_a_null_parameter_it_should_not_throw_any_exception()
        {
            const string NotNull = "not null";

            Defend.AgainstNullParameter(NotNull, "parameterName");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void When_defending_against_a_null_or_empty_string_parameter_and_it_gets_a_null_or_empty_parameter_it_should_throw_an_ArgumentException()
        {
            Defend.AgainstNullOrEmptyParameter(string.Empty, "parameterName");
        }

        [TestMethod]
        public void When_defending_against_a_null_or_empty_string_parameter_and_it_does_not_get_a_null_or_empty_parameter_it_should_not_throw_any_exception()
        {
            const string NotNullOrEmpty = "not null or empty";

            Defend.AgainstNullOrEmptyParameter(NotNullOrEmpty, "parameterName");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void When_defending_against_a_null_or_whitespace_string_parameter_and_it_gets_a_null_or_whitespace_parameter_it_should_throw_an_ArgumentException()
        {
            const string Whitespace = " ";

            Defend.AgainstNullOrWhitespaceParameter(Whitespace, "parameterName");
        }

        [TestMethod]
        public void When_defending_against_a_null_or_whitespace_string_parameter_and_it_does_not_get_a_null_or_empty_parameter_it_should_not_throw_any_exception()
        {
            const string NotNullOrWhitespace = "not null or whitespace";

            Defend.AgainstNullOrWhitespaceParameter(NotNullOrWhitespace, "parameterName");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void When_defending_against_an_arbitrary_condition_and_the_condition_is_met_it_should_throw_an_ArgumentException()
        {
            int x = 3;

            Defend.Against(x == 3, "parameterName");
        }

        [TestMethod]
        public void When_defending_against_an_arbitrary_condition_and_the_condition_is_not_met_it_should_not_throw_any_exception()
        {
            int x = 3;

            Defend.Against(x < 3, "parameterName");
        }
    }
}
