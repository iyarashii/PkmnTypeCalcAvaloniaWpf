// Copyright (c) 2022 iyarashii @ https://github.com/iyarashii 
// Licensed under the GNU General Public License v3.0,
// go to https://github.com/iyarashii/PkmnTypeCalcRazorPages/blob/master/LICENSE for license details.

namespace PokemonTypeLibrary.Models
{
    // all pokemon types derive from this class
    public abstract class PkmnType : IPkmnType
    {
        public abstract string TypeName { get; }
        public double DmgMultiplier { get; set; }
        public abstract string TypeColor { get; }

        // calculates dmg multiplier by executing CalculateDmgMultiplierForASingleType on selected types
        public double CalculateDmgMultiplier(IPkmnType defendingPkmnPrimaryType, IPkmnType defendingPkmnSecondaryType)
        {
            double primaryTypeMultiplier = CalculateDmgMultiplierForASingleType(defendingPkmnPrimaryType);
            double secondaryTypeMultiplier = CalculateDmgMultiplierForASingleType(defendingPkmnSecondaryType);

            // check if both types are the same type
            if (defendingPkmnPrimaryType.TypeName == defendingPkmnSecondaryType.TypeName)
            {
                return primaryTypeMultiplier;
            }
            else
            {
                return primaryTypeMultiplier * secondaryTypeMultiplier;
            }
        }
        // abstract method that is defined differently by every pokemon type
        public abstract double CalculateDmgMultiplierForASingleType(IPkmnType pkmnType);
    }
}
