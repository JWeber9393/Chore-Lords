using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChoreLords.Models
{
    public class Spell
    {
        int SpellPwr;
        int SpellIntel;
        int SpellSpd;
        int SpellArm;
        public Spell()
        {
            SpellPwr = 0;
            SpellIntel = 0;
            SpellSpd = 0;
            SpellArm = 0;
        }
    }
}