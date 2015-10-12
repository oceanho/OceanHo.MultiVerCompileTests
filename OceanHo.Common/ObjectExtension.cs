using System;
using System.Collections.Generic;

#if !NET20              // 在OceanHo.CommonNET20项目定义的“条件编译符号”，这里用上了哦~
using System.Linq;
#endif
using System.Text;

namespace OceanHo.Common
{
    public static class ObjectExtension
    {
        /// <summary>
        /// 定义一个静态扩展方法，将IList&lt;Object&gt;转换为IList&lt;T&gt;对象
        /// </summary>
        /// <typeparam name="T">转换目标对象T</typeparam>
        /// <param name="args">静态方法扩展转换源对象</param>
        /// <exception cref="System.FormatException"></exception>
        /// <returns></returns>
        public static IList<T> AsTDigit<T>(this IList<object> args) where T : struct
        {
            return args.AsTDigit<T>(new Func<object, T>((t) => { return AsT<T>(t); }));
        }

        /// <summary>
        /// 定义一个静态扩展方法，该方法支持调用自定义的委托方法handler.将IList&lt;Object&gt;转换为IList&lt;T&gt;对象
        /// </summary>
        /// <typeparam name="T">转换目标对象T</typeparam>
        /// <param name="args">静态方法扩展转换源对象</param>
        /// <param name="handler">转换调用的自定义委托方法</param>
        /// <exception cref="System.FormatException"></exception>
        /// <returns></returns>
        public static IList<T> AsTDigit<T>(this IList<object> args, Func<object, T> handler) where T : struct
        {
            List<T> list = new List<T>();
            foreach (string item in args)
                list.Add(handler(item));
            return list;
        }

        public static T AsT<T>(object t) where T : struct
        {
            try
            {
                return (T)Convert.ChangeType(t, typeof(T));
            }
            catch
            {
                throw;
            }
        }
    }
}
