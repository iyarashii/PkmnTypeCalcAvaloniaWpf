// Copyright (c) 2022 iyarashii @ https://github.com/iyarashii 
// Licensed under the GNU General Public License v3.0,
// go to https://github.com/iyarashii/PkmnTypeCalcRazorPages/blob/master/LICENSE for license details.

namespace PokemonTypeLibrary.Models
{
    public class FlyingPkmnType : PkmnType
    {
        public override string TypeName => "FLYING";

        public override string TypeColor => "#A890F0";

        public override double CalculateDmgMultiplierForASingleType(IPkmnType pkmnType)
        {
            double output;
            if (pkmnType is FightingPkmnType || pkmnType is BugPkmnType || pkmnType is GrassPkmnType)
            {
                output = 2.0;
            }
            else if (pkmnType is RockPkmnType || pkmnType is SteelPkmnType || pkmnType is ElectricPkmnType)
            {
                output = 0.5;
            }
            else
            {
                output = 1.0;
            }
            return output;
        }
    }
}
