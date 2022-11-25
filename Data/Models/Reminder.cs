namespace Task_Reminder_Api_Project_1.Data.Models
{
    public class Reminder
    {
        public int Id { get; set; }
        public string? TaskTitle { get; set; }
        public string? DayAndTime { get; set; }
        public bool? IsReminder { get; set; }
    }
}
