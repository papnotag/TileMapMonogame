using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.IO;

namespace Map2D
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;

        TileMap tileMap;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = Globals.mouseVisible;
            _graphics.PreferredBackBufferWidth = Globals.WIDTH;
            _graphics.PreferredBackBufferHeight = Globals.HEIGHT;
            _graphics.IsFullScreen = Globals.fullScreen;
        }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            Globals.sb = new SpriteBatch(GraphicsDevice);
            Globals.Content = Content;
            Textures.LoadTiles();
            tileMap = new TileMap();
            string map = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Content/Maps/Map1.txt"));
            tileMap.ConvertTileMap(map);
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Globals.BGCOLOR);

            Globals.sb.Begin();

            tileMap.Draw();

            Globals.sb.End();

            base.Draw(gameTime);
        }
    }
}
