using PokemonTypeLibrary.Models;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive.Linq;
using System.Text;

namespace PkmnTypeCalcAvaloniaWpfUi.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public static string EmptyTypeName { get; } = PkmnTypeFactory.CreateEmptyPkmnType().TypeName;
        private ObservableCollection<IPkmnType> _pkmnTypeList = new (PkmnTypeFactory.GeneratePkmnTypeList().Where(x => x.TypeName != EmptyTypeName).ToList());
        private IPkmnType _selectedPrimaryType = PkmnTypeFactory.CreateEmptyPkmnType(), _selectedSecondaryType = PkmnTypeFactory.CreateEmptyPkmnType();
        public List<IPkmnType> PrimaryPkmnTypeList { get; set; } = PkmnTypeFactory.GeneratePkmnTypeList();
        public List<IPkmnType> SecondaryPkmnTypeList { get; set; } = PkmnTypeFactory.GeneratePkmnTypeList();
        public ObservableCollection<IPkmnType> PkmnTypeList { get => _pkmnTypeList; set { this.RaiseAndSetIfChanged(ref _pkmnTypeList, value); } }
        public IPkmnType SelectedPrimaryType
        {
            get => PrimaryPkmnTypeList.Where(type => type.TypeName == _selectedPrimaryType.TypeName).Single();
            set { _selectedPrimaryType = value; Calculate(); }
        }
        public IPkmnType SelectedSecondaryType
        {
            get => SecondaryPkmnTypeList.Where(type => type.TypeName == _selectedSecondaryType.TypeName).Single();
            set { _selectedSecondaryType = value; Calculate(); }
        }
        public void Calculate()
        {
            if (_selectedPrimaryType.TypeName == EmptyTypeName && _selectedSecondaryType.TypeName == EmptyTypeName)
                return;

            // calculate damage multiplier for each pkmn type in the list
            foreach (var pkmnType in PkmnTypeList)
            {
                pkmnType.DmgMultiplier = pkmnType.CalculateDmgMultiplier(SelectedPrimaryType, SelectedSecondaryType);
            }

            // sort by damage multiplier from highest to lowest
            PkmnTypeList = new ObservableCollection<IPkmnType>(PkmnTypeList.OrderByDescending(x => x.DmgMultiplier));
        }
    }
}
