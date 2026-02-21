using Challenge.Abstractions;
using Challenge.Senders;

Console.WriteLine("=== Sistema de Notificações ===\n");

NotificationSender sender;

sender = new EmailNotificationSender();

var clientEmail = "cliente@email.com";
sender.SendShippingUpdate(clientEmail, "BR123456789");

Console.WriteLine("----------");
sender.SendOrderConfirmation(clientEmail, "12345");

Console.WriteLine("----------");
sender.SendPaymentReminder(clientEmail, 150.00m);

Console.WriteLine("===============================");

sender = new SmsNotificationSender();

var clientPhone = "+5511999999999";
sender.SendShippingUpdate(clientPhone, "BR123456789");

Console.WriteLine("----------");
sender.SendOrderConfirmation(clientPhone, "12345");

Console.WriteLine("----------");
sender.SendPaymentReminder(clientPhone, 150.00m);

Console.WriteLine("===============================");

sender = new PushNotificationSender();

var clientDevice = "device-token-abc123";
sender.SendShippingUpdate(clientDevice, "BR123456789");

Console.WriteLine("----------");
sender.SendOrderConfirmation(clientDevice, "12345");

Console.WriteLine("----------");
sender.SendPaymentReminder(clientDevice, 150.00m);

Console.WriteLine("===============================");

sender = new WhatsAppNotificationSender();

var clientWhatNumber = "+5511888888888";
sender.SendShippingUpdate(clientWhatNumber, "BR123456789");

Console.WriteLine("----------");
sender.SendOrderConfirmation(clientWhatNumber, "12345");

Console.WriteLine("----------");
sender.SendPaymentReminder(clientWhatNumber, 150.00m);