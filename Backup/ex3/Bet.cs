﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace roulette
{
    public class Bet
    {
        private Player p;
        private int betValue;
        public Bet(Player p, int value)
        {
            this.p = p;
            this.betValue = value;
        }
        public int Value { get { return betValue; } }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(Bet)) return false;
            return Equals((Bet)obj);
        }
        public bool Equals(Bet obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return Equals(obj.p, p) && Equals(obj.betValue, betValue);
        }
        public override int GetHashCode()
        {
            unchecked
            {
                return ((p != null ? p.GetHashCode() : 0) * 397) + (betValue.GetHashCode());
            }
        }

    }
}
