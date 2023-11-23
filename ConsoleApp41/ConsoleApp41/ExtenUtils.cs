using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ConsoleApp41
{
    //扩展方法的工具类，注意一定要写成static 静态类
    public enum ComponentMode
    {
        [Description("星期一")]
        Monday,
        [Description("星期二")]
        Tuesday,
        [Description("星期三")]
        Wednesday,
        [Description("星期四")]
        Thursday,
        [Description("星期五")]
        Friday,
        [Description("星期六")]
        Saturday,
        [Description("星期日")]
        Sunday
    }
    
 public static class ExtenUtils
    {
       
        #region 扩展方法
        /*
         * 1、静态类下所有的方法都只能是static 方法
         * 2、把你需要扩展的类型前面加this
         */
        /// <summary>
        ///把object类型提供一个转换为Int类型的扩展方法。
        /// </summary> 
        public static int ParseInt(this object obj)
        {
            int result = 0;
            if (obj == null)
            {
                return result;
            }
            try
            {
                string bb = obj.ToString();
                result = int.Parse(bb);
                return result;
            }
            catch (Exception)
            {

                Console.WriteLine("请检查你的输入是否正确，请输入正确的类型值，返回0是系统默认值");
            }
            //if(int.TryParse(obj.ToString(), out result))
            //{
            //    return result;
            //}
            return result;

        }//在你需要扩展的类型前面加一个this关键字
        #endregion
        #region 特性
        /*特性:
         * 使用特性，可以有效地将元数据或声明性信息与代码(程序集、类型、方法、属性等）相关联。将特性与程序实体相关联后，可以再运行时使用反射这项技术查询特性，常运用于AOP技术
         * AOP是面向切面编程，AOP与扩展方法的区别是，扩展方法是对某个类型的增强，AOP是对某个方法或者某个类的增强。
         * AOP的优点:AOP不影响原有方法或者类型的代码。像扩展方法一样是对某个方法或者类型的增强或扩展。
          特性具有以下属性:
          1、特性向程序添加元数据。元数据是程序中定义的类型的相关信息。所有.NET程序集都包含这一组指定的元数据，用于描述程序集中定义的类型和类型成员。可以添加自定义特性来指定所需的其他任何信息。
          2、可以将一个或多个特性用于整个程序集、模块或较小的程序元素（如类和属性).
          3、特性可以像方法和属性一样接受自变量。
          4、程序可使用反射来检查自己的元数据或其他程序的元数据。*/
        #endregion
        public static void GetDate(object obj)
        {
            object jieguo =obj;
            int result = 0;
            try
            {
                jieguo = obj.ToString();
                result = int.Parse((string)jieguo);

                string a= Enum.GetName(typeof(ComponentMode),result);
              


                if (a == null)
                {
                    Console.WriteLine("查询无结果,请检查输入索引");
                }
                else
                {
                    Console.WriteLine(a);
                }
                
            }
            catch (Exception)
            {

                Console.WriteLine("输入内容出错！请检查输入内容！");
            }
        }
       

    }
}
