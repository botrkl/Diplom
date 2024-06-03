using System.Runtime.Serialization;

namespace OnlineStore.BLL.Exceptions
{
    [Serializable]
    public sealed class InvalidEmailAddressException : Exception
    {
        public InvalidEmailAddressException(string email = "empty")
            : base($"Email address is invalid: {email}")
        {
        }

        private InvalidEmailAddressException(SerializationInfo info, StreamingContext context)
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