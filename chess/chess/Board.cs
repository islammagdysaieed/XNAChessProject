using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace chess
{
    public class Board
    {
        #region static fields

        public static int Y_Offset = 85;
        public static int X_Offset = 75;
        public static int Unit_Length = 62;

        #endregion

        #region fields and properties
        public Unit[,] Board_Cell;  // make it private with makemove() function

        private Texture2D Board_Texture
        {
            get { return GHelper.content.Load<Texture2D>("InnerGame/Checkmate"); }
        }
        private Rectangle Board_Rectangle
        {
            get { return new Rectangle(0, 0, Board_Texture.Width, Board_Texture.Height); }
        }

        #endregion

        public Board()
        {
            this.Board_Cell = new Unit[8, 8];
            this.initialize();
        }

        private void initialize()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
////////////////////      set black pieces            
                    if (i == 1)
                        this.Board_Cell[i, j] = new Unit("BPawn", new Vector2(i, j), 1);

                    else if (i == 0)
                    {
                        if(j ==0 || j == 7)
                            this.Board_Cell[i, j] = new Unit("BRook", new Vector2(i, j), 3);
                        else if(j == 1 || j == 6)
                            this.Board_Cell[i, j] = new Unit("Bknight", new Vector2(i, j), 4);
                        else if(j == 2 || j == 5)
                            this.Board_Cell[i, j] = new Unit("BBishop", new Vector2(i, j), 5);
                        else if(j == 3)
                            this.Board_Cell[i, j] = new Unit("BQueen", new Vector2(i, j), 8);
                        else
                            this.Board_Cell[i, j] = new Unit("BKing", new Vector2(i, j), 10);
                    }
////////////////////
////////////////////      set White pieces
                    else  if (i == 6)
                        this.Board_Cell[i, j] = new Unit("WPawn", new Vector2(i, j), 1);

                    else if (i == 7)
                    {
                        if (j == 0 || j == 7)
                            this.Board_Cell[i, j] = new Unit("WRook", new Vector2(i, j), 3);
                        else if (j == 1 || j == 6)
                            this.Board_Cell[i, j] = new Unit("Wknight", new Vector2(i, j), 4);
                        else if (j == 2 || j == 5)
                            this.Board_Cell[i, j] = new Unit("WBishop", new Vector2(i, j), 5);
                        else if (j == 3)
                            this.Board_Cell[i, j] = new Unit("WQueen", new Vector2(i, j), 8);
                        else
                            this.Board_Cell[i, j] = new Unit("WKing", new Vector2(i, j), 10);
                    }
///////////////////
                    else
                     this.Board_Cell[i, j] = new Unit("nothing", new Vector2(i, j), 0);

                }
            }
        }

        public void Draw()
        {
            GHelper.spritebatch.Draw(this.Board_Texture, this.Board_Rectangle, Color.White);

            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                    this.Board_Cell[i, j].Draw();

        }
    }
}