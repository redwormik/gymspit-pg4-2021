using System;
using System.Windows;
using System.Windows.Controls;


namespace Lecture12
{
	/// <summary>
	/// Interakční logika pro MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}


		private void Submit_Click(object sender, RoutedEventArgs e)
		{
			string name = this.name.Text;
			string surname = this.surname.Text;

			if (name == "" || surname == "") {
				return;
			}

			if (this.actionHello.IsChecked == true) {
				string message = string.Format("Hello, {0} {1}!", name, surname);
				MessageBox.Show(message, "Hello");
				this.result.Text = message;
			} else if (this.actionGoodbye.IsChecked == true) {
				string message = string.Format("Goodbye, {0} {1}!", name, surname);
				MessageBox.Show(message, "Goodbye");
				this.Close();
			}
		}


		private void Add_TextChanged(object sender, TextChangedEventArgs e)
		{
			int a, b;
			if (
				int.TryParse(this.addA.Text, out a) &&
				int.TryParse(this.addB.Text, out b)
			) {
				this.addResult.Text = (a + b).ToString();
			} else {
				this.addResult.Text = "";
			}
		}
	}
}
