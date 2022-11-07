using PokemonTypeLibrary.Models;
using ReactiveUI;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive.Linq;

namespace PkmnTypeCalcAvaloniaWpfUi.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private ObservableCollection<IPkmnType> _pkmnTypeList = new(PkmnTypeFactory.GeneratePkmnTypeList().Where(x => x.TypeName != EmptyTypeName).ToList());
        private IPkmnType _selectedPrimaryType = PkmnTypeFactory.CreateEmptyPkmnType(), _selectedSecondaryType = PkmnTypeFactory.CreateEmptyPkmnType();
        private bool calculatedTableVisibility;
        private ObservableCollection<IPkmnType> primaryPkmnTypeList = new(PkmnTypeFactory.GeneratePkmnTypeList());
        private ObservableCollection<IPkmnType> secondaryPkmnTypeList = new(PkmnTypeFactory.GeneratePkmnTypeList());

        public static string EmptyTypeName { get; } = PkmnTypeFactory.CreateEmptyPkmnType().TypeName;
        public ObservableCollection<IPkmnType> PrimaryPkmnTypeList { get => primaryPkmnTypeList; set { primaryPkmnTypeList = value; this.RaiseAndSetIfChanged(ref primaryPkmnTypeList, value); } }
        public ObservableCollection<IPkmnType> SecondaryPkmnTypeList { get => secondaryPkmnTypeList; set { secondaryPkmnTypeList = value; this.RaiseAndSetIfChanged(ref secondaryPkmnTypeList, value); } }
        public bool CalculatedTableVisibility
        {
            get => calculatedTableVisibility;
            set { this.RaiseAndSetIfChanged(ref calculatedTableVisibility, value); }
        }
        public ObservableCollection<IPkmnType> PkmnTypeList
        {
            get => _pkmnTypeList;
            set { this.RaiseAndSetIfChanged(ref _pkmnTypeList, value); }
        }
        public IPkmnType SelectedPrimaryType
        {
            get => PrimaryPkmnTypeList.Where(type => type.TypeName == _selectedPrimaryType.TypeName).Single();
            set 
            {
                if (value is not null && value.TypeName != _selectedPrimaryType.TypeName)
                {
                    this.RaiseAndSetIfChanged(ref _selectedPrimaryType, value);
                    _selectedPrimaryType = value;
                    Calculate(nameof(SelectedPrimaryType));
                }
            }
        }
        public IPkmnType SelectedSecondaryType
        {
            get => SecondaryPkmnTypeList.Where(type => type.TypeName == _selectedSecondaryType.TypeName).Single();
            set 
            {
                if (value is not null && value.TypeName != _selectedSecondaryType.TypeName)
                {
                    this.RaiseAndSetIfChanged(ref _selectedSecondaryType, value);
                    _selectedSecondaryType = value;
                    Calculate(nameof(SelectedSecondaryType));
                }
            }
        }

        private IPkmnType? lastRemovedPrimaryType = null;
        private IPkmnType? lastRemovedSecondaryType = null;
        private List<IPkmnType> fullTypeList = PkmnTypeFactory.GeneratePkmnTypeList();
        public void Calculate(string setType)
        {
            // reset list state
            if(lastRemovedPrimaryType != null)
            {
                PrimaryPkmnTypeList.Insert(fullTypeList.IndexOf(fullTypeList.Where(x => x.TypeName == lastRemovedPrimaryType.TypeName).Single()), lastRemovedPrimaryType);
                lastRemovedPrimaryType = null;
            }
            if (lastRemovedSecondaryType != null)
            {
                SecondaryPkmnTypeList.Insert(fullTypeList.IndexOf(fullTypeList.Where(x => x.TypeName == lastRemovedSecondaryType.TypeName).Single()), lastRemovedSecondaryType);
                lastRemovedSecondaryType = null;
            }

            if (_selectedPrimaryType.TypeName == EmptyTypeName && _selectedSecondaryType.TypeName == EmptyTypeName)
            {
                CalculatedTableVisibility = false;
                return;
            }

            // remove already selected type from the other combobox
            if (setType == nameof(SelectedPrimaryType) && _selectedPrimaryType.TypeName != EmptyTypeName)
            {
                lastRemovedSecondaryType = SecondaryPkmnTypeList.Where(type => type.TypeName == _selectedPrimaryType.TypeName).Single();
                SecondaryPkmnTypeList.Remove(lastRemovedSecondaryType);
            }
            else if (setType == nameof(SelectedSecondaryType) && _selectedSecondaryType.TypeName != EmptyTypeName)
            {
                lastRemovedPrimaryType = PrimaryPkmnTypeList.Where(type => type.TypeName == _selectedSecondaryType.TypeName).Single();
                PrimaryPkmnTypeList.Remove(lastRemovedPrimaryType);
            }

            CalculatedTableVisibility = true;

            // calculate damage multiplier for each pkmn type in the list
            foreach (var pkmnType in PkmnTypeList)
            {
                pkmnType.DmgMultiplier = pkmnType.CalculateDmgMultiplier(SelectedPrimaryType, SelectedSecondaryType);
            }

            // sort by damage multiplier from highest to lowest
            PkmnTypeList = new (PkmnTypeList.OrderByDescending(x => x.DmgMultiplier));
        }
    }
}
