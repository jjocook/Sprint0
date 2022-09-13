using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;

namespace Sprint0
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch spriteBatch;
        private SpriteFont MainFont;
        private string creditsString = "Credits\nProgram Made By: John Cook\nSprites from: https://www.mariomayhem.com/downloads/sprites/super_mario_bros_3_sprites.php";

        /*Declaration of controllers*/
        private KeyboardController keyboardController = new KeyboardController();
        private MouseController mouseController = new MouseController();    

        /*Declaration of needed sprites*/
        private MovingAnimatedSprite jumpingLuigi = new MovingAnimatedSprite();
        private StationaryAnimatedSprite animatedLuigi = new StationaryAnimatedSprite();
        private MovingStaticSprite floatingLuigi = new MovingStaticSprite();
        private StationaryStaticSprite standingLuigi = new StationaryStaticSprite();
        private TextSprite textSprite = new TextSprite();


        private HashSet<ISprite> spritesToDraw = new HashSet<ISprite>();

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

            textSprite.setFont(Content.Load<SpriteFont>("./MainText"));

            jumpingLuigi.loadSpriteSheet(Content.Load<Texture2D>("./smb3_luigi_sheet"));
            jumpingLuigi.setFrame1Rectangle(135, 154, 16, 27);
            jumpingLuigi.setFrame2Rectangle(95, 155, 16, 26);
            jumpingLuigi.setFrame3Rectangle(55, 155, 16, 26);
            jumpingLuigi.setPositionRectangle(400,200,16,27);

            animatedLuigi.loadSpriteSheet(Content.Load<Texture2D>("./smb3_luigi_sheet"));
            animatedLuigi.setFrame1Rectangle(166, 474, 34, 27);
            animatedLuigi.setFrame2Rectangle(355, 394, 16, 28);
            animatedLuigi.setFrame3Rectangle(206, 474, 34, 27);
            animatedLuigi.setPositionRectangle(400, 200, 16, 28);

            floatingLuigi.loadSpriteSheet(Content.Load<Texture2D>("./smb3_luigi_sheet"));
            floatingLuigi.setFrameRectangle(291, 474, 23, 28);
            floatingLuigi.setPositionRectangle(400, 200, 16, 28);

            standingLuigi.loadSpriteSheet(Content.Load<Texture2D>("./smb3_luigi_sheet"));
            standingLuigi.setFrameRectangle(15, 194, 16, 27);
            standingLuigi.setPositionRectangle(400, 200, 16, 27);


            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime) //Update game state information here
        {
            

            // TODO: Add your update logic here

            keyboardController.update();
            mouseController.update();

            if (keyboardController.lastInputTime >= mouseController.lastInputTime)
            {

                switch (keyboardController.getLastPressed())
                {
                    case 4:
                        jumpingLuigi.updateCurrentFrame(gameTime);
                        spritesToDraw.Add(jumpingLuigi);
                        break;

                    case 3:
                        floatingLuigi.updateCurrentFrame(gameTime);
                        spritesToDraw.Add(floatingLuigi);
                        break;

                    case 2:
                        animatedLuigi.updateCurrentFrame(gameTime);
                        spritesToDraw.Add(animatedLuigi);
                        break;

                    case 1:
                        standingLuigi.updateCurrentFrame(gameTime);
                        spritesToDraw.Add(standingLuigi);
                        break;

                    case 0:
                        Exit();
                        break;
                    default:
                        standingLuigi.updateCurrentFrame(gameTime);
                        spritesToDraw.Add(standingLuigi);
                        break;
                }

            }
            else
            {

                switch (mouseController.getLastPressed())
                {
                    case 4:
                        jumpingLuigi.updateCurrentFrame(gameTime);
                        spritesToDraw.Add(jumpingLuigi);

                        break;

                    case 3:
                        floatingLuigi.updateCurrentFrame(gameTime);
                        spritesToDraw.Add(floatingLuigi);
                        break;

                    case 2:
                        animatedLuigi.updateCurrentFrame(gameTime);
                        spritesToDraw.Add(animatedLuigi);
                        break;

                    case 1:
                        standingLuigi.updateCurrentFrame(gameTime);
                        spritesToDraw.Add(standingLuigi);
                        break;

                    case 0:
                        Exit();
                        break;
                    default:
                        standingLuigi.updateCurrentFrame(gameTime);
                        spritesToDraw.Add(standingLuigi);
                        break;
                }
            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime) //Update screen state here
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();

            textSprite.setText(creditsString);
            textSprite.setPosition(100, 400);
            spritesToDraw.Add(textSprite);

            foreach (var item in spritesToDraw)
            {
                item.draw(spriteBatch);
            }

            spritesToDraw.Clear();

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}