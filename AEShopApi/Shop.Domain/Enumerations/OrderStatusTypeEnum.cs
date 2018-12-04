using System;
using System.Collections.Generic;
using System.Linq;

namespace Shop.Domain.Enumerations
{
    public class OrderStatusTypeEnum : Enumeration
    {
        public static readonly OrderStatusTypeEnum ACTIVATED = new OrderStatusTypeEnum(1, "Activated");
        public static readonly OrderStatusTypeEnum DEACTIVATED = new OrderStatusTypeEnum(2, "Deactivated");

        protected OrderStatusTypeEnum()
        {
        }

        public OrderStatusTypeEnum(int id, string name) : base(id, name)
        {
        }

        public static IEnumerable<OrderStatusTypeEnum> List() => new[] { ACTIVATED, DEACTIVATED };

        public static OrderStatusTypeEnum FromName(string name)
        {
            var state = List().SingleOrDefault(s => string.Equals(s.Name, name, StringComparison.CurrentCultureIgnoreCase));

            if (state == null)
            {
                throw new ArgumentException($"Possible values for OrderStatusTypeEnum: {string.Join(",", List().Select(s => s.Name))}");
            }

            return state;
        }

        public static OrderStatusTypeEnum From(int id)
        {
            var state = List().SingleOrDefault(s => s.Id == id);

            if (state == null)
            {
                throw new ArgumentException($"Possible values for OrderStatusTypeEnum: {string.Join(",", List().Select(s => s.Name))}");
            }

            return state;
        }
    }
}