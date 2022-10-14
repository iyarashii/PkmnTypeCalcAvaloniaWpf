// Copyright (c) 2022 iyarashii @ https://github.com/iyarashii 
// Licensed under the GNU General Public License v3.0,
// go to https://github.com/iyarashii/PkmnTypeCalcRazorPages/blob/master/LICENSE for license details.

using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonTypeLibrary.Models
{
    public class EmptyPkmnType : PkmnType
    {
        public override string TypeName => "(none)";

        public override string TypeColor => "#FFFFFF";

        public override double CalculateDmgMultiplierForASingleType(IPkmnType pkmnType)
        {
            return 1.0;
        }
    }
}
