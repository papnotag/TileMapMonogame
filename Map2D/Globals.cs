using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map2D
{
    internal class Globals
    {
        public static int WIDTH = 1920;
        public static int HEIGHT = 1080;
        public static bool fullScreen = true;
        public static bool mouseVisible = false;
        public static Color BGCOLOR = Color.Black;

        public static SpriteBatch sb;
        public static ContentManager Content;
    }
}
