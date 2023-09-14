namespace Name
{   
    public abstract class Message
    {
        private ISendMessage iSendMessage;

        public Message(ISendMessage send)
        {
            iSendMessage = send;
        }

        public abstract void MessageToSend();

        public void SendMessage()
        {
            iSendMessage.SendMessage();
        }
    }
}