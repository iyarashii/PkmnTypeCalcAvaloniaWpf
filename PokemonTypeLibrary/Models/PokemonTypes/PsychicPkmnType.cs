// Copyright (c) 2022 iyarashii @ https://github.com/iyarashii 
// Licensed under the GNU General Public License v3.0,
// go to https://github.com/iyarashii/PkmnTypeCalcRazorPages/blob/master/LICENSE for license details.

namespace PokemonTypeLibrary.Models
{
    public class PsychicPkmnType : PkmnType
    {
        public override string TypeName => "PSYCHIC";

        public override string TypeColor => "#F85888";

        public override double CalculateDmgMultiplierForASingleType(IPkmnType pkmnType)
        {
            double output;
            if (pkmnType is FightingPkmnType || pkmnType is PoisonPkmnType)
            {
                output = 2.0;
            }
            else if (pkmnType is SteelPkmnType || pkmnType is PsychicPkmnType)
            {
                output = 0.5;
            }
            else if (pkmnType is DarkPkmnType)
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
