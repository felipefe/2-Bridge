namespace Name
{
    public class MessageAnexo : Message
    {
        public MessageAnexo(ISendMessage send) : base(send)
        {
        }

        public override void MessageToSend()
        {
             Console.WriteLine("Mensagem em anexo...");
        }
    }
}