// Copyright (c) 2022 iyarashii @ https://github.com/iyarashii 
// Licensed under the GNU General Public License v3.0,
// go to https://github.com/iyarashii/PkmnTypeCalcRazorPages/blob/master/LICENSE for license details.

namespace PokemonTypeLibrary.Models
{
    public class RockPkmnType : PkmnType
    {
        public override string TypeName => "ROCK";

        public override string TypeColor => "#B8A038";

        public override double CalculateDmgMultiplierForASingleType(IPkmnType pkmnType)
        {
            double output;
            if (pkmnType is FlyingPkmnType || pkmnType is BugPkmnType || pkmnType is FirePkmnType ||
                pkmnType is IcePkmnType)
            {
                output = 2.0;
            }
            else if (pkmnType is FightingPkmnType || pkmnType is GroundPkmnType || pkmnType is SteelPkmnType)
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
