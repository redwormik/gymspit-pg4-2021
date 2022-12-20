using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace Lecture14.Model
{
	public class Ingredient: INotifyPropertyChanged
	{
		private string _name;
		public string Name
		{
			get {
				return _name;
			}

			set {
				_name = value;
				OnPropertyChanged();
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;


		public Ingredient(string Name)
		{
			_name = Name;
		}


		protected void OnPropertyChanged([CallerMemberName] string name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
	}
}
