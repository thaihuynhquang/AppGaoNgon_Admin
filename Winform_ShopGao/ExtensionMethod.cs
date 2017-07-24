using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Winform_ShopGao
{
    static class ExtensionMethod
    {
        public static List<PropertyInfo> GetAllProperties(this object obj)
        {
            var type = obj.GetType();
            var properties = type.GetProperties();
            return properties.ToList();
        }
    }
}
