namespace RefactoringLab;

public class PushChannel : INotificationChannel
{
    public string Name => "push";
    public void Deliver(string to, string message, DateTime? sendAt) =>
        Console.WriteLine($"[{ChannelTag.For(Name, sendAt)}] {to}: {message}");
}
