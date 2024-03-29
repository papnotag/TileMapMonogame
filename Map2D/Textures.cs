using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map2D
{
    internal class Textures
    {
        public static List<Texture2D> TileTextures = new List<Texture2D>();
        public static void LoadTiles()
        {
            for(int i = 0; i < Directory.GetFiles("Content/Tiles").Length; i++)
            {
                TileTextures.Add(Globals.Content.Load<Texture2D>($"Tiles/{i}"));
            }
        }
        public static int TileSize = 64;
        public static int TileMapRows = 17;
        public static int TileMapCols = 30;
    }
}
