namespace Name
{
    public class SendMessageSMS : ISendMessage
    {
        public void SendMessage()
        {
            Console.WriteLine("Enviado via SMS");
        }
    }
}