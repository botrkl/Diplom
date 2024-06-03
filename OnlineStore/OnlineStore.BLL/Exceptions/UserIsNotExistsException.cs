using System.Runtime.Serialization;

namespace OnlineStore.BLL.Exceptions
{
    [Serializable]
    public sealed class UserIsNotExistsException : Exception
    {
        public UserIsNotExistsException()
            : base("That user is not exists!")
        {
        }

        public UserIsNotExistsException(string message)
            : base(message)
        {
        }

        private UserIsNotExistsException(SerializationInfo info, StreamingContext context)
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