namespace DefensiveDotNet
{
    using System;

    public static class Defend
    {
        private const string NullOrEmptyParameterExceptionMessage = "Parameter cannot be null or empty.";
        private const string NullOrWhitespaceParameterExceptionMessage = "Parameter cannot be null or whitespace.";
        private const string UnacceptableParameterExceptionMessage = "Parameter met unacceptable condition.";

        public static void AgainstNullParameter<T>(T parameter, string parameterName)
        {
            if (parameter == null)
                throw new ArgumentNullException(parameterName);
        }

        public static void AgainstNullOrEmptyParameter(string parameter, string parameterName)
        {
            if (string.IsNullOrEmpty(parameter))
                throw new ArgumentException(NullOrEmptyParameterExceptionMessage, parameterName);
        }

        public static void AgainstNullOrWhitespaceParameter(string parameter, string parameterName)
        {
            if (string.IsNullOrWhiteSpace(parameter))
                throw new ArgumentException(NullOrWhitespaceParameterExceptionMessage, parameterName);
        }

        public static void Against(bool condition, string parameterName)
        {
            if (condition)
                throw new ArgumentException(UnacceptableParameterExceptionMessage, parameterName);
        }
    }
}
