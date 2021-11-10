using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnrenityEngine
{
    public static class Keyboard
    {
        public static bool IsKeyPressed(KeyEventArgs e, Keys key)
        {
            if (e.KeyCode == key)
            {
                return true;
            }
            return false;
        }
    }
}
