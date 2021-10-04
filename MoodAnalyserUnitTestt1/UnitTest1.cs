using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnaLyzer;

namespace MoodAnalyserUnitTestt1
{
    [TestClass]
    public class UnitTest1
    {
        //tc 1.1
        [TestMethod]
        public void GivenSadMoodShouldReturnSad()
        {
            string message = " i m in a SAD mood";
            string Expected = "SAD";
            MoodAnalyser MoodAnalyse = new MoodAnalyser(message);
            string Mood = MoodAnalyse.AnalyseMood();

            Assert.AreEqual(Expected, Mood);

        }
        //tc 1.2
        [TestMethod]
        public void GivenAnyMoodShouldReturnHappy()
        {
            string message = " i m in ANY mood";
            string Expected = "HAPPY";
            MoodAnalyser MoodAnalyse = new MoodAnalyser(message);
            string Mood = MoodAnalyse.AnalyseMood();

            Assert.AreEqual(Expected, Mood);

        }
        //tc 3.1
        //test for custom handling
        [TestMethod]
        public void GiveNullMoodShouldReturnHappy()
        {
            string message = "";
            string Expected = "Mood should not be empty";
            MoodAnalyser MoodAnalyse = new MoodAnalyser(message);
            try
            {
                string ActualMood = MoodAnalyse.AnalyseMood();
            }
            catch (CustomMoodAnalyserException ex)
            {
                Assert.AreEqual(Expected, ex.Message);
            }

        }
    }
}
