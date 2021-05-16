using System;

namespace RealtyModel.Model
{
    [Serializable]
    public class LogMessage
    {
        public string DateTime { get; private set; }
        public string Text { get; private set; }

        public LogMessage(string dateTime, string text)
        {
            DateTime = dateTime;
            Text = text;
        }
    }
}
