using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace wpf_foxchat.Controls
{
    class Utils
    {
        public static T FindParent<T>(DependencyObject dependencyObject) where T : DependencyObject
        {
            var parent = LogicalTreeHelper.GetParent(dependencyObject);

            if (parent == null) return null;

            var parentT = parent as T;
            return parentT ?? FindParent<T>(parent);
        }

        //public static T FindChidren<T>(DependencyObject dependencyObject) where T : DependencyObject
        //{
        //    var chid = LogicalTreeHelper.GetChildren(dependencyObject);

        //    if (parent == null) return null;

        //    var parentT = parent as T;
        //    return parentT ?? FindChidren<T>(parent);
        //}


        //  Test
    }
}
