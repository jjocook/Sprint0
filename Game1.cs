using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace Sprint0
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch spriteBatch;
        private SpriteFont MainFont;
        private Texture2D genericSprite;
        private string creditsString = "Credits\nProgram Made By: John Cook\nSprites from: TBD";
        private Rectangle luigiSpriteBox = new Rectangle(0, 0, 75, 75);
        private static int spriteSheetNavigationConstant = 40; // accurate for about the first 4 rows of the luigi sheet
        private int spriteSheetX = spriteSheetNavigationConstant * 1;
        private int spriteSheetY = spriteSheetNavigationConstant * 3;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            MainFont = Content.Load<SpriteFont>("./MainText");
            genericSprite = Content.Load<Texture2D>("./smb3_luigi_sheet");
            

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime) //Update game state information here
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime) //Update screen state here
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();

            spriteBatch.DrawString(MainFont, creditsString, new Vector2(200, 400), Color.Black);
            spriteBatch.Draw(genericSprite, luigiSpriteBox, new Rectangle(spriteSheetX, spriteSheetY, 32, 32), Color.White);

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}