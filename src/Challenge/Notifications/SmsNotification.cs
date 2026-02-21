using Challenge.Abstractions;

namespace Challenge.Notifications;

public class SmsNotification : INotification
{
    public string PhoneNumber { get; set; } = string.Empty;
    public string Message { get; set; } = string.Empty;

    public void Send()
    {
        Console.WriteLine($"📱 Enviando SMS para {PhoneNumber}");
        Console.WriteLine($"   Mensagem: {Message}");
    }
}
