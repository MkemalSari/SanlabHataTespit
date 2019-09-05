using Be.Timvw.Framework.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanlabHataTespit
{
    public static class LINQExtension
    {
        public static SortableBindingList<object> ToSbl(this IEnumerable<object> items)
        {
            return new SortableBindingList<object>(items);
        }
    }
}
