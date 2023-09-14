namespace Name
{
    public class MessageTxt : Message
    {
        public MessageTxt(ISendMessage send) : base(send)
        {
        }

        public override void MessageToSend()
        {
            Console.WriteLine("Mensagem de texto...");
        }
    }
}