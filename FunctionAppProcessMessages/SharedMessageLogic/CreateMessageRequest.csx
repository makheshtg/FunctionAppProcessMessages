public class CreateMessageRequest
{
    public string Number;
    public string FirstName;

    public override string ToString() => $"{FirstName} {Number}";
}