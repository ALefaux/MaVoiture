using System.Collections.ObjectModel;
using System.Windows.Input;
using Shared.Models;

namespace Shared.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel
    {
		public ObservableCollection<Consommation> Consommations { get; set; }
		public Consommation newConsommation { get; set; }
		public Consommation selectedConsommation { get; set; }

		public ICommand AjouterConsommationCommand { get; set; }
		public ICommand SupprimerConsommationCommand { get; set; }

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
			Consommations = new ObservableCollection<Consommation>();
			newConsommation = new Consommation();

			//AjouterConsommationCommand = new RelayCommand(() => Consommations.Add(newConsommation), () => !newConsommation.Prix.Equals(0.0));
			//SupprimerConsommationCommand = new RelayCommand(() => Consommations.Remove(selectedConsommation), () => selectedConsommation != null);
        }
    }
}