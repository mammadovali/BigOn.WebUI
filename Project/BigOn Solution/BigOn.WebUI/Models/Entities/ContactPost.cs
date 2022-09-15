using BigOn.WebUI.AppCode.Infrastructure;
using System;

namespace BigOn.WebUI.Models.Entities
{
    public class ContactPost : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public int Message { get; set; }
        public string Answer { get; set; }
        public int? AnswerByUserId { get; set; }
        public DateTime? AnswerDate { get; set; }
    }
}
