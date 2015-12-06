using CQRSBetter.Infrastructure.Logging;
using Microsoft.Practices.EnterpriseLibrary.SemanticLogging;
using System.Configuration;
using System.Diagnostics.Tracing;

namespace CQRSBetter.Website
{
    public class LoggingConfig
    {
        public static void InitializeLogging()
        {
            var sqlListener = SqlDatabaseLog.CreateListener("Website", ConfigurationManager.ConnectionStrings["LoggingDb"].ConnectionString);

            bool critical = ConfigurationManager.AppSettings["Logging_LogCritical"].ToLower() == "true";
            bool error = ConfigurationManager.AppSettings["Logging_LogError"].ToLower() == "true";
            bool warning = ConfigurationManager.AppSettings["Logging_LogWarning"].ToLower() == "true";
            bool info = ConfigurationManager.AppSettings["Logging_LogInformation"].ToLower() == "true";

            if (critical) sqlListener.EnableEvents(BasicLogger.Log, EventLevel.Critical);
            if (error) sqlListener.EnableEvents(BasicLogger.Log, EventLevel.Error);
            if (warning) sqlListener.EnableEvents(BasicLogger.Log, EventLevel.Warning);
            if (info) sqlListener.EnableEvents(BasicLogger.Log, EventLevel.Informational);
        }
    }
}
