using RefactoringLab;

var shipping = new ShippingCostCalculator(new ICarrier[]
{
    new AramexCarrier(), new FedExCarrier(), new DhlCarrier(),
    new BostaCarrier()
});
Console.WriteLine($"Aramex 2kg → {shipping.Calculate("Aramex", 2)}");
Console.WriteLine($"FedEx 2kg  → {shipping.Calculate("FedEx", 2)}");
Console.WriteLine($"Bosta 2kg  → {shipping.Calculate("Bosta", 2)}");
Console.WriteLine();

var processor = new OrderProcessor(new SqlOrderRepository(), new SmtpEmailSender());
processor.Process(1001, "customer@example.com");
Console.WriteLine();

new Notification(new EmailChannel(), urgent: true, sendAt: DateTime.Today.AddHours(18))
    .Send("customer@example.com", "Your order ships tomorrow");
new Notification(new SmsChannel(), urgent: true)
    .Send("+201000000000", "OTP 4821");

new Notification(new PushChannel()).Send("device-42", "Hello");
new Notification(new PushChannel(), urgent: true, sendAt: DateTime.Today.AddHours(9))
    .Send("device-42", "Flash sale");

