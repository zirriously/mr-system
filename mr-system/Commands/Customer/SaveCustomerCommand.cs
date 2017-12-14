using System;
using System.Windows.Input;
using mr_system.Model;

namespace mr_system.Commands
{
    public class SaveCustomerCommand
    {
        public class SaveCommand : ICommand
        {
            private CustomerCatalog _catalog;

            public SaveCommand(CustomerCatalog catalog)
            {
                _catalog = catalog;
            }


            public bool CanExecute(object parameter)
            {
                return true;
            }

            public void Execute(object parameter)
            {
                _catalog.Save();
            }

            public event EventHandler CanExecuteChanged;
        }
    }
}
