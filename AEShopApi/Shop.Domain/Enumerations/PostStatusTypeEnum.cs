using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shop.Domain.Enumerations
{
  public  class PostStatusTypeEnum :  Enumeration
    {
        public static readonly PostStatusTypeEnum ACTIVATED = new PostStatusTypeEnum(1, "Activated");
        public static readonly PostStatusTypeEnum DEACTIVATED = new PostStatusTypeEnum(2, "Deactivated");

        protected PostStatusTypeEnum()
        {
        }

        public PostStatusTypeEnum(int id, string name) : base(id, name)
        {
        }

        public static IEnumerable<PostStatusTypeEnum> List() => new[] { ACTIVATED, DEACTIVATED };

        public static PostStatusTypeEnum FromName(string name)
        {
            var state = List().SingleOrDefault(s => string.Equals(s.Name, name, StringComparison.CurrentCultureIgnoreCase));

            if (state == null)
            {
                throw new ArgumentException($"Possible values for PostStatusTypeEnum: {string.Join(",", List().Select(s => s.Name))}");
            }

            return state;
        }

        public static PostStatusTypeEnum From(int id)
        {
            var state = List().SingleOrDefault(s => s.Id == id);

            if (state == null)
            {
                throw new ArgumentException($"Possible values for PostStatusTypeEnum: {string.Join(",", List().Select(s => s.Name))}");
            }

            return state;
        }
    }
}
