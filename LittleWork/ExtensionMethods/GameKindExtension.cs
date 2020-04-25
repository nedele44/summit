using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using LittleWork.Entity;


namespace LittleWork.ExtensionMethods
{
    public static class GameKindExtension
    {
        public static string GetDescription(this GameKind value)
        {
            Type enumType = typeof(GameKind);
            FieldInfo enumFieldInfo = enumType.GetField(value.ToString());
            DescriptionAttribute attribute = (DescriptionAttribute)DescriptionAttribute.GetCustomAttribute(enumFieldInfo, typeof(DescriptionAttribute));
            return attribute.Description;
        }
    }
}
