using System.Runtime.Serialization;

namespace OnlineStore.BLL.Exceptions
{
    [Serializable]
    public sealed class UserAlreadyExistsException : Exception
    {
        public UserAlreadyExistsException()
            : base("That user already exists!")
        {
        }

        public UserAlreadyExistsException(string message)
            : base(message)
        {
        }

        private UserAlreadyExistsException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            string? customMessage = info.GetString("CustomMessage");
            this.Data["CustomMessage"] = customMessage;
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);

            info.AddValue("CustomMessage", this.Message);
        }
    }
}