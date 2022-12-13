using System;
using System.ComponentModel;


namespace Lecture13ToDoList.Model
{
	public class ToDoItem : INotifyPropertyChanged
	{
		private string _label;

		private bool _done;

		public string Label { get => _label; set { _label = value; OnPropertyChanged("Label"); } }

		public bool Done { get => _done; set { _done = value; OnPropertyChanged("Done"); } }

		public event PropertyChangedEventHandler PropertyChanged;


		public ToDoItem(string label, bool done = false)
		{
			_label = label;
			_done = done;
		}


		protected void OnPropertyChanged(string name)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
	}
}
