using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace wpf_foxchat.Controls
{
    class Utils
    {
        //====================================================================================
        // Tìm nút đồ họa cha gần nó nhất
        //====================================================================================
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

        //====================================================================================
        // Render một cây đồ họa sang dạng bitmap
        //====================================================================================
        public static RenderTargetBitmap RenderToBitmap(Visual target)
        {
            var bounds = VisualTreeHelper.GetDescendantBounds(target);
            var rtb = new RenderTargetBitmap((int)Math.Round(bounds.Width), (int)Math.Round(bounds.Height), 96.0, 96.0, PixelFormats.Pbgra32);
            var drawingVisual = new DrawingVisual();
            using (DrawingContext drawingContext = drawingVisual.RenderOpen())
            {
                var brush = new VisualBrush(target);
                drawingContext.DrawRectangle(brush, null, new Rect(new Point(), bounds.Size));
            }
            rtb.Render(drawingVisual);
            return rtb;
        }
    }
}
