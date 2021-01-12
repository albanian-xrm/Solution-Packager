using AlbanianXrm.SolutionPackager.Properties;
using Microsoft.Xrm.Sdk;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace AlbanianXrm.SolutionPackager
{
    public class PluginViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private IOrganizationService _OrganizationService;
        public IOrganizationService OrganizationService
        {
            get
            {
                return _OrganizationService;
            }
            set
            {
                if (_OrganizationService == value)
                {
                    return;
                }
                _OrganizationService = value;
                NotifyPropertyChanged();
            }
        }

        private bool _AllowRequests = true;
        public bool AllowRequests
        {
            get { return _AllowRequests; }
            set
            {
                if (_AllowRequests == value) return;
                _AllowRequests = value;

                NotifyPropertyChanged();
            }
        }

        private bool _HasConnection = false;
        public bool HasConnection
        {
            get { return _HasConnection; }
            set
            {
                if (_HasConnection == value) return;
                _HasConnection = value;

                if (_LocalOrCrm)
                    NotifyPropertyChanged(nameof(LocalOrCrm));

                if (_ImportSolutionAfterPack)
                    NotifyPropertyChanged(nameof(ImportSolutionAfterPack));

                NotifyPropertyChanged();
                NotifyPropertyChanged(nameof(DoesNotHaveConnection));
            }
        }

        public bool DoesNotHaveConnection
        {
            get { return !_HasConnection; }
            set
            {
                if (_HasConnection == !value) return;
                _HasConnection = !value;

                if (_LocalOrCrm)
                    NotifyPropertyChanged(nameof(LocalOrCrm));

                if (_ImportSolutionAfterPack)
                    NotifyPropertyChanged(nameof(ImportSolutionAfterPack));

                NotifyPropertyChanged(nameof(HasConnection));
                NotifyPropertyChanged();
            }
        }

        private bool _LocalOrCrm = false;
        public bool LocalOrCrm
        {
            get { return _LocalOrCrm && _HasConnection; }
            set
            {
                if (_LocalOrCrm == value) return;
                _LocalOrCrm = value;

                if (_HasConnection)
                    NotifyPropertyChanged();
            }
        }

        private bool _ImportSolutionAfterPack = false;
        public bool ImportSolutionAfterPack
        {
            get { return _ImportSolutionAfterPack && _HasConnection; }
            set
            {
                if (_ImportSolutionAfterPack == value) return;
                _ImportSolutionAfterPack = value;

                if (_HasConnection)
                    NotifyPropertyChanged();
            }
        }

        private string _SolutionPackagerVersion;
        public string SolutionPackagerVersion
        {
            get { return _SolutionPackagerVersion ?? Resources.SOLUTIONPACKAGER_MISSING; }
            set
            {
                if (_SolutionPackagerVersion == value) return;
                _SolutionPackagerVersion = value;
                NotifyPropertyChanged();
            }
        }

        public CultureInfo CultureInfo
        {
            get { return Resources.Culture; }
            set
            {
                if (Resources.Culture != null && Resources.Culture.Equals(value) || Resources.Culture == value) return;
                Resources.Culture = value;
                System.Threading.Thread.CurrentThread.CurrentUICulture = value;
                Settings.Language = value.Name;
                NotifyPropertyChanged();
                NotifyPropertyChanged(nameof(SolutionPackagerVersion));
            }
        }

        public Settings Settings { get; set; } = new Settings();

        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
