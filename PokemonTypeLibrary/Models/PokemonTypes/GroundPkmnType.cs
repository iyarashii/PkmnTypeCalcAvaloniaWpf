// Copyright (c) 2022 iyarashii @ https://github.com/iyarashii 
// Licensed under the GNU General Public License v3.0,
// go to https://github.com/iyarashii/PkmnTypeCalcRazorPages/blob/master/LICENSE for license details.

namespace PokemonTypeLibrary.Models
{
    public class GroundPkmnType : PkmnType
    {
        public override string TypeName => "GROUND";

        public override string TypeColor => "#E0C068";

        public override double CalculateDmgMultiplierForASingleType(IPkmnType pkmnType)
        {
            double output;
            if (pkmnType is PoisonPkmnType || pkmnType is RockPkmnType || pkmnType is SteelPkmnType || 
                pkmnType is FirePkmnType || pkmnType is ElectricPkmnType)
            {
                output = 2.0;
            }
            else if (pkmnType is BugPkmnType || pkmnType is GrassPkmnType)
            {
                output = 0.5;
            }
            else if (pkmnType is FlyingPkmnType)
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
