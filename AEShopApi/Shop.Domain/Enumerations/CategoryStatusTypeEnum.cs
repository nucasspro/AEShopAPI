using System;
using System.Collections.Generic;
using System.Linq;

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

        public static IEnumerable<CategoryStatusTypeEnum> List() => new[] { Actived, Removed };

        public static CategoryStatusTypeEnum FromName(string name)
        {
            var state = List().SingleOrDefault(s => string.Equals(s.Name, name, StringComparison.CurrentCultureIgnoreCase));

            if (state == null)
            {
                throw new ArgumentException($"Possible values for CategoryStatusTypeEnum: {string.Join(",", List().Select(s => s.Name))}");
            }

            return state;
        }

        public static CategoryStatusTypeEnum FromId(int id)
        {
            var state = List().SingleOrDefault(s => s.Id == id);

            if (state == null)
            {
                throw new ArgumentException($"Possible values for CategoryStatusTypeEnum: {string.Join(",", List().Select(s => s.Name))}");
            }

            return state;
        }
    }
}