using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace OODProjectY2
{
	/// <summary>
	/// Interaction logic for items.xaml
	/// </summary>
	public partial class items : Window
	{
		public items()
		{
			InitializeComponent();
		}

		public string SelectedItem { get; private set; }

		private void cbxcatrgy_Loaded(object sender, RoutedEventArgs e)
		{
			List<string> categories = new List<string>();
			categories.Add("Earings");
			categories.Add("Necklace");
			categories.Add("Ring");
			cbxcatrgy.ItemsSource = categories;
		}

		private void cbxcatrgy_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			string selectedcategories = cbxcatrgy.ItemsSource as string;
		

		}

		private void cbxtypes_Loaded(object sender, RoutedEventArgs e)
		{
			List<string> types = new List<string>();
			types.Add("Gold");
			types.Add("Silver");
			types.Add("Diamond");
			cbxcatrgy.ItemsSource = types;
		}

		private void cbxtypes_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			string selectedTypes = cbxtypes.ItemsSource as string;
		}

		private void btn4_Click(object sender, RoutedEventArgs e)
		{
			this.Close();
		}
	}
}
