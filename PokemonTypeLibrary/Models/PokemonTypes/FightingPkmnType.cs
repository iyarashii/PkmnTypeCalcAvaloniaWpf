// Copyright (c) 2022 iyarashii @ https://github.com/iyarashii 
// Licensed under the GNU General Public License v3.0,
// go to https://github.com/iyarashii/PkmnTypeCalcRazorPages/blob/master/LICENSE for license details.

namespace PokemonTypeLibrary.Models
{
    public class FightingPkmnType : PkmnType
    {
        public override string TypeName => "FIGHTING";

        public override string TypeColor => "#C03028";

        public override double CalculateDmgMultiplierForASingleType(IPkmnType pkmnType)
        {
            double output;
            if (pkmnType is NormalPkmnType || pkmnType is RockPkmnType || pkmnType is SteelPkmnType || pkmnType is IcePkmnType || pkmnType is DarkPkmnType)
            {
                output = 2.0;
            }
            else if (pkmnType is FlyingPkmnType || pkmnType is PoisonPkmnType || pkmnType is BugPkmnType || pkmnType is PsychicPkmnType || pkmnType is FairyPkmnType)
            {
                output = 0.5;
            }
            else if (pkmnType is GhostPkmnType)
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
