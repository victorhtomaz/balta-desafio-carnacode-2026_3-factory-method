using Challenge.Abstractions;
using Challenge.Notifications;

namespace Challenge.Senders;

internal class WhatsAppNotificationSender : NotificationSender
{
    protected override INotification CreateOrderConfirmation(string recipient, string orderNumber)
    {
        return new WhatsAppNotification
        {
            PhoneNumber = recipient,
            Message = $"✅ Seu pedido {orderNumber} foi confirmado!",
            UseTemplate = true
        };
    }

    protected override INotification CreatePaymentReminder(string recipient, decimal amount)
    {
        return new WhatsAppNotification
        {
            PhoneNumber = recipient,
            Message = $"⏰ Lembrete de pagamento: R$ {amount:F2} pendente.",
            UseTemplate = true
        };
    }

    protected override INotification CreateShippingUpdate(string recipient, string trackingCode)
    {
        return new WhatsAppNotification
        {
            PhoneNumber = recipient,
            Message = $"📦 Pedido enviado! Rastreamento: {trackingCode}",
            UseTemplate = true
        };
    }
}
