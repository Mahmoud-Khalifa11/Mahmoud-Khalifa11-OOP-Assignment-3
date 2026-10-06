namespace RefactoringLab;

public interface INotificationChannel
{
    string Name { get; }
    void Deliver(string to, string message, DateTime? sendAt);
}

public class EmailChannel : INotificationChannel
{
    public string Name => "email";
    public void Deliver(string to, string message, DateTime? sendAt) =>
        Console.WriteLine($"[{ChannelTag.For(Name, sendAt)}] {to}: {message}");
}

public class SmsChannel : INotificationChannel
{
    public string Name => "sms";
    public void Deliver(string to, string message, DateTime? sendAt) =>
        Console.WriteLine($"[{ChannelTag.For(Name, sendAt)}] {to}: {message}");
}

public static class ChannelTag
{
    public static string For(string channel, DateTime? sendAt) =>
        sendAt is null ? channel : $"{channel} scheduled {sendAt:g}";
}

public class Notification
{
    private readonly INotificationChannel _channel;
    private readonly bool _urgent;
    private readonly DateTime? _sendAt;

    public Notification(INotificationChannel channel, bool urgent = false, DateTime? sendAt = null)
    {
        _channel = channel;
        _urgent = urgent;
        _sendAt = sendAt;
    }

    public void Send(string to, string message) =>
        _channel.Deliver(to, _urgent ? $"[URGENT] {message}" : message, _sendAt);
}

