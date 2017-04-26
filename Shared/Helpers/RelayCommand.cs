using System;
using System.Windows.Input;

namespace Shared
{
	public class RelayCommand : ICommand
	{
		public RelayCommand()
		{
		}

		private Action<object> execute;
		private Func<object, bool> canExecute;

		/*
		event EventHandler CanExecuteChanged
		{
			add { CommandManager.RequerySuggested += value; }
			remove { CommandManager.RequerySuggested -= value; }
		}
		*/

		public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
		{
			this.execute = execute;
			this.canExecute = canExecute;
		}

		event EventHandler ICommand.CanExecuteChanged
		{
			add
			{
				throw new NotImplementedException();
			}

			remove
			{
				throw new NotImplementedException();
			}
		}

		public bool CanExecute(object parameter)
		{
			return canExecute == null || canExecute(parameter);
		}

		public void Execute(object parameter)
		{
			execute(parameter);
		}
	}
}
