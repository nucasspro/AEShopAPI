namespace Shop.Domain.Enumerations
{
    public class UserStatusTypeEnum : Enumeration
    {
        public static readonly UserStatusTypeEnum Deactivated = new UserStatusTypeEnum(1, "Deactivated");
        public static readonly UserStatusTypeEnum Activated = new UserStatusTypeEnum(2, "Activated");

        public UserStatusTypeEnum()
        {
        }

        public UserStatusTypeEnum(int value, string displayName) : base(value, displayName)
        {
        }
    }
}