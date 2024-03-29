using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map2D
{
    internal class TileMap
    {
        Tile[,] tiles;
        public TileMap() {
            tiles = new Tile[Textures.TileMapRows, Textures.TileMapCols];
            for(int i = 0; i < Textures.TileMapRows; i++)
            {
                for(int j = 0; j < Textures.TileMapCols; j++)
                {
                    tiles[i, j] = new(j*Textures.TileSize, i*Textures.TileSize, Textures.TileTextures[(int)ETexture.Blank]);
                }
            }
        }
        public void ConvertTileMap(string tmapstring)
        {
            bool lastWasNumber = false;
            int col = 0, row = 0;
            foreach(char c in tmapstring)
            {
                if(Char.IsNumber(c))
                {
                    tiles[row, col] = new(col * 64, row * 64, Textures.TileTextures[(int)c-'0']);
                    if(col < Textures.TileMapCols-1) col++;
                    lastWasNumber = true;
                } else if(lastWasNumber)
                {
                    row++;
                    col = 0;
                    lastWasNumber = false;
                }
            }
        }
        public void Draw()
        {
            for( int i = 0; i < Textures.TileMapRows; i++)
            {
                for(int j = 0; j < Textures.TileMapCols; j++)
                {
                    tiles[i, j].Draw();
                }
            }
        }
    }
}
