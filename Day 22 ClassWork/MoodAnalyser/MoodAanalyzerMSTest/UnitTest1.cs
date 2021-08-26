using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MoodAnalyser;

namespace MoodAanalyzerMSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string expected = "HAPPY";
            string message = "I Am In A Happy Mood";

            MoodAnalyzer moodAnalyse = new MoodAnalyzer(message);

            string mood = moodAnalyse.AnalyseMethod();

            Assert.AreEqual(expected, mood);
        }

        [TestMethod]
        [DataRow("I Am in Happy Mood")]
        //[DataRow(null)]
        public void GivenHappyMoodShouldReturnHappy(string message)
        {
            string expected = "HAPPY";
            MoodAnalyzer moodAnalyse = new MoodAnalyzer(message);
            string mood = moodAnalyse.AnalyseMethod();
            Assert.AreEqual(expected, mood);
        }

        [TestMethod]
        public void Given_Empty_Mood_Should_Throw_MoodAnalysisException_Indicating_EmptyMethod()
        {
            try
            {
                string message = "";
                MoodAnalyzer moodAnalyse = new MoodAnalyzer(message);
                string mood = moodAnalyse.AnalyseMethod();
            }
            catch (MoodAnalyzerCustomException e)
            {
                Assert.AreEqual("Mood Should Not Be Empty", e.Message);
            }
        }

        [TestMethod]
        public void Given_Null_Mood_Should_Throw_MoodAnalysisException()
        {
            try
            {
                string message = null;
                MoodAnalyzer moodAnalyse = new MoodAnalyzer(message);
                string mood = moodAnalyse.AnalyseMethod();
            }
            catch (MoodAnalyzerCustomException e)
            {
                Assert.AreEqual("Mood Should Not Be Null", e.Message);
            }

        }

        [TestMethod]
        public void GivenMoodAnalyzerClassName_ShouldReturnMoodAnalyzerObject()
        {
            string message = null;
            object expected = new MoodAnalyzer(message);
            object obj = MoodAnalyzerFactory.CreateMoodAnalysis("MoodAnalyser.MoodAnalyzer", "MoodAnalyzer");
            expected.Equals(obj);
            //Assert.AreEqual(expected, obj);
        }

        [TestMethod]
        public void GivenClassName_ShouldReturnMoodAnalysisObject_UsingParameterizedConstructor()
        {
            object expected = new MoodAnalyzer("HAPPY");
            object obj = MoodAnalyzerFactoryUC5.CreateMoodAnalysisUsingParameterizedConstructor("MoodAnalyser.MoodAnalyzer", "MoodAnalyzer", "HAPPY");
            expected.Equals(obj);
        }
    }
}
