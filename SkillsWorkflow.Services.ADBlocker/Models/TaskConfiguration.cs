using System;

namespace SkillsWorkflow.Services.ADBlocker.Models
{
    public class TaskConfiguration
    {
        public DateTime DailyTaskRunnedAt { get; set; }
        public TimeSpan DailyAlertTime { get; set; }
        public bool ShouldLockDomainUser { get; set; }
    }
}
