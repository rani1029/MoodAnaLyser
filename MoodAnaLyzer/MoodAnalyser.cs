using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnaLyzer
{
    public class MoodAnalyser
    {
        string message;
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        public string AnalyseMood()
        {
            if (message.Contains("SAD"))
            {
                return "SAD";
            }
            else
                return "HAPPY";
        }
    }
}
