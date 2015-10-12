/***************************************************************
*       
* add by OceanHo 2015/10/12 11:44:51
*
****************************************************************/

using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
    /// <summary>
    /// 定义一个.NET 3.5 中才定义的 委托名为 Func 的委托对象（注意哦，这里的程序集.NET framework版本是 2.0）
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="TResult"></typeparam>
    /// <param name="arg"></param>
    /// <returns></returns>
   public delegate TResult Func<in T,out TResult>(T arg);
}
