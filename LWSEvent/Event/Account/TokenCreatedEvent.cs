namespace LWSEvent.Event.Account;

public class TokenCreatedEvent
{
    /// <summary>
    /// Target Account Id
    /// </summary>
    public string AccountId { get; set; }
    
    /// <summary>
    /// Freshly created Namespace(Full Name)
    /// </summary>
    public string NameSpace { get; set; }
    
    /// <summary>
    /// Corresponding namespace JWT
    /// </summary>
    public string NameSpaceToken { get; set; }
}