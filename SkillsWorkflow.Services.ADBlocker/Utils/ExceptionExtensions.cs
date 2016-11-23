using System;
using System.Diagnostics;

namespace SkillsWorkflow.Services.ADBlocker.Utils
{
    public static class ExceptionExtensions
    {
        public static void TraceError(this Exception _this)
        {
            Trace.TraceError("Time: {0}; Exception: {1}", DateTime.UtcNow.ToString("dd/MM/yyyy HH:mm:ss.fff"), _this);
        }
    }
}
