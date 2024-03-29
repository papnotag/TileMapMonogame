using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map2D
{
    internal class Tile
    {
        int x, y, w, h;
        Rectangle rect;
        Texture2D texture;

        public Tile(int x, int y, Texture2D texture)
        {
            this.x = x;
            this.y = y;
            this.texture = texture;
            this.w = texture.Width;
            this.h = texture.Height;
            this.rect = new Rectangle(x, y, w, h);
        }

        public void ChangeTexture(Texture2D texture)
        {
            this.texture = texture;
        }

        public void Draw()
        {
            Globals.sb.Draw(texture, rect, Color.White);
        }
    }
}
