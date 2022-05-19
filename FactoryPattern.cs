using System;
using System.Collections.Generic;
using System.Text;

namespace DesignModeDemo
{
    /*
简单工厂模式 
定义：在一个类中，利用入参来分别构建不同类的实例。
特色：需要写很多的if-else 
     */

    /*
     举例场景：显示器工厂（产品：显示器）
     */

    interface IDisplay {
        void Make();
    }

    class MIDisplay : IDisplay
    {
        public void Make()
        {
            Console.WriteLine("小米显示器");
        }
    }

    class HuaWeiDisplay : IDisplay
    {
        public void Make()
        {
            Console.WriteLine("华为显示器");
        }
    }

    class DisplayFactory
    {
        public static void Make(string name)
        {
            switch (name)
            {
                case "huawei":
                    new MIDisplay().Make();
                    break;
                case "mi":
                    new HuaWeiDisplay().Make();
                    break;
            }            
        }

    }
}
