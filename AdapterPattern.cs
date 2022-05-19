using System;
using System.Collections.Generic;
using System.Text;

namespace DesignModeDemo
{
    /*
     适配器模式
    定义：功能有了，但是要按照用户想要的样子输出
    特色：转换
    分类：类适配模式(通过继承)、对象适配器模式（内部实例化）
    */


    /*
     举例场景：只有一根安卓充电线，但是要给苹果手机充电
     */



    /// <summary>
    /// 充电线
    /// </summary>
    abstract class OwnChangeLine {
        public  virtual void ChangeLine()
        {
            Console.WriteLine("安卓充电线");
        }

    }

    /// <summary>
    /// 苹果手机
    /// </summary>
    class Iphone {
        /// <summary>
        /// 充电
        /// </summary>
        public void Change()
        {
            Console.WriteLine("给苹果手机充电");
        }
    }

    /// <summary>
    /// 充电线
    /// </summary>
    interface IOwnChangeLine {
        void ChangeLine();
    }



    /// <summary>
    /// 对象适配器
    /// </summary>
    class AdapterManage : OwnChangeLine
    {
        private Iphone iphone = new Iphone();

        /// <summary>
        /// 充电线
        /// </summary>
        public override void ChangeLine()
        {
            iphone.Change();
        }
    }

    /// <summary>
    /// 类适配器
    /// </summary>
    class AdapterManageClass : Iphone, IOwnChangeLine
    {
        /// <summary>
        /// 充电线
        /// </summary>
        public void ChangeLine()
        {
            this.Change();
        }
    }
}
