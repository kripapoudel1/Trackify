public class ApplicationState
{
    public int? UserId { get; set; }
    public string Username { get; set; } = string.Empty;
    public string CurrencyType { get; set; } = "USD";

    public bool IsLoggedIn => UserId.HasValue;

    public decimal Balance { get; set; } = 0; // Default balance is 0
}