using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnrenityEngine
{
    public class PlayerCharacter : PictureBox
    {
        private static PictureBox player = new PictureBox();
        public Image playerSprite
        {
            get;
            set;
        }

        public int playerWidth
        {
            get;
            set;
        }

        public int playerHeight
        {
            get;
            set;
        }

        public int playerTopStart
        {
            get;
            set;
        }

        public int playerLeftStart
        {
            get;
            set;
        }

        public PictureBoxSizeMode mode
        {
            get;
            set;
        }


        public void Compile(Form window)
        {
            Height = playerHeight;
            Width = playerWidth;
            Image = playerSprite;
            Top = playerTopStart;
            Left = playerLeftStart;
            SizeMode = mode;
            Tag = "Unrenity.Player";
            window.Controls.Add(this);
        }

    
    }
}
