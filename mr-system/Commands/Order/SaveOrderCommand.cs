using System;
using System.Windows.Input;
using mr_system.Model;

namespace mr_system.Commands.Order
{
    public class SaveOrderCommand : ICommand
    {
        private OrderCatalog _catalog;

        public SaveOrderCommand(OrderCatalog catalog)
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