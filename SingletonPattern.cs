using System;
using System.Collections.Generic;
using System.Text;

namespace DesignModeDemo
{
    /*
     单例模式
     定义：一个类只允许有一个实例。在类内部实例化一次，外部无法对此类实例化。
     特色：只有一个实例
     分类：饿汉模式和懒汉模式(注意多线程安全)      
     */

    //饿汉模式
    public class Singleton1
    {
        private  static Singleton1 singleton1 = new Singleton1();
        private Singleton1() { }

        public static Singleton1 Instance { get { return singleton1; } }
    }


    //懒汉模式
    public class Singleton2 {
        private static Singleton2 singleton2=null;
        private static object locked = new object();
        private Singleton2() { }

        public static Singleton2 Instance
        {
            get
            {
                if (singleton2 == null)
                {
                    lock (locked) {
                        if (singleton2 == null)
                        {
                            singleton2 = new Singleton2();
                        }
                    }
                }

                return singleton2;
            }
        }

    }



}
