﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skatina
{
    public class Map
    {
        public int CurrentLevelIndex;
        public Level[] Levels;

        public Map()
        {
            Levels = new Level[4];
            CurrentLevelIndex = 3;
            Load();
        }

        public void Load()
        {
            Levels[0] = new Level(new string[,] {
                {" "," "," "," "," "," "," "," "," "," "," "," "," "," "," ", " ", " "},
                {" "," "," "," "," "," "," "," "," "," "," "," "," "," "," ", " ", " "},
                {" "," "," "," "," "," "," "," "," "," "," "," "," "," "," ", " ", " "},
                {" "," "," "," "," "," "," "," "," "," "," "," "," "," "," ", " ", " "},
                {" "," "," "," "," "," "," "," "," "," "," "," "," "," "," ", " ", " "},
                {" "," "," "," "," "," "," "," "," "," "," "," "," "," "," ", " ", " "},
                {"_","_","_","|d","_","_","^|vL","_"," "," "," "," "," "," "," ", " ", " "},
                {" "," "," "," "," "," "," "," ","|"," "," "," "," "," "," ", " ", " "},
                {" "," "," "," "," "," "," "," ","|"," ","_"," "," "," "," ", " ", " "},
                {" "," "," "," "," "," "," "," ","|"," ","_","^|vd"," "," "," ", " ", " "},
                {" "," "," "," "," "," "," "," "," ","_","_"," "," ","<_>"," ", " ", "_f"},
                {" "," "," "," "," "," "," "," "," "," "," "," "," "," "," ", " ", " "},
                {" "," "," "," "," "," "," "," "," "," "," "," "," "," "," ", " ", " "},
                {" "," "," "," "," "," "," "," "," "," "," "," "," "," "," ", " ", " "},
                {" "," "," "," "," "," "," "," "," "," "," "," "," "," "," ", " ", " "},
                {" "," "," "," "," "," "," "," "," "," "," "," "," "," "," ", " ", " "},
                {" "," "," "," "," "," "," "," "," "," "," "," "," "," "," ", " ", " "}
                });
            Levels[0].LoadLevel();

            Levels[1] = new Level(new string[,] {
                {" "," "," "," "," "," "," "," "," "," "," "," "," "," "," ", " ", " "},
                {" "," "," "," "," "," "," "," "," "," "," "," "," "," "," ", " ", " "},
                {" "," "," "," "," "," "," "," "," "," "," "," "," "," "," ", " ", " "},
                {" "," "," "," "," "," "," "," "," "," "," "," "," "," "," ", " ", " "},
                {" "," "," "," "," "," "," "," "," "," "," "," "," "," "," ", " ", " "},
                {" "," "," "," "," "," "," "," "," "," "," "," "," "," ","^|vdL", " ", " "},
                {"_","_","_"," ","_","_"," ","_"," "," "," "," "," "," ","^|vdL", " ", " "},
                {" "," "," "," "," "," "," "," "," "," "," ","_","<_>"," "," ", " ", " "},
                {" "," "," ","_"," ","_"," "," "," "," ","_"," "," "," "," ", " ", " "},
                {" "," "," "," "," "," "," "," "," ","_"," ","^|vdL","_","^|vdL"," ", " ", " "},
                {" "," "," "," "," ","_","|"," "," ","_"," "," "," "," ","^|vdL", " ", " "},
                {" "," "," "," "," "," ","|"," "," "," "," "," "," "," "," ", " ", " "},
                {" "," "," "," ","_"," "," "," "," "," "," "," "," "," "," ", " ", " "},
                {" "," "," "," "," ","_","_"," ","<_>"," ","<_>"," "," ","^|vdL"," ", " ", " "},
                {" "," "," "," "," "," "," "," "," "," "," "," "," ","_"," ", " ", " "},
                {" "," "," "," "," "," "," "," "," "," "," "," "," "," ","|", " ", " "},
                {" "," "," "," "," "," "," "," "," "," "," "," "," "," "," ", "_f", " "}
                });
            Levels[1].LoadLevel();

            Levels[2] = new Level(new string[,] {
                {" ","|d"," "," "," "," "," "," "," "," "," "," "," "," "," ", " ", " "},
                {" ","|d"," "," "," "," "," "," "," "," "," "," "," "," "," ", " ", " "},
                {" ","|d"," "," "," "," "," "," "," "," "," "," "," "," "," ", " ", " "},
                {" ","|d"," "," "," "," "," "," "," "," "," "," "," "," "," ", " ", " "},
                {" "," "," "," "," "," "," "," ","|d"," ","^|vdL"," "," "," "," ", " ", " "},
                {" "," "," "," "," "," "," "," ","|d"," "," "," "," "," "," ", " ", " "},
                {"_"," ","_"," ","^_^","^_^"," ","_","|d"," ","^|vdL"," "," "," "," ", " ", " "},
                {" "," "," "," "," "," "," "," ","|d"," "," "," "," "," "," ", " ", " "},
                {" "," "," "," "," "," "," ","_","|d"," ","^|vdL"," "," "," "," ", " ", "_f"},
                {" "," "," "," "," "," "," "," ","|d"," "," "," "," "," "," ", " ", "|d"},
                {" "," "," "," "," "," "," "," "," "," "," "," ","^|vdL"," "," ", " ", "|d"},
                {" "," "," "," "," "," "," ","<_>"," "," "," "," "," "," ","^_^", " ", "|d"},
                {" "," "," "," "," "," "," "," "," "," "," "," ","_","_"," ", "_", "|d"},
                {" "," "," "," "," "," "," "," "," "," ","<_>"," "," "," "," ", " ", " "},
                {" "," "," "," "," "," "," "," "," "," "," "," "," "," "," ", " ", " "},
                {" "," "," "," "," "," "," "," "," "," "," "," "," "," "," ", " ", " "},
                {" "," "," "," "," "," "," "," "," "," "," "," "," "," "," ", " ", " "}
                });
            Levels[2].LoadLevel();

            Levels[3] = new Level(new string[,] {
                {" "," "," "," "," "," "," "," "," "," "," "," "," "," "," ", " ", " "},
                {"_"," "," "," "," "," "," "," "," "," "," "," "," "," "," ", " ", " "},
                {" ","_"," "," "," "," "," "," "," "," "," "," "," "," "," ", " ", " "},
                {" "," ","_"," "," "," "," "," "," "," "," "," "," "," "," ", " ", " "},
                {" "," "," "," "," "," "," "," ","  "," "," "," "," "," "," ", " ", " "},
                {" "," "," "," "," "," ","_"," "," "," "," "," "," "," "," ", " ", " "},
                {" "," ","^|vdR"," "," "," "," "," "," ","_f"," "," "," "," "," ", " ", " "},
                {" "," "," "," ","^_^","|d","|d","^_^"," "," "," "," "," "," "," ", " ", " "},
                {" "," "," "," "," "," "," "," "," "," "," "," "," "," "," ", " ", " "},
                {" "," "," "," "," "," "," "," "," "," "," "," "," "," "," ", " ", " "},
                {" "," "," "," "," "," "," "," "," "," "," "," "," "," "," ", " ", " "},
                {" "," "," "," "," "," "," "," "," "," "," "," "," "," "," ", " ", " "},
                {" "," "," "," "," "," "," "," "," "," "," "," "," "," "," ", " ", " "},
                {" "," "," "," "," "," "," "," "," "," "," "," "," "," "," ", " ", " "},
                {" "," "," "," "," "," "," "," "," "," "," "," "," "," "," ", " ", " "},
                {" "," "," "," "," "," "," "," "," "," "," "," "," "," "," ", " ", " "},
                {" "," "," "," "," "," "," "," "," "," "," "," "," "," "," ", " ", " "}
                });
            Levels[3].LoadLevel();
        }

        public void NextLevel()
        {
            CurrentLevelIndex++;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            foreach(Entity entity in Levels[CurrentLevelIndex].LevelEntities)
            {
                if (entity != null)
                    entity.Draw(spriteBatch);
            }
        }
    }
}
