namespace LWSEvent.Event.Account;

public class AccountCreatedEvent
{
    public string AccountId { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
}