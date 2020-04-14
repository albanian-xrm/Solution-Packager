﻿using System.ComponentModel;

namespace AlbanianXrm.SolutionPackager
{
    internal class PluginViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private bool _AllowRequests = true;
        public bool AllowRequests
        {
            get { return _AllowRequests; }
            set
            {
                if (_AllowRequests == value) return;
                _AllowRequests = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AllowRequests)));
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
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(LocalOrCrm)));

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(HasConnection)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(DoesNotHaveConnection)));
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
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(LocalOrCrm)));

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(HasConnection)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(DoesNotHaveConnection)));
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
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(LocalOrCrm)));
            }
        }
    }
}
