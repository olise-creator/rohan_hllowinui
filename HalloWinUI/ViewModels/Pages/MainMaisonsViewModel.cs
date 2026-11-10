using HalloWinUI.Data;
using HalloWinUI.Models;
using System.Collections.ObjectModel;

namespace HalloWinUI.ViewModels.Pages
{
    public class MainMaisonsViewModel:BaseViewModel
    {

        // commentaire
        private readonly IHalloweenDataProvider _dataProvider=new HalloweenDataProvider();
        public IHalloweenDataProvider dataProvider { get; }
        private MaisonViewModel _MaisonSelectionne;
        public MaisonViewModel MaisonVSelectionne
        {
            get => _MaisonSelectionne;
            set
            {
                if (value != _MaisonSelectionne) ;
                _MaisonSelectionne = value;

            }
        }

        public ObservableCollection<MaisonViewModel> Maisons { get; } = new() ;

        public MainMaisonsViewModel()
        {
            dataProvider=_dataProvider;
        }

        public void ChargerDonnees()
        {
            Maisons.Clear();
            foreach (Maison maison in _dataProvider.GetMaisons())
            {
                Maisons.Add(new MaisonViewModel(maison));

            }

        }
        public void Supprimer()
        {
            Maisons.Remove(MaisonVSelectionne);
            RaisePropertyChanged(Maisons);
        }
    }
}
