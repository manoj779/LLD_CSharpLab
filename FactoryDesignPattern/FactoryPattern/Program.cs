using FactoryPattern.FactoryClass;
using FactoryPattern.FactoryClass.ConcreteFactoryClass;
using FactoryPattern.ServiceClass;

public class Program
{
    public static void Main(string[] args)
    {
        // Sending an Email Notification
        NotificationFactory emailFactory = new EmailNotificationFactory();
        NotificationService emailService = new NotificationService(emailFactory);
        emailService.Send("Your order has been confirmed!");

        // Sending an SMS Notification
        NotificationFactory smsFactory = new SmsNotificationFactory();
        NotificationService smsService = new NotificationService(smsFactory);
        smsService.Send("Your package has been shipped!");

        // Sending a Push Notification
        NotificationFactory pushFactory = new PushNotificationFactory();
        NotificationService pushService = new NotificationService(pushFactory);
        pushService.Send("Your order is out for delivery!");

        //Sending a Bot Notification
        NotificationFactory botFactory = new BotNotificationFactory();
        NotificationService botService = new NotificationService(botFactory);
        botService.Send("Your package is recieved from customer..!");
    }
}