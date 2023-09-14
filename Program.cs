namespace Name
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ISendMessage sendFor = new SendMessageSMS();
            Message message = new MessageAnexo(sendFor);

            message.MessageToSend();
            message.SendMessage();

        }
    }
}