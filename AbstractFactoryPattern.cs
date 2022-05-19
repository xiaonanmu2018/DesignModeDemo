using System;
using System.Collections.Generic;
using System.Text;

namespace DesignModeDemo
{
    /*
抽象工厂模式 
定义：把不同的工厂组合成超级工厂，超级工厂可以生产多种产品。
特色：创建不同种类的全部产品
     */

    /*
    举例场景：电脑工厂 (种类：电脑， 产品：主机和显示器)
    */

    //电脑组成
    interface IComputer {
        IMonitor MakeMonitor();
        IHostMachine MakeHostMachine();
    }
    //显示器
    interface IMonitor
    {
        void Make();
    }
    //主机
    interface IHostMachine
    {
        void Make();
    }

    //小米的产品
    class MIMonitor : IMonitor
    {
        public void Make()
        {
            Console.WriteLine("   小米显示器");
        }
    }
    class MIHostMachine : IHostMachine
    {
        public void Make()
        {
            Console.WriteLine("   小米主机");
        }
    }


    //华为的产品
    class HuaWeiMonitor : IMonitor
    {
        public void Make()
        {
            Console.WriteLine("   华为显示器");
        }
    }
    class HuaWeiHostMachine : IHostMachine
    {
        public void Make()
        {
            Console.WriteLine("   华为主机");
        }
    }

    //具体工厂
    class HuaWeiComputerFactory : IComputer
    {
        public HuaWeiComputerFactory()
        {
            Console.WriteLine("华为电脑工厂");
        }

        public IHostMachine MakeHostMachine()
        {
            return new HuaWeiHostMachine();
        }

        public IMonitor MakeMonitor()
        {
            return new HuaWeiMonitor();
        }
    }

    class MIComputerFactory : IComputer
    {
        public MIComputerFactory()
        {
            Console.WriteLine("小米电脑工厂");
        }
        public IHostMachine MakeHostMachine()
        {
            return new MIHostMachine();
        }

        public IMonitor MakeMonitor()
        {
            return new MIMonitor();
        }
    }

}
