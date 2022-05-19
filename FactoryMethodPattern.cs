using System;
using System.Collections.Generic;
using System.Text;

namespace DesignModeDemo
{
    /*
工厂方法模式 
定义：一个工厂只能创建一种产品。
特色：只能创建一种产品
     */


    /*
     举例场景：键盘工厂（产品：键盘）
     */

    interface IKeyboard
    {
        void Make();
    }

    class MIKeyboard : IKeyboard
    {
        public void Make()
        {
            Console.WriteLine("   小米键盘");
        }
    }

    class HuaWeiKeyboard : IKeyboard
    {
        public void Make()
        {
            Console.WriteLine("   华为键盘");
        }
    }

    interface IFactory {
        IKeyboard Assemble();
    }

    class MIFactory : IFactory
    {
        public IKeyboard Assemble()
        {
            Console.WriteLine("小米工厂");
            return new MIKeyboard();
        }
    }

    class HuaWeiFactory : IFactory
    {
        public IKeyboard Assemble()
        {
            Console.WriteLine("华为工厂");
            return new HuaWeiKeyboard();
        }
    }

}
