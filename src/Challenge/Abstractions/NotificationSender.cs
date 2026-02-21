namespace Challenge.Abstractions;

public abstract class NotificationSender
{
    protected abstract INotification CreateOrderConfirmation(string recipient, string orderNumber);
    protected abstract INotification CreateShippingUpdate(string recipient, string trackingCode);
    protected abstract INotification CreatePaymentReminder(string recipient, decimal amount);

    public void SendOrderConfirmation(string recipient, string orderNumber)
    {
        var notification = CreateOrderConfirmation(recipient, orderNumber);

        notification.Send();
    }

    public void SendShippingUpdate(string recipient, string trackingCode)
    {
        var notification = CreateShippingUpdate(recipient, trackingCode);

        notification.Send();
    }

    public void SendPaymentReminder(string recipient, decimal amount)
    {
        var notification = CreatePaymentReminder(recipient, amount);

        notification.Send();
    }
}
