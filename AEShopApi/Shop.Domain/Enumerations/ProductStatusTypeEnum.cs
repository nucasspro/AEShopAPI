using System;
using System.Collections.Generic;
using System.Linq;

namespace Shop.Domain.Enumerations
{
    public class ProductStatusTypeEnum : Enumeration
    {
        public static readonly ProductStatusTypeEnum OutOfStock = new ProductStatusTypeEnum(1, "Out of stock");
        public static readonly ProductStatusTypeEnum Stock = new ProductStatusTypeEnum(2, "Stock");
        public static readonly ProductStatusTypeEnum Removed = new ProductStatusTypeEnum(3, "Removed");

        protected ProductStatusTypeEnum()
        {
        }

        public ProductStatusTypeEnum(int id, string name) : base(id, name)
        {
        }

        public static IEnumerable<ProductStatusTypeEnum> List() => new[] { OutOfStock, Stock };

        public static ProductStatusTypeEnum FromName(string name)
        {
            var state = List().SingleOrDefault(s => string.Equals(s.Name, name, StringComparison.CurrentCultureIgnoreCase));

            if (state == null)
            {
                throw new ArgumentException($"Possible values for ProductStatusTypeEnum: {string.Join(",", List().Select(s => s.Name))}");
            }

            return state;
        }

        public static ProductStatusTypeEnum From(int id)
        {
            var state = List().SingleOrDefault(s => s.Id == id);

            if (state == null)
            {
                throw new ArgumentException($"Possible values for ProductStatusTypeEnum: {string.Join(",", List().Select(s => s.Name))}");
            }

            return state;
        }
    }
}