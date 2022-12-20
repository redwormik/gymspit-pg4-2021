using System;
using System.Collections.ObjectModel;
using System.Windows;


namespace Lecture14
{
	/// <summary>
	/// Interakční logika pro MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private ObservableCollection<Model.Ingredient> ingredients = new ObservableCollection<Model.Ingredient>();


		public MainWindow()
		{
			InitializeComponent();

			ingredients.Add(new Model.Ingredient("Sugar"));
			ingredients.Add(new Model.Ingredient("Flour"));
			ingredients.Add(new Model.Ingredient("Cocoa"));

			DataContext = ingredients;
			if (ingredients.Count > 0) {
				ingredient.SelectedItem = ingredients[0];
			}
		}


		private void Button_Click(object sender, RoutedEventArgs e)
		{
			Model.Ingredient selected = (Model.Ingredient) ingredient.SelectedItem;
			if (selected != null) {
				MessageBox.Show(selected.Name);
			}
		}

		private void DeleteButton_Click(object sender, RoutedEventArgs e)
		{
			Model.Ingredient selected = (Model.Ingredient) ingredientList.SelectedItem;
			if (selected != null) {
				ingredients.Remove(selected);
			}
		}
	}
}
