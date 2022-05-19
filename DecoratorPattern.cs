using System;
using System.Collections.Generic;
using System.Text;

namespace DesignModeDemo
{
    /// <summary>
    /// 装饰器模式
    /// 定义：给一个类增加一些修饰的东西，不改变原来类里面原有的东西
    /// 特点：拓展
    /// </summary>


    /*
     举例场景：介绍一个公司
     */

    interface ICompany
    {
        string Introduct();
    }

    class Company : ICompany
    {
       public string Introduct()
        {          
            return "并行科技";       
        }

    }

    class CompanyName : ICompany
    {
        private ICompany _company;
        public CompanyName(ICompany company)
        {
            _company = company;
        }

        public string Introduct()
        {
            var r= _company.Introduct();
            r+=" 长沙分公司";
            return r;
        }
    }

   

    class CompanyAddress : ICompany
    {
        private ICompany _company;
        public CompanyAddress(ICompany company)
        {
            _company = company;
        }

        public string Introduct()
        {
            var r = _company.Introduct();
            r += " 岳麓区中南科技研发产业园";
            return r;   
        }

    }


}
