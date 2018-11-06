using System;

namespace Lib.Mediator
{
    public class User
    {
        public string Name {get;set;}
        public void SendMessage(string message)
        {
            ChatRoom.ShowMessage(this, message);
        }
    }
}
