using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.Graphics.Printing3D;
using mr_system.Annotations;

namespace mr_system.ViewModel.Domain.CaseOwner
{
    class CaseOwnerItemViewModel : INotifyPropertyChanged
    {
        private Model.CaseOwner _domainObject;

        public CaseOwnerItemViewModel(Model.CaseOwner domainObject)
        {
            _domainObject = domainObject;
        }

        public Model.CaseOwner DomainObject
        {
            get { return _domainObject; }
        }

        public string Name
        {
            get { return _domainObject.Name; }
            set
            {
                _domainObject.Name = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
