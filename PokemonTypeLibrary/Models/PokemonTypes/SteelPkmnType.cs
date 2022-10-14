// Copyright (c) 2022 iyarashii @ https://github.com/iyarashii 
// Licensed under the GNU General Public License v3.0,
// go to https://github.com/iyarashii/PkmnTypeCalcRazorPages/blob/master/LICENSE for license details.

namespace PokemonTypeLibrary.Models
{
    public class SteelPkmnType : PkmnType
    {
        public override string TypeName => "STEEL";

        public override string TypeColor => "#B8B8D0";

        public override double CalculateDmgMultiplierForASingleType(IPkmnType pkmnType)
        {
            double output;
            if (pkmnType is RockPkmnType || pkmnType is IcePkmnType || pkmnType is FairyPkmnType)
            {
                output = 2.0;
            }
            else if (pkmnType is SteelPkmnType || pkmnType is FirePkmnType || pkmnType is WaterPkmnType ||
                     pkmnType is ElectricPkmnType)
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
