﻿using ConsoleApp2;
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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Lion l1 = new Lion();
            Lion l2 = new Lion();




            Console.WriteLine(l1.Hp);
            Console.WriteLine(l2.Hp);
            l1.Attack(l2);
            Console.WriteLine(l1.Hp);
            Console.WriteLine(l2.Hp);
            Szirszar.Content = l1.Hp;

        }
    }
}
