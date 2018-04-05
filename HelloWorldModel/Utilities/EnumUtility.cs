
namespace HelloWorldModel.Utilities
{
    using System;
    using System.ComponentModel;
    using System.Linq;

    public static class EnumUtility
    {
        public static string GetEnumDescription(this Enum value)
        {
            return GetEnumDescription(value.GetType(), value);

        }
        private static string GetEnumDescription(Type enumType, object value)
        {
            var member = enumType.GetMember(value.ToString())[0];
            var attributes = member.GetCustomAttributes(true).OfType<DescriptionAttribute>();
            return attributes.SingleOrDefault(a => a.GetType() == typeof(DescriptionAttribute)).Description;
        }
    }
}
