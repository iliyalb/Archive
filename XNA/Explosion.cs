using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace SelectionInGames
{
    /// <summary>
    /// An animated explosion object
    /// </summary>
    public class Explosion
    {
        #region Fields

        // object location
        Rectangle drawRectangle;

        // animation strip info
        const string STRIP_NAME = "explosion";
        Texture2D strip;
        int frameWidth;
        int frameHeight;

        // hard-coded animation info. There are better ways to do this,
        // we just don't know enough to use them yet
        const int FRAMES_PER_ROW = 3;
        const int NUM_ROWS = 3;
        const int NUM_FRAMES = 9;

        // fields used to track and draw animations
        Rectangle sourceRectangle;
        int currentFrame;
        const int FRAME_TIME = 10;
        int elapsedFrameTime = 0;

        // playing or not
        bool playing = false;

        #endregion

        #region Constructors

        /// <summary>
        /// Constructs a new explosion object
        /// </summary>
        /// <param name="contentManager">the content manager</param>
        public Explosion(ContentManager contentManager)
        {
            // initialize animation to start at frame 0
            currentFrame = 0;

            LoadContent(contentManager);
        }

        #endregion

        #region Public methods

        /// <summary>
        /// Updates the explosion. This only has an effect if the explosion animation is playing
        /// </summary>
        /// <param name="gameTime">the game time</param>
        public void Update(GameTime gameTime)
        {
            if (playing)
            {
                // check for advancing animation frame
                elapsedFrameTime += gameTime.ElapsedGameTime.Milliseconds;
                if (elapsedFrameTime > FRAME_TIME)
                {
                    // reset frame timer
                    elapsedFrameTime = 0;

                    // advance the animation
                    if (currentFrame < NUM_FRAMES - 1)
                    {
                        currentFrame++;
                        SetSourceRectangleLocation(currentFrame);
                    }
                    else
                    {
                        // reached the end of the animation
                        playing = false;
                    }
                }
            }
        }

        /// <summary>
        /// Draws the explosion. This only has an effect if the explosion animation is playing
        /// </summary>
        /// <param name="spriteBatch">the spritebatch</param>
        public void Draw(SpriteBatch spriteBatch)
        {
            if (playing)
            {
                spriteBatch.Draw(strip, drawRectangle, sourceRectangle, Color.White);
            }
        }

        /// <summary>
        /// Starts playing the animation for the explosion
        /// </summary>
        /// <param name="x">the x location of the center of the explosion</param>
        /// <param name="y">the y location of the center of the explosion</param>
        public void Play(int x, int y)
        {
            // reset tracking values
            playing = true;
            elapsedFrameTime = 0;
            currentFrame = 0;

            // set draw location and source rectangle
            drawRectangle.X = x - drawRectangle.Width / 2;
            drawRectangle.Y = y - drawRectangle.Height / 2;
            SetSourceRectangleLocation(currentFrame);
        }

        #endregion

        #region Private methods

        /// <summary>
        /// Loads the content for the explosion
        /// </summary>
        /// <param name="contentManager">the content manager</param>
        private void LoadContent(ContentManager contentManager)
        {
            // load the animation strip
            strip = contentManager.Load<Texture2D>(STRIP_NAME);

            // calculate frame size
            frameWidth = strip.Width / FRAMES_PER_ROW;
            frameHeight = strip.Height / NUM_ROWS;

            // set initial draw and source rectangles
            drawRectangle = new Rectangle(0, 0, frameWidth, frameHeight);
            sourceRectangle = new Rectangle(0, 0, frameWidth, frameHeight);
        }

        /// <summary>
        /// Sets the source rectangle location to correspond with the given frame
        /// </summary>
        /// <param name="frameNumber">the frame number</param>
        private void SetSourceRectangleLocation(int frameNumber)
        {
            // calculate X and Y based on frame number
            sourceRectangle.X = (frameNumber % FRAMES_PER_ROW) * frameWidth;
            sourceRectangle.Y = (frameNumber / FRAMES_PER_ROW) * frameHeight;
        }

        #endregion
 
    }
}
