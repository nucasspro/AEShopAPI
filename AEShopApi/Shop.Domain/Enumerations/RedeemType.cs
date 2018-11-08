namespace Shop.Domain.Enumerations
{
    public class RedeemType : Enumeration
    {
        public static readonly RedeemType Cannot_Redeem = new RedeemType(1, "Can not redeem");
        public static readonly RedeemType Can_Redeem = new RedeemType(2, "Can redeem");

        public RedeemType()
        {
        }

        public RedeemType(int value, string displayName) : base(value, displayName)
        {
        }
    }
}