using HalloWinUI.Data;
using HalloWinUI.Models;
using System.Collections.ObjectModel;

namespace HalloWinUI.ViewModels.Pages
{
    public class MainMaisonsViewModel
    {

        // commentaire
        private readonly IHalloweenDataProvider _dataProvider=new HalloweenDataProvider();
        public IHalloweenDataProvider dataProvider { get; }

        public ObservableCollection<Maison> Maisons { get; } = new ObservableCollection<Maison>();

        public MainMaisonsViewModel()
        {
            dataProvider=_dataProvider;
        }

        public void ChargerDonnees()
        {
            Maisons.Clear();
            foreach (Maison maison in _dataProvider.GetMaisons())
            {
                Maisons.Add(maison);
            }

        }

    }
}
