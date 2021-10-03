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
        //tc 2.1
        [TestMethod]
        public void GiveNullMoodShouldReturnHappy()
        {
            string message = "";
            string Expected = "HAPPY";
            MoodAnalyser MoodAnalyse = new MoodAnalyser(message);
            string Mood = MoodAnalyse.AnalyseMood();

            Assert.AreEqual(Expected, Mood);

        }
    }
}
