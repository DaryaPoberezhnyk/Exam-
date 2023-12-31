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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace wpfexam.Views
{
    public partial class StudentsHome : Window
    {
        public StudentsHome()
        {
            InitializeComponent();
        }
       
        private void Image6_MouseLeftButtonDown(object sender, RoutedEventArgs e)
        {
            // Створення і відкриття нового вікна StudentsInfo.xaml
            StudentsInfo studentsInfo = new StudentsInfo();
            studentsInfo.Show();

            // Закриття поточного вікна
            this.Close();
        }
        private void Image12_MouseLeftButtonDown(object sender, RoutedEventArgs e)
        {
            // Створення і відкриття нового вікна StudentsInfo.xaml
            StudentsProfile studentsProfile = new StudentsProfile();
            studentsProfile.Show();

            // Закриття поточного вікна
            this.Close();
        }
    }
}
