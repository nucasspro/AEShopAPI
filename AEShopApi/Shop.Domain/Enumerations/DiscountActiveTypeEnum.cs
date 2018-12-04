using System;
using System.Collections.Generic;
using System.Linq;

namespace Shop.Domain.Enumerations
{
    public class DiscountActiveTypeEnum : Enumeration
    {
        public static readonly DiscountActiveTypeEnum ACTIVATED = new DiscountActiveTypeEnum(1, "Activated");
        public static readonly DiscountActiveTypeEnum DEACTIVATED = new DiscountActiveTypeEnum(2, "Deactivated");

        protected DiscountActiveTypeEnum()
        {
        }

        public DiscountActiveTypeEnum(int id, string name) : base(id, name)
        {
        }

        public static IEnumerable<DiscountActiveTypeEnum> List() => new[] { ACTIVATED, DEACTIVATED };

        public static DiscountActiveTypeEnum FromName(string name)
        {
            var state = List().SingleOrDefault(s => string.Equals(s.Name, name, StringComparison.CurrentCultureIgnoreCase));

            if (state == null)
            {
                throw new ArgumentException($"Possible values for DiscountActiveTypeEnum: {string.Join(",", List().Select(s => s.Name))}");
            }

            return state;
        }

        public static DiscountActiveTypeEnum From(int id)
        {
            var state = List().SingleOrDefault(s => s.Id == id);

            if (state == null)
            {
                throw new ArgumentException($"Possible values for DiscountActiveTypeEnum: {string.Join(",", List().Select(s => s.Name))}");
            }

            return state;
        }
    }
}