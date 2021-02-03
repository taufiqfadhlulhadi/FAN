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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FAN_Apps
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int column = 1;
        int row = 1;
        public MainWindow()
        {
            InitializeComponent();
            add_textbox();
        }

        public void add_textbox()
        {
            for (int i = 1; column > i; i++)
            {
                int j = 1;
                add_textbox_column(i, j);
                for (j = 1; row > j; j++)
                {
                    add_textbox_row(i, j);
                }
            }
        }

        public void add_textbox_row(int column, int row)
        {
            TextBox newtextbox = new TextBox();
            newtextbox.Text = column + ", " + row;
            newtextbox.Name = "T" + column.ToString() + row.ToString();
            //MessageBox.Show(newtextbox.Name.ToString());
            this.stack_horizontal.Children.Add(newtextbox);
        }

        public void add_textbox_column(int column, int row)
        {
            TextBox newtextbox = new TextBox();
            newtextbox.Text = column + ", " + row;
            newtextbox.Name = "T" + column.ToString() + row.ToString();
            this.stack_vertical.Children.Add(newtextbox);
        }

        public void delete_all_textbox(int column, int row)
        {
            
            for (int i = 1; i < column; i++)
            {
                int j = 1;

                TextBox textbox_column = new TextBox();
                textbox_column.Name = "T" + i.ToString() + j.ToString();
                MessageBox.Show(textbox_column.Name.ToString());
                stack_horizontal.Children.Remove((UIElement)this.FindName("T" + i.ToString() + j.ToString()));
               

                for (j = 1; j < row; j++)
                {
                    TextBox textbox = new TextBox();
                    textbox.Name = "T" + i.ToString() + j.ToString();
                    stack_vertical.Children.Remove((UIElement)this.FindName("T" + i.ToString() + j.ToString()));
                }
            }

        }

        private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            row++;
            delete_all_textbox(column, row);
            add_textbox();
        } 

        private void TextBlock_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            column++;
            delete_all_textbox(column, row);
            add_textbox();
        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    delete_all_textbox(column, row);
        //}
    }
}
