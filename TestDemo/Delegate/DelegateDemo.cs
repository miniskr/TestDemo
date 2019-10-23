using System;
using System.Collections.Generic;
using System.Text;

namespace TestDemo.Delegate
{
    public class DelegateDemo
    {
        //! 第一步： 定义委托（委托与类同等级别，可以定义类的地方就可以定义委托）

        delegate double TowLongOp(long first, long second);

    }

    public delegate string GetAString(string format);

}
