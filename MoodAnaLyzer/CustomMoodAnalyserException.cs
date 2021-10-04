using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnaLyzer
{
    public class CustomMoodAnalyserException : Exception
    {
        public ExceptionType type;
        public enum ExceptionType
        {
            NULL_TYPE_EXCEPTION,
            EMPTY_TYPE_EXCEPTION
        }
        public CustomMoodAnalyserException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
