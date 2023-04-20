using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace pz10_4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<string> _taskList;
        ObservableCollection<string> _finTaskList;
        public MainWindow()
        {
            InitializeComponent();
            _finTaskList = new ObservableCollection<string>();
            FinTaskList.ItemsSource = _finTaskList;
            _taskList = new ObservableCollection<string> { "Сдать долги", "Получить допуск к экзамену", "Сдать экзамен" };
            TaskList.ItemsSource = _taskList;
        }


        private void TaskList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            string mouse = TaskList.SelectedItem.ToString();
            _taskList.RemoveAt(TaskList.SelectedIndex);
            _finTaskList.Add(mouse);
        }

        private void AddTask_Click(object sender, RoutedEventArgs e)
        {
            string addtask = NewTask.Text;
            _taskList.Add(addtask);
            NewTask.Clear();
        }

        private void DeleteTask_Click(object sender, RoutedEventArgs e)
        {
            if (FinTaskList.SelectedIndex != -1)
            {
                _finTaskList.RemoveAt(FinTaskList.SelectedIndex);
            }
        }
    }
}
