// Copyright (c) 2022 iyarashii @ https://github.com/iyarashii 
// Licensed under the GNU General Public License v3.0,
// go to https://github.com/iyarashii/PkmnTypeCalcRazorPages/blob/master/LICENSE for license details.

namespace PokemonTypeLibrary.Models
{
    public class FirePkmnType : PkmnType
    {
        public override string TypeName => "FIRE";

        public override string TypeColor => "#F08030";

        public override double CalculateDmgMultiplierForASingleType(IPkmnType pkmnType)
        {
            double output;
            if (pkmnType is BugPkmnType || pkmnType is SteelPkmnType || pkmnType is GrassPkmnType || pkmnType is IcePkmnType)
            {
                output = 2.0;
            }
            else if (pkmnType is RockPkmnType || pkmnType is FirePkmnType || pkmnType is WaterPkmnType || pkmnType is DragonPkmnType)
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
