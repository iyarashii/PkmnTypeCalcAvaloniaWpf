using PokemonTypeLibrary.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace PkmnTypeCalcAvaloniaWpfUi.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public List<IPkmnType> PrimaryTypePkmnTypeList { get; set; } = PkmnTypeFactory.GeneratePkmnTypeList();
        public List<IPkmnType> SecondaryTypePkmnTypeList { get; set; } = PkmnTypeFactory.GeneratePkmnTypeList();
    }
}
