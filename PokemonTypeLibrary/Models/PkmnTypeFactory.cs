// Copyright (c) 2022 iyarashii @ https://github.com/iyarashii 
// Licensed under the GNU General Public License v3.0,
// go to https://github.com/iyarashii/PkmnTypeCalcRazorPages/blob/master/LICENSE for license details.

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace PokemonTypeLibrary.Models
{
    // factory class used for instantiating IPkmnType objects
    public static class PkmnTypeFactory
    {
        public static List<IPkmnType> GeneratePkmnTypeList()
        {
            List<IPkmnType> output = new List<IPkmnType>
            {
                CreateEmptyPkmnType(),
                CreateNormalPkmnType(),
                CreateFightingPkmnType(),
                CreateFlyingPkmnType(),
                CreatePoisonPkmnType(),
                CreateGroundPkmnType(),
                CreateRockPkmnType(),
                CreateBugPkmnType(),
                CreateGhostPkmnType(),
                CreateSteelPkmnType(),
                CreateFirePkmnType(),
                CreateWaterPkmnType(),
                CreateGrassPkmnType(),
                CreateElectricPkmnType(),
                CreatePsychicPkmnType(),
                CreateIcePkmnType(),
                CreateDragonPkmnType(),
                CreateDarkPkmnType(),
                CreateFairyPkmnType()
            };
            return output;
        }

        public static IPkmnType CreateEmptyPkmnType()
        {
            return new EmptyPkmnType();
        }

        public static IPkmnType CreateNormalPkmnType()
        {
            return new NormalPkmnType();
        }

        public static IPkmnType CreateFightingPkmnType()
        {
            return new FightingPkmnType();
        }

        public static IPkmnType CreateFlyingPkmnType()
        {
            return new FlyingPkmnType();
        }

        public static IPkmnType CreatePoisonPkmnType()
        {
            return new PoisonPkmnType();
        }

        public static IPkmnType CreateGroundPkmnType()
        {
            return new GroundPkmnType();
        }

        public static IPkmnType CreateRockPkmnType()
        {
            return new RockPkmnType();
        }

        public static IPkmnType CreateBugPkmnType()
        {
            return new BugPkmnType();
        }

        public static IPkmnType CreateGhostPkmnType()
        {
            return new GhostPkmnType();
        }

        public static IPkmnType CreateSteelPkmnType()
        {
            return new SteelPkmnType();
        }

        public static IPkmnType CreateFirePkmnType()
        {
            return new FirePkmnType();
        }

        public static IPkmnType CreateWaterPkmnType()
        {
            return new WaterPkmnType();
        }

        public static IPkmnType CreateGrassPkmnType()
        {
            return new GrassPkmnType();
        }

        public static IPkmnType CreateElectricPkmnType()
        {
            return new ElectricPkmnType();
        }

        public static IPkmnType CreatePsychicPkmnType()
        {
            return new PsychicPkmnType();
        }
        public static IPkmnType CreateIcePkmnType()
        {
            return new IcePkmnType();
        }
        public static IPkmnType CreateDragonPkmnType()
        {
            return new DragonPkmnType();
        }
        public static IPkmnType CreateDarkPkmnType()
        {
            return new DarkPkmnType();
        }
        public static IPkmnType CreateFairyPkmnType()
        {
            return new FairyPkmnType();
        }
    }
}
