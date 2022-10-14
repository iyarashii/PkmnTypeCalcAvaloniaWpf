// Copyright (c) 2022 iyarashii @ https://github.com/iyarashii 
// Licensed under the GNU General Public License v3.0,
// go to https://github.com/iyarashii/PkmnTypeCalcRazorPages/blob/master/LICENSE for license details.

namespace PokemonTypeLibrary.Models
{
    public class WaterPkmnType : PkmnType
    {
        public override string TypeName => "WATER";

        public override string TypeColor => "#6890F0";

        public override double CalculateDmgMultiplierForASingleType(IPkmnType pkmnType)
        {
            double output;
            if (pkmnType is GroundPkmnType || pkmnType is RockPkmnType || pkmnType is FirePkmnType)
            {
                output = 2.0;
            }
            else if (pkmnType is WaterPkmnType || pkmnType is GrassPkmnType || pkmnType is DragonPkmnType)
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
