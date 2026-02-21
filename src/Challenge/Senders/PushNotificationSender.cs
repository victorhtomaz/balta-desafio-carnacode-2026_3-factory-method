using Challenge.Abstractions;
using Challenge.Notifications;

namespace Challenge.Senders;

internal class PushNotificationSender : NotificationSender
{
    protected override INotification CreateOrderConfirmation(string recipient, string orderNumber)
    {
        return new PushNotification
        {
            DeviceToken = recipient,
            Title = "Pedido Confirmado",
            Message = $"Pedido {orderNumber} confirmado!",
            Badge = 1
        };
    }

    protected override INotification CreatePaymentReminder(string recipient, decimal amount)
    {
        return new PushNotification
        {
            DeviceToken = recipient,
            Title = "Lembrete de Pagamento",
            Message = $"Você tem um pagamento pendente de R$ {amount:N2}",
            Badge = 1
        };
    }

    protected override INotification CreateShippingUpdate(string recipient, string trackingCode)
    {
        return new PushNotification
        {
            DeviceToken = recipient,
            Title = "Pedido Enviado",
            Message = $"Rastreamento: {trackingCode}",
            Badge = 1
        };
    }
}
