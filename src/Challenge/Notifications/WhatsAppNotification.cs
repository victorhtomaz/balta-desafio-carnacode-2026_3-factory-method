using Challenge.Abstractions;

namespace Challenge.Notifications;

public class WhatsAppNotification : INotification
{
    public string PhoneNumber { get; set; } = string.Empty;
    public string Message { get; set; } = string.Empty;
    public bool UseTemplate { get; set; }

    public void Send()
    {
        Console.WriteLine($"💬 Enviando WhatsApp para {PhoneNumber}");
        Console.WriteLine($"   Mensagem: {Message}");
        Console.WriteLine($"   Template: {UseTemplate}");
    }
}
