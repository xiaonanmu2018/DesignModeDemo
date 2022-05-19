using System;
using System.Collections.Generic;
using System.Text;

namespace DesignModeDemo
{
    /*
原型模式
定义：通过复制一个对象而创建出新的实例。 
特色：复制 (浅拷贝和深拷贝)      
     */

    /*
   举例场景：创建新实例对象
   */



    class Prototype {
        public Prototype(string name) {
            this.Name = name;
        }

        public string Name { get; set; }
    }

    //拷贝
    class GamePrototype 
    {
        public Prototype prototype;  //引用类型   
        public int Num; //值类型
        public string Name; //引用类型      

        public GamePrototype(string name,int num) {
            prototype = new Prototype(name);
            Name = name;
            Num = num;
        }

        //浅拷贝
        public GamePrototype Clone()
        {
            return (GamePrototype)this.MemberwiseClone();
        }

        //深拷贝
        public GamePrototype Clone2()
        {
            var r= (GamePrototype)this.MemberwiseClone(); 
            r.prototype = new Prototype(this.Name);
            return r;

        }
    }





}
