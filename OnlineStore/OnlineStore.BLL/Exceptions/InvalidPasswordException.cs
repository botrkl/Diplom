using System.Runtime.Serialization;

namespace OnlineStore.BLL.Exceptions
{
    public sealed class InvalidPasswordException : Exception
    {
        public InvalidPasswordException()
            : base("Password is invalid")
        {
        }

        public InvalidPasswordException(string message)
            : base(message)
        {
        }

        private InvalidPasswordException(SerializationInfo info, StreamingContext context)
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