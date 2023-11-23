using System;

using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace ConsoleApp41
{
    class  Program
    {

        static void Main(string[] args)
        {

            #region 正常调用方法
            //ChengJieRen chengJieRen = new ChengJieRen();
            //Console.WriteLine("请输入罚款人和罚款金额");
            //Console.Write("罚款人姓名：");
            //string xingmiong = Console.ReadLine();
            //Console.Write("  "+xingmiong);
            //Console.Write("罚款金额：");
            //int jine = int.Parse(Console.ReadLine());
            //Console.Write("  " + jine);
            //chengJieRen.SetFaKuan(xingmiong, jine);
            #endregion
            #region 使用反射创建方法或者其他字段；
            //Type type1 = typeof(ChengJieRen);
            //var TYP1 = Activator.CreateInstance(type1) as ChengJieRen;
            //TYP1.SetFaKuan("刘震", 50);
            //TYP1.TextAssembly();

            #endregion
            #region 获取当前程序集的路径
            //String binPath = Directory.GetCurrentDirectory();
            // Console.WriteLine(binPath);
            // #endregion




            // var a= Activator.CreateInstance(type1,"有参构造函数");//操作有参构造函数
            //Object obj = type1.GetConstructors(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)[0].Invoke(null);

            // var a3= type1.GetMethods();
            //Finlize:析构方法，，C#中更过的叫法是对象终结者，作用就是释放资源。
            //GC ：垃圾回收器，释放资源,GC底层调用的就是 对象终结者方法--Finalize
            //foreach (var item in a3)
            //{
            //    Console.WriteLine($"方法名称:{item.Name},方法所属类{item.ReflectedType},方法返回类型{item.ReturnType}");

            //}
            #endregion


            //string ABC = "3";
            //ExtenUtils.GetDate(ABC);


            #region 测试特性
            //Type type2 = typeof(Product);//“获取使用了自定义特性的类型；注意是获取使用自定义特性的类型不是获取自定义类型本身！
            //var ppI = type2.GetProperty("MyName",System.Reflection.BindingFlags.Instance|System.Reflection.BindingFlags.NonPublic|System.Reflection.BindingFlags.Public);//获取这个类型的某个指定的属性，不管是公共还是私有
            //var PPi2 = ppI.GetCustomAttributes(typeof(MyDescriptionAttribute),true);
            //if (PPi2 != null && PPi2.Length > 0)
            //{
            //    foreach (var item in PPi2)
            //    {
            //        MyDescriptionAttribute myDescriptionAttribute = item as MyDescriptionAttribute;
            //        Console.WriteLine($"自定义特性的名字是{myDescriptionAttribute.Name},元数据是{myDescriptionAttribute}");
            //    }



            //}

            #endregion

            #region 测试特性2
            //string str = OrderStateEnum.waitpay.GetDescription();
            //Console.WriteLine(str);

            #endregion
            #region Json
            Type type = typeof(JsonSite);
            var tp1 = Activator.CreateInstance(type) as JsonSite;
            tp1.TestJsonArr();
            



            #endregion







        }
        //操作特性

    }

}
