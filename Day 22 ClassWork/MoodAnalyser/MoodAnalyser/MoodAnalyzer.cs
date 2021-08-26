using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyser
{
    public class MoodAnalyzer
    {
        public MoodAnalyzer()
        { }
        private string message;
        public MoodAnalyzer(string message)
        {
            this.message = message;
        }
        public string AnalyseMethod()
        {
            try
            {
                if (this.message.Equals(string.Empty))
                {
                    throw new MoodAnalyzerCustomException(MoodAnalyzerCustomException.ExceptionType.EMPTY_MESSAGE, "Mood Should Not Be Empty");
                }

                if (this.message.Contains("sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyzerCustomException(MoodAnalyzerCustomException.ExceptionType.NULL_MESSAGE, "Mood Should Not Be Null");
            }
        }
    }
}
