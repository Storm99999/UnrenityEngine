using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnrenityEngine
{
    public class Object
    {
        public Image objSprite
        {
            get;
            set;
        }

        public int objWidth
        {
            get;
            set;
        }

        public int objHeight
        {
            get;
            set;
        }

        public int objTopStart
        {
            get;
            set;
        }

        public int objLeftStart
        {
            get;
            set;
        }

        public void Compile(PictureBoxSizeMode mode, Form window)
        {
            PictureBox obj = new PictureBox();
            obj.Height = objHeight;
            obj.Width = objWidth;
            obj.Image = objSprite;
            obj.Top = objTopStart;
            obj.Left = objLeftStart;
            obj.SizeMode = mode;
            window.Controls.Add(obj);
        }
    }
}
