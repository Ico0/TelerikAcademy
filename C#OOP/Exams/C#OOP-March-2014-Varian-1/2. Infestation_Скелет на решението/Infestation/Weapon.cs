﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    class Weapon:ISupplement
    {
        private int powerEffect;
        private int healthEffect;
        private int aggressionEffect;

        public void ReactTo(ISupplement otherSupplement)
        {
            if (otherSupplement.GetType() == typeof(WeaponrySkill))
            {
                this.powerEffect += 10;
                this.aggressionEffect += 3;
            }
        }

        public int PowerEffect
        {
            get { return this.powerEffect; }
        }

        public int HealthEffect
        {
            get { return this.healthEffect; }
        }

        public int AggressionEffect
        {
            get { return this.aggressionEffect; }
        }

        public Weapon()
        {
            this.powerEffect = 0;
            this.healthEffect = 0;
            this.aggressionEffect = 0;
        }
    }
}
