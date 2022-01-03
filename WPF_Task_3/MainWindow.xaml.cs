﻿using System;
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

namespace WPF_Task_3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string fontName = ((sender as ComboBox).SelectedItem as TextBlock).Text;
            if (textbox != null)
                textbox.FontFamily = new FontFamily(fontName);
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            int fontSize = Convert.ToInt32(((sender as ComboBox).SelectedItem as TextBlock).Text);
            if (textbox != null)
                textbox.FontSize = fontSize; 
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (textbox.FontWeight == FontWeights.Bold)
                textbox.FontWeight = FontWeights.Light;
            else
                textbox.FontWeight = FontWeights.Bold;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (textbox.FontStyle == FontStyles.Italic)
                textbox.FontStyle = FontStyles.Normal;
            else
                textbox.FontStyle = FontStyles.Italic;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (textbox.TextDecorations == TextDecorations.Underline)
                textbox.TextDecorations = null;
            else
                textbox.TextDecorations = TextDecorations.Underline;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (textbox != null)
                textbox.Foreground = Brushes.Black;
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            if (textbox != null)
                textbox.Foreground = Brushes.Red;
        }
    }
}
