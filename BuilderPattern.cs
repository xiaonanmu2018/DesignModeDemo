using System;
using System.Collections.Generic;
using System.Text;

namespace DesignModeDemo
{
    /*
建造者模式 
定义： 通过不同的属性组装来创建一个新的实例。有4个角色（抽象建造者，具体建造者，产品，组装者），组装者通过不同的组装顺序而创建不同的实例。
特色：组装      
     */

    /*
     举例场景：创建游戏人物
     */


    //人物特性
    public class Persion {
        public string Name{ get; set; }
        public string Age { get; set; }
        public string Role { get; set; }
        public string Gender { get; set; }
    }

    //定义人物创建过程
    interface IBuilderPersion
    {
        void SetName();
        void SetAge();
        void SetRole();
        void SetGender();
        Persion CreaterPersion();
    }

    //创建 杂货铺伙计
    class GroceryStoreBuilder : IBuilderPersion
    {
        Persion persion = new Persion();
        public Persion CreaterPersion()
        {
            return persion;
        }

        public void SetAge()
        {
            persion.Age = "不详";
        }

        public void SetGender()
        {
            persion.Gender = "男";
        }

        public void SetName()
        {
            persion.Name = "李四";
        }

        public void SetRole()
        {
            persion.Role = "杂货铺伙计";
        }
    }

    //创建 武器店工匠
    class WeaponsStoreBuilder : IBuilderPersion
    {
        Persion persion = new Persion();
        public Persion CreaterPersion()
        {
            return persion;
        }

        public void SetAge()
        {
            persion.Age = "43岁";
        }

        public void SetGender()
        {
            persion.Gender = "男";
        }

        public void SetName()
        {
            persion.Name = "不详";
        }

        public void SetRole()
        {
            persion.Role = "武器店工匠";
        }
    }


    //组装
    class DirectorBuilder {
      
        public void SetBuilder(IBuilderPersion _persion) {

            _persion.SetAge();
            _persion.SetGender();
            _persion.SetName();
            _persion.SetRole();
            var persion= _persion.CreaterPersion();
            Console.WriteLine($"姓名：{persion.Name}");
            Console.WriteLine($"年龄：{persion.Age}");
            Console.WriteLine($"性别：{persion.Gender}");
            Console.WriteLine($"角色：{persion.Role}");           
        }      
    }


   
}
