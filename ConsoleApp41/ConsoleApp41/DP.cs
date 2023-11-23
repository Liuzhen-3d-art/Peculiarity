using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Reflection;


namespace ConsoleApp41
{

    public static class DP
    {

        public static string GetDescription(this OrderStateEnum Oe)
        {
            //string a = Oe.ToString();
            //Type type = typeof(OrderStateEnum);
            //if (type.GetMember(Oe.ToString()) != null)
            //{
            //    FieldInfo field = type.GetField(Oe.ToString(), System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Public);
            //    DescriptionAttribute attribute = field.GetCustomAttribute(typeof(DescriptionAttribute)) as DescriptionAttribute;
            //    if (attribute != null)
            //    {

            //        a = attribute.Description;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine($"{Oe} 不存在于 OrderStateEnum 中");
            //}
            //return a;
            Type type = typeof(OrderStateEnum);
            FieldInfo field = type.GetField(Oe.ToString(), BindingFlags.Instance | BindingFlags.NonPublic|BindingFlags.Public);
            DescriptionAttribute descriptionAttribute = field.GetCustomAttribute(typeof(DescriptionAttribute)) as DescriptionAttribute;
            return descriptionAttribute.Description;
            
            


        }
    }
}
