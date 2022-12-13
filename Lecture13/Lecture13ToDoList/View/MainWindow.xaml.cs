using Lecture13ToDoList.Model;
using System;
using System.Collections.ObjectModel;
using System.Windows;


namespace Lecture13ToDoList.View
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
	{
		public ObservableCollection<ToDoItem> items;

		public MainWindow()
        {
            InitializeComponent();

			items = new ObservableCollection<ToDoItem> {
				new ToDoItem("Finish ToDoItemList"),
				new ToDoItem("Add ToDoAddControl"),
			};

			itemList.DataContext = items;
		}


		private void AddButton_Click(object sender, RoutedEventArgs e)
		{
			if (addLabel.Text == "") {
				return;
			}

			items.Add(new ToDoItem(addLabel.Text));
			addLabel.Text = "";
		}

		private void MarkDoneButton_Click(object sender, RoutedEventArgs e)
		{
			foreach (ToDoItem item in items) {
				item.Done = true;
			}
		}
	}
}
