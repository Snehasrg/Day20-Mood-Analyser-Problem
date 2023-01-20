namespace MoodAnalyserProject
{
    public class MoodAnalyser
    {
        string message;
        public MoodAnalyser(string Message)
        {
            this.message = Message;
        }
        public string AnalyzeMood()
        {
            if (message.ToLower().Contains("happy"))
            {
                return "happy";
            }
            else
            {
                return "sad";
            }
        }

    }
}