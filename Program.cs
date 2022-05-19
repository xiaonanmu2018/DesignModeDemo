using System;

namespace DesignModeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 装饰器模式

            //ICompany person = new Company();
            //Console.WriteLine( person.Introduct());

            //person = new CompanyName(person);
            //Console.WriteLine(person.Introduct());

            //person = new CompanyAddress(person);
            //Console.WriteLine(person.Introduct());

            #endregion


            #region 适配器模式

            //var iphone =new AdapterManage();
            //iphone.ChangeLine();

            //var iphone2 = new AdapterManageClass();
            //iphone2.ChangeLine();

            #endregion

            #region 代理模式

            //ISellers hourse = new ProxyHome();
            //hourse.LeadTheWay();

            #endregion

            #region 组合模式

            //var root = new ContainerNode("D盘:");
            //root.AddChild(new DirectoryNode("  目录一"));

            //var threeRoot = new ContainerNode("  目录二");
            //root.AddChild(threeRoot);
            //threeRoot.AddChild(new DirectoryNode("     目录二(1)"));
            //threeRoot.AddChild(new DirectoryNode("     目录二(2)"));

            //root.AddChild(new DirectoryNode("  目录三"));

            #endregion

            #region 单例模式

            //Console.WriteLine(Singleton1.Instance.GetHashCode());
            //Console.WriteLine(Singleton1.Instance.GetHashCode());

            //Console.WriteLine(Singleton2.Instance.GetHashCode());
            //Console.WriteLine(Singleton2.Instance.GetHashCode());

            #endregion

            #region 简单工厂模式

            //DisplayFactory.Make("huawei");
            //DisplayFactory.Make("mi");

            #endregion

            #region 工厂方法模式

            //IFactory fc=new MIFactory();
            //fc.Assemble().Make();

            //fc = new HuaWeiFactory();
            //fc.Assemble().Make();

            #endregion

            #region 抽象工厂模式

            //IComputer computer = new HuaWeiComputerFactory();
            //computer.MakeHostMachine().Make();
            //computer.MakeMonitor().Make();

            //computer = new MIComputerFactory();
            //computer.MakeHostMachine().Make();
            //computer.MakeMonitor().Make();

            #endregion

            #region 建造者模式

            //var director = new DirectorBuilder();
            //director.SetBuilder(new WeaponsStoreBuilder());
            //Console.WriteLine();
            //director.SetBuilder(new GroceryStoreBuilder());

            #endregion

            #region 原型模式

            var mm = new GamePrototype("test1",1);
            var mm1= mm.Clone();
            var mm2 = mm.Clone2();

            mm1.prototype.Name = "test2";
            mm1.Name = "test2";
            mm1.Num = 2;
          
            mm2.prototype.Name = "test3";
            mm2.Name = "test3";
            mm2.Num = 3;

            Console.WriteLine("原对象值:"+mm.prototype.Name +"|"+mm.Name+"|"+mm.Num);
            Console.WriteLine("浅拷贝对象值:" + mm1.prototype.Name + "|" + mm1.Name + "|" + mm1.Num);
            Console.WriteLine("深拷贝对象值:" + mm2.prototype.Name + "|" + mm2.Name + "|" + mm2.Num);

            #endregion



            Console.ReadKey();
        }
    }
}
