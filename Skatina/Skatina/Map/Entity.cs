﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skatina
{
    public class Entity
    {
        public Texture2D Texture;
        public Rectangle Rectangle;
        public Vector2 Position;

        public bool Gravity;
        public bool IsOnTopOfEntity;
        public bool IsOnRightOfEntity;
        public bool IsOnLeftOfEntity;
        public bool Visible;

        public Entity(Vector2 position)
        {
            Position = new Vector2(position.X, position.Y);
            Rectangle = new Rectangle((int)Position.X, (int)Position.Y, 0, 0);

            Gravity = true;
            IsOnTopOfEntity = false;
            IsOnRightOfEntity = false;
            IsOnLeftOfEntity = false;
            Visible = true;
        }

        public virtual void SetPosition(Vector2 position)
        {
            Position = new Vector2(position.X, position.Y);
        }

        public virtual void Fall()
        {
            SetPosition(new Vector2(Position.X, Position.Y + 5f));
        }

        public bool IsOnTopFloor(Entity[,] entities)
        {
            foreach (Entity entity in entities)
            {
                if (Rectangle.Intersects(entity.Rectangle) && entity.Visible && entity is Floor)
                {
                    if (Rectangle.Bottom >= entity.Rectangle.Top && Rectangle.Top - Rectangle.Height / 2 <= entity.Rectangle.Bottom)
                    {
                        if ((Rectangle.Left >= entity.Rectangle.Left && Rectangle.Left <= entity.Rectangle.Right) ||
                            (Rectangle.Right <= entity.Rectangle.Right && Rectangle.Right >= entity.Rectangle.Left))
                        {
                            IsOnTopOfEntity = true;
                            return true;
                        }
                    }
                }
            }
            IsOnTopOfEntity = false;
            return false;
        }

        public bool IsOnRightSideWall(Entity[,] entities)
        {
            foreach (Entity entity in entities)
            {
                if (Rectangle.Intersects(entity.Rectangle) && entity.Visible && entity is Wall)
                {
                    if (Rectangle.Bottom >= entity.Rectangle.Top && Rectangle.Top <= entity.Rectangle.Bottom)
                    {
                        if (Rectangle.Right >= entity.Rectangle.Left && Rectangle.Left <= entity.Rectangle.Left)
                        {
                            IsOnRightOfEntity = true;
                            return true;
                        }
                    }
                }
            }
            IsOnRightOfEntity = false;
            return false;
        }

        public bool IsOnLeftSideWall(Entity[,] entities)
        {
            foreach (Entity entity in entities)
            {
                if (Rectangle.Intersects(entity.Rectangle) && entity.Visible && entity is Wall)
                {
                    if (Rectangle.Bottom >= entity.Rectangle.Top && Rectangle.Top <= entity.Rectangle.Bottom)
                    {
                        if (Rectangle.Left <= entity.Rectangle.Right && Rectangle.Right >= entity.Rectangle.Right)
                        {
                            IsOnLeftOfEntity = true;
                            return true;
                        }
                    }
                }
            }
            IsOnLeftOfEntity = false;
            return false;
        }

        public virtual void LoadContent(ContentManager content)
        {

        }

        public virtual void Update(GameTime gametime, Map map)
        {
            Rectangle = new Rectangle((int)Position.X, (int)Position.Y, Rectangle.Width, Rectangle.Height);

            if (Gravity)
            {
                if (!IsOnTopFloor(map.Levels[map.CurrentLevelIndex].LevelEntities))
                    Fall();
            }
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            if(Visible)
                spriteBatch.Draw(Texture, Rectangle, Color.White);
        }
    }
}
