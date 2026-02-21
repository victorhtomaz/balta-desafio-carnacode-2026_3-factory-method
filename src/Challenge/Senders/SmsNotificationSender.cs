using Challenge.Abstractions;
using Challenge.Notifications;

namespace Challenge.Senders;

internal class SmsNotificationSender : NotificationSender
{
    protected override INotification CreateOrderConfirmation(string recipient, string orderNumber)
    {
        return new SmsNotification
        {
            PhoneNumber = recipient,
            Message = $"Pedido {orderNumber} confirmado!"
        };
    }

    protected override INotification CreatePaymentReminder(string recipient, decimal amount)
    {
        return new SmsNotification
        {
            PhoneNumber = recipient,
            Message = $"Pagamento pendente: R$ {amount:N2}"
        };
    }

    protected override INotification CreateShippingUpdate(string recipient, string trackingCode)
    {
        return new SmsNotification
        {
            PhoneNumber = recipient,
            Message = $"Pedido enviado! Rastreamento: {trackingCode}"
        };
    }
}
