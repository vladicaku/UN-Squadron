using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace CarrierAirWing
{
    class Level_2 : Level
    {
        public Level_2()
            : base()
        {
            if (Settings.SOUNDS)
                SoundEngine.PlayBackgroundMusic(@"sounds\soundtracks\level2.mp3");
            Lvl = 2;
            LevelBackground = Properties.Resources.level2;

        }

        public override Level LevelUP()
        {
            return new Level_1();
        }

        public override bool Tick()
        {
            Ticks++;
            if (Enemies.Count == 0)
                CanLevelUP = true;
            return false;
        }

        public override void Draw(Graphics g)
        {
            g.DrawImage(GraphicsEngine.Level2, 0 - Ticks % 127, 0);
            g.DrawImage(GraphicsEngine.Level2, 127 - Ticks % 127, 0);
            g.DrawImage(GraphicsEngine.Level2, 254 - Ticks % 127, 0);
            g.DrawImage(GraphicsEngine.Level2, 381 - Ticks % 127, 0);
            g.DrawImage(GraphicsEngine.Level2, 508 - Ticks % 127, 0);
            g.DrawImage(GraphicsEngine.Level2, 635 - Ticks % 127, 0);
            g.DrawImage(GraphicsEngine.Level2, 762 - Ticks % 127, 0);
            g.DrawImage(GraphicsEngine.Level2, 889 - Ticks % 127, 0);
        }

        
    }
}
