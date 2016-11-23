
namespace SkillsWorkflow.Services.ADBlocker.Models
{
    public class BlockedLoginRequest
    {
        public string Id { get; set; }
        public string AdUserName { get; set; }
        public string Password { get; set; }
    }

    public class BlockedLoginRequestResult
    {
        public string Id { get; set; }
        public bool RequestResult { get; set; }
        public string RequestResultMessage { get; set; }
    }
}
