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
    public class Unit
    {
        #region fields 
        private string name;
        private int val;
        private Vector2 position;  // 8*8
        private int cellnumber;  // 0 ->63
        private Texture2D unit_texture;
        private Rectangle unit_rectangle;
        
        #endregion
        #region properties
        public string Name { set { name = value; } get { return name; } }
        private int Value
        {
            set
            {
                if (value < 0)
                    throw new Exception("wrong piece value");
                else
                    val = value;
            }
            get { return val;}
        }
        private int Cellnumber
        {
            set
            {
                if (value < 0 || value > 63)
                    throw new Exception("wrong piece value");
                else
                    cellnumber = value;
            }
            get { return cellnumber; }
        }
        private Vector2 Position
        {
          set
          { 
              if ((value.X >= 0 && value.X < 8) && (value.Y >= 0 && value.Y < 8))
                  this.position = value;
              
              else throw new Exception("Faild to set postion");
          }
          get{ return this.position;}
        }
        #endregion

       #region constractor and methods
        public Unit(string Name,Vector2 Pos,int Val )
        {
            this.Name = Name;
            this.Position = Pos;
            this.Value = Val;
            this.unit_rectangle = new Rectangle(Board.Y_Offset + (Board.Unit_Length * (int)this.Position.Y),
                Board.X_Offset + (Board.Unit_Length * (int)this.Position.X), Board.Unit_Length, Board.Unit_Length); //-10 for offset
            load();
        }

        private void load()
        {  
           

            switch (this.Name)
            {
              //black pieces
                case "BKing":
                    this.unit_texture = GHelper.content.Load<Texture2D>("InnerGame/units/BKing"); break;
                case "BQueen":
                    this.unit_texture = GHelper.content.Load<Texture2D>("InnerGame/units/BQueen"); break;
                case "BBishop":
                    this.unit_texture = GHelper.content.Load<Texture2D>("InnerGame/units/BBishop"); break;
                case "Bknight":
                    this.unit_texture = GHelper.content.Load<Texture2D>("InnerGame/units/Bknight"); break;
                case "BRook":
                    this.unit_texture = GHelper.content.Load<Texture2D>("InnerGame/units/BRook"); break;
                case "BPawn":
                    this.unit_texture = GHelper.content.Load<Texture2D>("InnerGame/units/BPawn"); break;
                //white pieces
                case "WKing":
                    this.unit_texture = GHelper.content.Load<Texture2D>("InnerGame/units/WKing"); break;
                case "WQueen":
                    this.unit_texture = GHelper.content.Load<Texture2D>("InnerGame/units/WQueen"); break;
                case "WBishop":
                    this.unit_texture = GHelper.content.Load<Texture2D>("InnerGame/units/WBishop"); break;
                case "Wknight":
                    this.unit_texture = GHelper.content.Load<Texture2D>("InnerGame/units/Wknight"); break;
                case "WRook":
                    this.unit_texture = GHelper.content.Load<Texture2D>("InnerGame/units/WRook"); break;
                case "WPawn":
                    this.unit_texture = GHelper.content.Load<Texture2D>("InnerGame/units/WPawn"); break;
                default:
                    this.unit_texture = GHelper.content.Load<Texture2D>("InnerGame/units/nothing"); break;
            }

        }

        public void Draw()
        {
            GHelper.spritebatch.Draw(this.unit_texture, this.unit_rectangle, Color.White);
        }

        #endregion 
    }

}
