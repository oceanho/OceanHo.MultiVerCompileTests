using System;
using System.Collections.Generic;
using System.Text;

/****** Care here namespace *************/
namespace System.Runtime.CompilerServices
{
	/// <summary>
	/// 为 .NET 2.0 定义一个扩展方法的支持标记类,在不引用升级 .NET 到 3.5 与引用.NET 3.5 程序集的情况下可以支持静态方法扩展
	/// </summary>
	[AttributeUsage( AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Method )]
	public sealed class ExtensionAttribute : Attribute
	{
	}
}
