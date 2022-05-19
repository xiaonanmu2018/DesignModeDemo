using System;
using System.Collections.Generic;
using System.Text;

namespace DesignModeDemo
{
    /*
    组合模式
    定义：组合多个对象形成树形结构，以表示具有“整体-部分”关系的层次结构。
    特点：组合
     */

    /*
     举例场景：系统目录的树形结构
     */


    //抽象组件类
    public abstract class Node {

        protected string Name { get; set; }
        protected List<Node> NodeList { get; set; }       
        public abstract void AddChild(Node c);
        public Node(string name) {
            Name = name;
            Console.WriteLine(name);
            NodeList = new List<Node>();
        } 
    }

    //子组件类
    public class DirectoryNode : Node
    {
        public DirectoryNode(string name):base(name) { 
        
        }
        public override void AddChild(Node c)
        {
            return;
        }
    }

    //容器组件类
    public class ContainerNode : Node
    {
        public ContainerNode(string name) : base(name)
        {

        }
        public override void AddChild(Node c)
        {
            NodeList.Add(c);
        }
    }

}
