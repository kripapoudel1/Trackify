public class User
{
    public int UserId { get; set; }
    public string Username { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string CurrencyType { get; set; } = "USD";
    public decimal Balance { get; set; } = 0; // Default balance
}