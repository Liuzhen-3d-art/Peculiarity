using System;

using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp41
{
    
    class ChengJieRen
    {
        /// <summary>
        /// 罚款人
        /// </summary>
        public string xingming;
        public string fakuanshijian;
        public int benyuejinqianzongshu = 1000;
        public int bencifakuanzongshu;
       public ChengJieRen()
        {
            Console.WriteLine("无参构造函数");
        }
        public ChengJieRen(string xingming)
        {
            Console.WriteLine(xingming+"是有参构造函数");
        }
   
        /// <summary>
        /// 罚款的方法
        /// </summary>
        /// <param name="xingming">被罚人姓名</param>
        /// <param name="bencifakuan">本次罚款数目</param>
        public void SetFaKuan(string xingming,int bencifakuan)
        {
            this.xingming = xingming;
            this.bencifakuanzongshu = bencifakuan;
            this.benyuejinqianzongshu = benyuejinqianzongshu - bencifakuanzongshu;
            fakuanshijian= System.DateTime.Now.ToString("F");
            Console.WriteLine($"{fakuanshijian}  {xingming}罚款{bencifakuanzongshu},本月还剩余{benyuejinqianzongshu}元");

        }
        public void TextAssembly()//加载程序集和获取程序集
        {
            Assembly assembly1 = Assembly.Load("ConsoleApp41");//加载程序集（必须在当前bin目录下）就是本程序必须是包含在这个程序集内的。
            
            Console.WriteLine(assembly1);
            Assembly assembly2 = Assembly.LoadFile(@"C:\Users\Administrator\Source\Repos\ConsoleApp41\ConsoleApp41\bin\Debug\ConsoleApp41.exe");//通过路径加载程序集
            string file = Assembly.GetExecutingAssembly().GetName().Name;//获取当前程序集的名称
            Console.WriteLine(file);
            string location = Assembly.GetExecutingAssembly().Location;//获取当前程序集的完整路径
            Console.WriteLine(location);
            string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();//获取程序集的版本号
            Console.WriteLine(version);

        }


        
    }
}
