﻿using System;
using System.Collections.Generic;
namespace Road111
{
    public class Fuel
    {
        private string type;
        public Fuel(string name)
        {
            type = name;
        }
        protected void SetFuel(string _type)
        {
            type = _type;
        }
        public String GetFuel()
        {
            return type;
        }
        public bool Equals(Fuel f)
        {
			if (f != null)
				if (f.GetFuel() == this.GetFuel())
					return true;
				else
					return false;
			else return false;
        }
    }
}
