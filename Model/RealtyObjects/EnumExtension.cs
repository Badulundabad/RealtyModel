using System;

namespace RealtyModel.Model.RealtyObjects
{
    public static class EnumExtension
    {
        public static String ToString(this City city)
        {
            return city.ToString().Replace('_', '-');
        }
        public static String ToString(this District city)
        {
            return city.ToString().Replace('_', ' ');
        }
    }
}
