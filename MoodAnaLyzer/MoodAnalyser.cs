using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnaLyzer
{
    public class MoodAnalyser
    {
        string message;
        //parametrised constructor
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        //method to Analyse Mood
        public string AnalyseMood()
        {
            try
            {
                if (this.message.Equals(string.Empty))
                {
                    throw new CustomMoodAnalyserException(CustomMoodAnalyserException.ExceptionType.EMPTY_TYPE_EXCEPTION, "Mood should not be empty");
                }
                if (this.message.ToUpper().Contains("SAD"))
                {
                    return "SAD";
                }
                else
                    return "HAPPY";

            }
            catch(CustomMoodAnalyserException)
            {
                throw new CustomMoodAnalyserException(CustomMoodAnalyserException.ExceptionType.EMPTY_TYPE_EXCEPTION, "Mood should not be empty");
            }
        }
    }
}
