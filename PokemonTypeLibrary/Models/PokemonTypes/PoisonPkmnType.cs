// Copyright (c) 2022 iyarashii @ https://github.com/iyarashii 
// Licensed under the GNU General Public License v3.0,
// go to https://github.com/iyarashii/PkmnTypeCalcRazorPages/blob/master/LICENSE for license details.

namespace PokemonTypeLibrary.Models
{
    public class PoisonPkmnType : PkmnType
    {
        public override string TypeName => "POISON";

        public override string TypeColor => "#A040A0";

        public override double CalculateDmgMultiplierForASingleType(IPkmnType pkmnType)
        {
            double output;
            if (pkmnType is GrassPkmnType || pkmnType is FairyPkmnType)
            {
                output = 2.0;
            }
            else if (pkmnType is PoisonPkmnType || pkmnType is GroundPkmnType || pkmnType is RockPkmnType ||
                     pkmnType is GhostPkmnType)
            {
                output = 0.5;
            }
            else if (pkmnType is SteelPkmnType)
            {
                output = 0.0;
            }
            else
            {
                output = 1.0;
            }
            return output;
        }
    }
}
