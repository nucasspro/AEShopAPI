using System;
using System.Collections.Generic;
using System.Linq;

namespace Shop.Domain.Enumerations
{
    public class DiscountRedeemTypeEnum : Enumeration
    {
        public static readonly DiscountRedeemTypeEnum REDEEM = new DiscountRedeemTypeEnum(1, "Redeem");
        public static readonly DiscountRedeemTypeEnum NOT_REDEEM = new DiscountRedeemTypeEnum(2, "Not Redeem");

        protected DiscountRedeemTypeEnum()
        {
        }

        public DiscountRedeemTypeEnum(int id, string name) : base(id, name)
        {
        }

        public static IEnumerable<DiscountRedeemTypeEnum> List() => new[] { REDEEM, NOT_REDEEM };

        public static DiscountRedeemTypeEnum FromName(string name)
        {
            var state = List().SingleOrDefault(s => string.Equals(s.Name, name, StringComparison.CurrentCultureIgnoreCase));

            if (state == null)
            {
                throw new ArgumentException($"Possible values for DiscountRedeemTypeEnum: {string.Join(",", List().Select(s => s.Name))}");
            }

            return state;
        }

        public static DiscountRedeemTypeEnum From(int id)
        {
            var state = List().SingleOrDefault(s => s.Id == id);

            if (state == null)
            {
                throw new ArgumentException($"Possible values for DiscountRedeemTypeEnum: {string.Join(",", List().Select(s => s.Name))}");
            }

            return state;
        }
    }
}