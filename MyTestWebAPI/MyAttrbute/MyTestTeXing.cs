using System;

namespace MyTestWebAPI.MyAttrbute
{
    [AttributeUsage(AttributeTargets.Class)]
    public class MyTestTeXingAttribute : Attribute
    {
        public int ID { get; set; }
        public string Destibution { get; set; }
        public MyTestTeXingAttribute(int id)
        {
            ID = id;
            ExeBefore(Destibution);

        }
        private string ExeBefore(string text)
        {

            return "success";
        }
    }
}
