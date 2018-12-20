namespace Shop.Domain.Enumerations
{
    public class CategoryStatusTypeEnum : Enumeration
    {
        public static readonly CategoryStatusTypeEnum Actived = new CategoryStatusTypeEnum(1, "Actived");
        public static readonly CategoryStatusTypeEnum Removed = new CategoryStatusTypeEnum(2, "Removed");

        public CategoryStatusTypeEnum()
        {
        }

        public CategoryStatusTypeEnum(int value, string displayName) : base(value, displayName)
        {
        }
    }
}