using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ChiecNonKyDIeu.xuly
{
    class cls_VongQuay
    {
        public static Bitmap xoayvong(Image image,PointF offset,float goc)
        {
            if(image ==null)
            {
                throw new ArgumentNullException("image");
            }
            //tao bitmap moi de luu hinh anh xoay
            Bitmap xoaybitmap = new Bitmap(image.Width, image.Height);
            xoaybitmap.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            //tao doi tuong do hoa tu bitmap trong
            Graphics v = Graphics.FromImage(xoaybitmap);

            //Dat diem xoay o giua diem anh
            v.TranslateTransform(offset.X, offset.Y);

            //xoayhinhanh
            v.RotateTransform(goc);

            //di chuyen hinh anh tro lai
            v.TranslateTransform(-offset.X, -offset.Y);

            //ve qua hinh anh vao doi tuong do hoa
            v.DrawImage(image, new PointF(0, 0));

            return xoaybitmap;
        }
    }
}
