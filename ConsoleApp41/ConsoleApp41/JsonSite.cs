using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;




namespace ConsoleApp41
{
    class JsonSite
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public string Url { get; set; }
        public List<Product> products { get; set; }

        
        //json 反序列化 ==> 定义：Json字符串转换为C# string字符串。
        
        public void TestJsonToObject()
        {
            string Json = "{\"ID\":1,\"Name\":\"爱看电影的梁邱\",\"Url\":\"www.renwoxing.com\"}";
            try
            {
                var site = JsonConvert.DeserializeObject(Json) as JsonSite;
               
                Console.WriteLine($"ID是{site.ID},姓名是{site.Name},网址是{site.Url}");
            }
            catch (Exception)
            {

                var site = JsonConvert.DeserializeObject<JsonSite>(Json);
                Console.WriteLine($"ID是{site.ID},姓名是{site.Name},网址是{site.Url}");
            }
            
   
        
            
            
          
        
            
        }
        //C# 对象序列化为Json 字符串
        public void TestObjectToJson()
        {
            JsonSite jsonSite = new JsonSite() { ID = 2, Name = "腾讯", Url = "www.tengxun.com" };
            var ObjToJs = JsonConvert.SerializeObject(jsonSite);
            Console.WriteLine(ObjToJs);

        }
        // json数组
        public void TestJsonArr()
        {
            string Json = "[{\"ID\":1,\"Name\":\"爱看电影的梁邱\",\"Url\":\"www.renwoxing.com\"}," +
                "{\"ID\":2,\"Name\":\"爱吹泡泡的泡泡龙\",\"Url\":\"www.jiulong.com\"}]";
            List<JsonSite> list = JsonConvert.DeserializeObject<List<JsonSite>>(Json);
          
        }

        
    }
   

}
