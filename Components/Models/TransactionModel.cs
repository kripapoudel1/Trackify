
namespace Trackify.TransactionModel
{ 
public enum TransactionType
{
    Credit,
    Debit
}

    public class TransactionModel
    {
        public int TransactionId { get; set; }
        public int UserId { get; set; }
        public TransactionType TransactionType { get; set; } = TransactionType.Credit;
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;
        public List<string> Tags { get; set; } = new List<string>();
        public DateTime DueDate { get; set; }
    }
}
