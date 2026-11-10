using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloWinUI.ViewModels.Pages
{
    public class MaisonViewModel:BaseViewModel
    {
        private int _id;
        public int Id {
            get  =>_id; 
            set 
            {
                _id = value;
            
            }
        }
        private string _numeroCivique;
        public string NumeroCivique
        {
            get => _numeroCivique;
            set
            {
                if (_numeroCivique != value)
                {
                    _numeroCivique = value;
                    RaisePropertyChanged(nameof(NumeroCivique));
                }
            }
        }

        private string _rue;
        public string Rue
        {
            get => _rue;
            set
            {
                if (_rue != value)
                {
                    _rue = value;
                    RaisePropertyChanged(nameof(Rue));
                }
            }
        }

        private string _ville;
        public string Ville
        {
            get => _ville;
            set
            {
                if (_ville != value)
                {
                    _ville = value;
                    RaisePropertyChanged(nameof(Ville));
                }
            }
        }

        private string _codePostal;
        public string CodePostal
        {
            get => _codePostal;
            set
            {
                if (_codePostal != value)
                {
                    _codePostal = value;
                    RaisePropertyChanged(nameof(CodePostal));
                }
            }
        }

        private bool _estSignalee;
        public bool EstSignalee
        {
            get => _estSignalee;
            set
            {
                if (_estSignalee != value)
                {
                    _estSignalee = value;
                    RaisePropertyChanged(nameof(EstSignalee));
                }
            }
        }






    }
}
