using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace Lecture14.Model
{
	public class Recipe: INotifyPropertyChanged
	{
		private string _Name;
		public string Name
		{
			get {
				return _Name;
			}

			set {
				_Name = value;
				OnPropertyChanged();
			}
		}

		private string _Description;
		public string Description
		{
			get {
				return _Description;
			}

			set {
				_Description = value;
				OnPropertyChanged();
			}
		}

		public ObservableCollection<Ingredient> Ingredients
		{
			get;
		}

		public event PropertyChangedEventHandler PropertyChanged;


		public Recipe(string Name, string Description)
		{
			_Name = Name;
			_Description = Description;
		}


		public void AddIngredient(Ingredient ingredient)
		{
			Ingredients.Add(ingredient);
			OnPropertyChanged("Ingredients");
		}


		public void RemoveIngredient(Ingredient ingredient)
		{
			Ingredients.Remove(ingredient);
			OnPropertyChanged("Ingredients");
		}


		protected void OnPropertyChanged([CallerMemberName] string name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
	}
}
