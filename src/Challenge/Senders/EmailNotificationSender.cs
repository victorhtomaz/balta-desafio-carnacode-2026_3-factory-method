using Challenge.Abstractions;
using Challenge.Notifications;

namespace Challenge.Senders;

internal class EmailNotificationSender : NotificationSender
{
    protected override INotification CreateOrderConfirmation(string recipient, string orderNumber)
    {
        return new EmailNotification
        {
            Recipient = recipient,
            Subject = "Confirmação de Pedido",
            Body = $"Seu pedido {orderNumber} foi confirmado!",
            IsHtml = true
        };
    }

    protected override INotification CreatePaymentReminder(string recipient, decimal amount)
    {
        return new EmailNotification
        {
            Recipient = recipient,
            Subject = "Lembrete de Pagamento",
            Body = $"Você tem um pagamento pendente de R$ {amount:N2}",
            IsHtml = true
        };
    }

    protected override INotification CreateShippingUpdate(string recipient, string trackingCode)
    {
        return new EmailNotification
        {
            Recipient = recipient,
            Subject = "Pedido Enviado",
            Body = $"Seu pedido foi enviado! Código de rastreamento: {trackingCode}",
            IsHtml = true,
        };
    }
}
