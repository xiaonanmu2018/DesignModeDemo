using System;
using System.Collections.Generic;
using System.Text;

namespace DesignModeDemo
{
    /*
     代理模式 
    定义：充当中介角色，将真正的调用对象隐藏起来。
    特点：中介
     */

    /*
     举例场景：找房屋中介去买房
     */

    interface ISellers
    {
        /// <summary>
        /// 带去看房
        /// </summary>
        void LeadTheWay();

    }

    /// <summary>
    /// 房东
    /// </summary>
    class Homeowner : ISellers
    {
        public void LeadTheWay()
        {
            Console.WriteLine("带路去看房");
        }
    }

    /// <summary>
    /// 房屋中介
    /// </summary>
    class ProxyHome : ISellers
    {
        Homeowner homeowner = new Homeowner();

        private void Intention()
        {
            Console.WriteLine("有足够资金");
        }
 
        public void LeadTheWay()
        {
            this.Intention();
            homeowner.LeadTheWay();
            this.Contact();
        }

        private void Contact() {
            Console.WriteLine("留下联系方式");
        }
    }




}
