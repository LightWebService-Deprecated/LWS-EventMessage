namespace LWSEvent.Event.Account;

public class AccountDeletedEvent
{
    public string AccountId { get; set; }
    public DateTimeOffset DeletedAt { get; set; }
}