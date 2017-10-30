using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Collections.ObjectModel;
namespace Inżynierka
{
	public partial class MainPage : ContentPage
	{
        public ObservableCollection<ViewModel.CellViewModel> Cells { get; set; }
        public MainPage()
		{
			InitializeComponent();

            Cells = new ObservableCollection<ViewModel.CellViewModel>();
            ListView MainView = new ListView();
            this.Title = "Inżynierka";
            MainView.ItemTemplate = new DataTemplate(typeof(CustomCell));
            Cells.Add(new ViewModel.CellViewModel { Name = "Test 1", Type = "Image", Image = "Test1.jpg" });
            Cells.Add(new ViewModel.CellViewModel { Name = "Test 2", Type = "Image", Image = "Test2.png" });
            Cells.Add(new ViewModel.CellViewModel { Name = "Test 3", Type = "Image", Image = "Test3.jpg" });
            MainView.ItemsSource = Cells;
            Content = MainView;

        }
    }
}
