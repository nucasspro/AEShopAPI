namespace Shop.Domain.Enumerations
{
    public class GenderTypeEnum : Enumeration
    {
        public static readonly GenderTypeEnum Male = new GenderTypeEnum(1, "Male");
        public static readonly GenderTypeEnum Female = new GenderTypeEnum(2, "Female");

        public GenderTypeEnum()
        {
        }

        public GenderTypeEnum(int value, string displayName) : base(value, displayName)
        {
        }
    }
}