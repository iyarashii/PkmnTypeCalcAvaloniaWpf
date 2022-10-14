// Copyright (c) 2022 iyarashii @ https://github.com/iyarashii 
// Licensed under the GNU General Public License v3.0,
// go to https://github.com/iyarashii/PkmnTypeCalcRazorPages/blob/master/LICENSE for license details.

namespace PokemonTypeLibrary.Models
{
    public class ElectricPkmnType : PkmnType
    {
        public override string TypeName => "ELECTRIC";

        public override string TypeColor => "#F8D030";

        public override double CalculateDmgMultiplierForASingleType(IPkmnType pkmnType)
        {
            double output;
            if (pkmnType is FlyingPkmnType || pkmnType is WaterPkmnType)
            {
                output = 2.0;
            }
            else if (pkmnType is GrassPkmnType || pkmnType is ElectricPkmnType || pkmnType is DragonPkmnType)
            {
                output = 0.5;
            }
            else if (pkmnType is GroundPkmnType)
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
