namespace LWSEvent.Event.Deployment;

public enum DeploymentType
{
    UbuntuDeployment
}

public class DeploymentCreatedEvent
{
    public DeploymentType DeploymentType { get; set; }
    public string AccountId { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public Dictionary<string, object> DeploymentObject { get; set; }
}