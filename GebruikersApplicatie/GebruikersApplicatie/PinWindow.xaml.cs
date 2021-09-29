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
using System.Windows.Shapes;

namespace GebruikersApplicatie
{
    /// <summary>
    /// Interaction logic for PinWindow.xaml
    /// </summary>
    public partial class PinWindow : Window
    {
        string BankNumber;

        public PinWindow(string BankNumber)
        {
            InitializeComponent();
            this.BankNumber = BankNumber;
        }

        private void BtnNumber_Click(object sender, RoutedEventArgs e)
        {
            Button btnThis = sender as Button;
            string n = btnThis.Content.ToString();
            txbLogin.Text += n;
        }


        private void BtnDel_Click(object sender, RoutedEventArgs e)
        {
            Button btnThis = sender as Button;
            if (txbLogin.Text.Length >= 1)
            {
                txbLogin.Text = txbLogin.Text[0..^1];
            }
        }

        private void BtnEvaluate_Click(object sender, RoutedEventArgs e)
        {
            string userBankNumber = BankNumber;
            string userPin = txbLogin.Text;
            MessageBox.Show($"{userPin} {userBankNumber}");
            txbLogin.Clear();
        }
    }
}
