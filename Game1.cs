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
        private Texture2D luigiSpriteSheet;
        private string creditsString = "Credits\nProgram Made By: John Cook\nSprites from: TBD";


        private MovingAnimatedSprite jumpingLuigi = new MovingAnimatedSprite();

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            MovingAnimatedSprite floatingLuigi = new MovingAnimatedSprite();
            floatingLuigi.sourceFileDirectory = "./smb3_luigi_sheet";

            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            MainFont = Content.Load<SpriteFont>("./MainText");
            luigiSpriteSheet = Content.Load<Texture2D>(jumpingLuigi.sourceFileDirectory);
            jumpingLuigi.setFrame1Rectangle(135, 154, 16, 27);
            jumpingLuigi.setFrame2Rectangle(95, 155, 16, 26);
            jumpingLuigi.setFrame2Rectangle(55, 155, 16, 26);
            jumpingLuigi.setPositionRectangle(155,155,16,26);


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