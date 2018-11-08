namespace Shop.Domain.Enumerations
{
    public class ActivateTypeEnum : Enumeration
    {
        public static readonly ActivateTypeEnum Deactivated = new ActivateTypeEnum(1, "Deactivated");
        public static readonly ActivateTypeEnum Activated = new ActivateTypeEnum(2, "Activated");

        public ActivateTypeEnum()
        {
        }

        public ActivateTypeEnum(int value, string displayName) : base(value, displayName)
        {
        }
    }
}