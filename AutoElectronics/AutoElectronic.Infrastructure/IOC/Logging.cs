using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoElectronic.Infrastructure.IOC
{
    /// <summary>
    /// Contains logging methods.
    /// </summary>
    public class Logger
    {
        /// <summary>
        /// Logs information.
        /// </summary>
        /// <param name="logger">ILogger</param>
        /// <param name="message">Message</param>
        /// <param name="args"></param>
        public static void LogInformation(ILogger logger, string message, params object[] args)
        {
            logger?.LogInformation(message, args);
        }

        /// <summary>
        /// Logs error.
        /// </summary>
        /// <param name="logger">ILogger</param>
        /// <param name="message">Message</param>
        /// <param name="ex"></param>
        public static void LogError(ILogger logger, string message, Exception ex, params object[] args)
        {
            logger?.LogError(ex, message);
        }
    }
}
