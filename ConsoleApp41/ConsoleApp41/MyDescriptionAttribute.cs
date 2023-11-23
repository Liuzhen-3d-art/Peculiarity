using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp41
{
    //自定义特性的基本声明是你的类名以Attribute结尾，并且在类中继承Attribute。
    [AttributeUsage(AttributeTargets.All)]/*特性上面的特性叫做“元特性”，是特性范围是指你自定义的特性对什么有效？一般都是对一切都有效。*/
    
    //对特性进行描述的特性叫元特性
    public class MyDescriptionAttribute:Attribute
    {
        //特性内部可以写属性
        public string Name { get; set; }
    }
}
