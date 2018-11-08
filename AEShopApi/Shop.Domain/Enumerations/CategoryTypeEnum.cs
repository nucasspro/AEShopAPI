namespace Shop.Domain.Enumerations
{
    public class CategoryTypeEnum : Enumeration
    {
        public static readonly CategoryTypeEnum OutOfStock = new CategoryTypeEnum(1, "Out of Stock");
        public static readonly CategoryTypeEnum Stock = new CategoryTypeEnum(2, "Stock");

        public CategoryTypeEnum()
        {
        }

        public CategoryTypeEnum(int value, string displayName) : base(value, displayName)
        {
        }
    }
}