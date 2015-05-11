using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace chess
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        //Unit U1;
        //Texture2D BT;
        //Rectangle BR;
        Board B1;
        public Game1()
        {
            //Window SIZE AND properties
            GHelper.graphics = new GraphicsDeviceManager(this);
            GHelper.graphics.PreferredBackBufferHeight = 647;
            GHelper.graphics.PreferredBackBufferWidth = 1152;
            IsMouseVisible = true;
            //initialize the static contentmanger
            Content.RootDirectory = "Content";
            GHelper.content = Content;
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            //U1 = new Unit("WBishop", new Vector2(7, 1), 5);
            B1 = new Board();
            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a static SpriteBatch, which can be used to draw textures.
           GHelper.spritebatch = new SpriteBatch(GraphicsDevice);
         //  BT = GHelper.content.Load<Texture2D>("InnerGame/Checkmate");
          // BR = new Rectangle(0, 0, BT.Width, BT.Height);

            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            GHelper.spritebatch.Begin();
        //    GHelper.spritebatch.Draw(BT, BR, Color.White);
          //  U1.Draw();
              B1.Draw();
            GHelper.spritebatch.End();
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
