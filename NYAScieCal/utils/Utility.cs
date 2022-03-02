using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYAScieCal.utils
{
    class Utility
    {


        public Image resizeImage(Image img, int width, int height)
        {
            
            Bitmap new_image = new Bitmap(width, height);
            Graphics g = Graphics.FromImage((Image)new_image);
            g.InterpolationMode = InterpolationMode.High;
            g.DrawImage(img, 0, 0, width, height);
            return new_image;

        }

    }
}
