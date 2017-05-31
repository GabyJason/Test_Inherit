using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Inherit
{
    class Program
    {
        static void Main(string[] args)
        {
            //繼承者類別
            Heir heir = new Heir();
            //呼叫繼承者的變數
            heir.name = "Gaby";
            heir.money = 10000000;

            heir.View();
            //呼叫繼承者的方法
            heir.Func();

            Abs abs = new Abs();
            abs.Func();
        }
        /// <summary>
        /// 被繼承者
        /// </summary>
        public class BeHeir
        {
            public string name;
            public int money;
            //建立方法
            public void View()
            {
                Console.WriteLine("姓名 :" + name);
                Console.WriteLine("金額 :" + money);
            }
        }
        /// <summary>
        /// 繼承者
        /// 若繼承者類別為非公開，為 sealed 時，其他皆無法繼承該類別
        /// </summary>
        public class Heir : BeHeir
        {
            //繼承被繼承的功能，所以此時已有被繼承的功能
            //擴充其他功能
            public virtual void Func()
            {
                Console.WriteLine("我是繼承者");
            }
        }

        /// <summary>
        /// 複寫繼承者(若被繼承者virtual便可以複寫override)
        /// </summary>
        public class Abs : Heir {
            public override void Func()
            {
                Console.WriteLine("複寫繼承者");
            }
        }
      

    }
}
