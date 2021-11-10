using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnrenityEngine
{
    public static class PlayerMovement
    {
        public static void MoveRight(int force, PlayerCharacter player, Image runSprite)
        {
            player.Image = runSprite;
            player.Left += force;
            player.Update();
            
        }

        public static void MoveLeft(int force, PlayerCharacter player, Image runSprite)
        {
            player.Image = runSprite;
            player.Left -= force;
            player.Update();
        }

        public static void MoveDown(int force, PlayerCharacter player, Image runSprite)
        {
            player.Image = runSprite;
            player.Top -= force;
            player.Update();
        }
        public static void MoveUp(int force, PlayerCharacter player, Image runSprite)
        {
            player.Image = runSprite;
            player.Top += force;
            player.Update();
        }
    }
}
