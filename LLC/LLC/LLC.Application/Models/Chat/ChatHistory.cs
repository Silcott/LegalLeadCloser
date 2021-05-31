using LLC.Application.Models.Identity;
using System;

namespace LLC.Application.Models.Chat
{
    public partial class ChatHistory
    {
        public long Id { get; set; }
        public string FromUserId { get; set; }
        public string ToUserId { get; set; }
        public string Message { get; set; }
        public DateTime CreatedDate { get; set; }
        public virtual LLCUser FromUser { get; set; }
        public virtual LLCUser ToUser { get; set; }
    }
}