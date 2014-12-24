﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WiiWandz.Strokes;
using WiiWandz.CloudBit;

namespace WiiWandz.Spells
{
    class Silencio : StrokeBasedSpell
    {
        public Silencio(String device, String authorization, int order, int duration)
            : base(device, authorization, order, duration)
        {
            List<StrokeDirection> directions = new List<StrokeDirection>();
            directions.Add(StrokeDirection.Down);
            directions.Add(StrokeDirection.DownToTheLeft);
            directions.Add(StrokeDirection.Left);
            directions.Add(StrokeDirection.UpToTheLeft);
            directions.Add(StrokeDirection.Up);
            directions.Add(StrokeDirection.Down);
            this.strokesForSpell.Add(directions);

            directions = new List<StrokeDirection>();
            directions.Add(StrokeDirection.Down);
            directions.Add(StrokeDirection.DownToTheLeft);
            directions.Add(StrokeDirection.UpToTheLeft);
            directions.Add(StrokeDirection.Down);
            this.strokesForSpell.Add(directions);

        }
    }
}