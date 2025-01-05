namespace Trackify.Models
{
    public enum DebtStatus
    {
        Pending,
        Cleared
    }

    public class DebtModel
    {
        public int DebtId { get; set; } 
        public int UserId { get; set; } 
        public string DebtSource { get; set; } = string.Empty; 
        public decimal Amount { get; set; } 
        public DateTime DueDate { get; set; } 
        public DebtStatus Status { get; set; } = DebtStatus.Pending; 
    }
}