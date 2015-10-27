using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Model
{
    #region Echo

    enum EchoColor
    {
        VIOLET,
        BLUE,
        GREEN,
        YELLOW,
        ORANGE,
        RED
    };

    struct Echo
    {
        public EchoColor color;
        public float beat;
    };

    #endregion

    #region EchoField

    /// <summary>
    /// This class holds all of the current echos for a level.
    /// </summary>
    class EchoField
    {
        #region Fields

        // List of all outstanding echos.
        List<Echo> echoList;

        // Keeps track of the current beat.
        float currentBeat;

        // Texture for drawing echos.
        Texture2D echoTexture;

        #endregion

        #region Functions

        /// <summary>
        /// Initialization.
        /// </summary>
        /// <param name="texture">Texture for drawing echos.</param>
        public void Initialize(Texture2D texture)
        {
            echoList = new List<Echo>();

            echoTexture = texture;
        }

        /// <summary>
        /// The echo field updates the currentBeat for drawing and
        /// trigger checking purposes.
        /// </summary>
        /// <param name="currentBeat">Beat the song is on.</param>
        public void Update(float currentBeat)
        {
            //nothing now
        }

        /// <summary>
        /// Draws all of the echos based on the current beat.
        /// </summary>
        /// <param name="spriteBatch">SpriteBatch handles drawing.</param>
        public void Draw(SpriteBatch spriteBatch)
        {
            foreach (Echo echo in echoList)
            {
                // pick a draw color based on echo type
                Color color;
                switch(echo.color)
                {
                    case EchoColor.RED:
                        color = Color.Red;
                        break;
                    case EchoColor.ORANGE:
                        color = Color.Orange;
                        break;
                    case EchoColor.YELLOW:
                        color = Color.Yellow;
                        break;
                    case EchoColor.GREEN:
                        color = Color.Green;
                        break;
                    case EchoColor.BLUE:
                        color = Color.Blue;
                        break;
                    case EchoColor.VIOLET:
                        color = Color.Violet;
                        break;
                    default:
                        color = Color.WhiteSmoke;
                        break;
                }

                //then draw!
                //spriteBatch.Draw(echoTexture, new Vector2(50, 50), Color.LightGoldenrodYellow);
            }
        }

        #endregion

    }

    #endregion

}
