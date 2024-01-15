﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWPApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        int clicks = 0;
        public MainPage()
        {
            this.InitializeComponent(); // It creats all components
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            clicks++;
            MyText.Text = $"You clicked {clicks} times";
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            MyText1.Text = InputText.Text.Length.ToString();

        }
    }
}