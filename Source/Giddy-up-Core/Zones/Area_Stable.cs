﻿using Harmony;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using Verse;

namespace GiddyUpCore.Zones
{
    class Area_Stable : Area
    {
        private String label = "GUC_Area_Stable";
        private Color color = Color.magenta;

        public Area_Stable(AreaManager areaManager) : base(areaManager)
        {
        }

        public override string Label
        {
            get
            {
                return label;
            }
        }

        public override Color Color
        {
            get
            {
                return color;
            }
        }

        public override bool Mutable
        {
            get
            {
                return true;
            }
        }

        public override int ListPriority
        {
            get
            {
                return 300;
            }
        }

        public override string GetUniqueLoadID()
        {
            throw new NotImplementedException();
        }

        public override void ExposeData()
        {
            base.ExposeData();
            Scribe_Values.Look<string>(ref this.label, "label", null, false);
            Scribe_Values.Look<Color>(ref this.color, "color", default(Color), false);
        }

    }
}
