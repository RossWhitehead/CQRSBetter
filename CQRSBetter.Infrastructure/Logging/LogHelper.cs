using CQRSBetter.Infrastructure.Logging;
using System;
using System.Diagnostics;
using System.Diagnostics.Tracing;

namespace CQRSBetter.Infrastructure.Logging
{
    public class LogHelper
    {
        public static readonly LogHelper Log = new LogHelper();
        public void Error(Exception ex)
        {
            string message = ex.Message;
            string innerMessage = "";
            if (ex.InnerException != null)
                innerMessage = ex.InnerException.Message;

            StackTrace st = new StackTrace();
            string methName = st.GetFrame(1).GetMethod().Name;
            string stack = st.ToString();
            BasicLogger.Log.Error(message, innerMessage, methName, stack);

        }
        public void Error(string message)
        {
            StackTrace st = new StackTrace();
            string methName = st.GetFrame(1).GetMethod().Name;
            string stack = st.ToString();
            BasicLogger.Log.Error(message, "", methName, stack);
        }

        public void Critical(string message)
        {
            StackTrace st = new StackTrace();
            string methName = st.GetFrame(1).GetMethod().Name;
            string stack = st.ToString();
            BasicLogger.Log.Critical(message, methName, stack);
        }

        public void Warning(string message)
        {
            StackTrace st = new StackTrace();
            string methName = st.GetFrame(1).GetMethod().Name;
            string stack = st.ToString();
            BasicLogger.Log.Warning(message, methName, stack);
        }
        public void Information(string message)
        {
            StackTrace st = new StackTrace();
            string methName = st.GetFrame(1).GetMethod().Name;
            string stack = st.ToString();
            BasicLogger.Log.Information(message, methName, stack);
        }
    }
}