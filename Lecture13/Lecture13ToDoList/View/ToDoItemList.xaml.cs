using Lecture13ToDoList.Model;
using System;
using System.Collections.Generic;
using System.Windows.Controls;


namespace Lecture13ToDoList.View
{
	/// <summary>
	/// Interakční logika pro ToDoItemList.xaml
	/// </summary>
	public partial class ToDoItemList : UserControl
	{
		public ToDoItemList()
		{
			InitializeComponent();
		}

		private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			Button button = sender as Button;
			if (button != null) {
				(this.DataContext as ICollection<ToDoItem>).Remove(button.DataContext as ToDoItem);
			}
		}
	}
}
