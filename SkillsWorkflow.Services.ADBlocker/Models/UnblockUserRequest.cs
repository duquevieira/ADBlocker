

using System;

namespace SkillsWorkflow.Services.ADBlocker.Models
{
    public class UnblockUserRequest
    {
        public string Id { get; set; }
        public string AdUserName { get; set; }
        public DateTime? AccountExpirationDate { get; set; }
    }

    public class UnblockUserRequestResult
    {
        public string Id { get; set; }
        public bool RequestResult { get; set; }
        public string RequestResultMessage { get; set; }
    }
}
