using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ConsoleApp41
{
   public class Product
    {
        [Description("我的姓名1")]
        [DisplayName("我的姓名2")]
        [MyDescription(Name ="我的姓名3")]
        public String MyName { get; set; } 
        public int price { get; set; }
        
    }
}
