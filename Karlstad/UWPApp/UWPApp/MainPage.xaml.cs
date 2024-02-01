using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage.Pickers;
using Windows.Storage.Pickers.Provider;
using Windows.UI.Popups;
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

        private void OpenFileClick(object sender, RoutedEventArgs e)
        {
            var buttonm = (AppBarButton)sender;
            if(sender == OpenFileButton)
            {
                MyText.Text = "File Opened";

            }else if(sender == SaveFileButton)
            {
                MyText.Text = "File Saved";

            }

        }

        private void NewFileButton_Click(object sender, RoutedEventArgs e)
        {
            MyText.Text = "New File";

        }



        //private async void MyButton_Click(object sender, RoutedEventArgs e)
        //{
        //    var fileOpen = new FileOpenPicker();
        //    fileOpen.FileTypeFilter.Add(".txt");
        //    var result = await fileOpen.PickSingleFileAsync();

        //    if (result != null)
        //    {
        //        var text = await Windows.Storage.FileIO.ReadTextAsync(result);
        //        Mytext.Text = text;

        //    }


        //}


        // File picker
        //private async void MyButton_Click(object sender, RoutedEventArgs e)
        //{
        //    var fileSavePicker = new FileSavePicker();
        //    fileSavePicker.FileTypeChoices.Add("Plain Text", new List<string>() { ".txt"});
        //    var result = await fileSavePicker.PickSaveFileAsync();

        //    if (result != null)
        //    {
        //        await Windows.Storage.FileIO.WriteTextAsync(result, "Test123");
        //    }


        //}

        //private async void MyButton_Click(object sender, RoutedEventArgs e)
        //{
        //    MessageDialog ms = new MessageDialog("Do you want to retry");
        //    /*ms.Commands.Add(new UICommand("YES", x =>
        //    {
        //        MyButton.Content = "you clicked yes";
        //    }));
        //    ms.Commands.Add(new UICommand("NO", x =>
        //    {
        //        MyButton.Content = "you clicked no";
        //    }));*/

        //    ms.Commands.Add(new UICommand("Yes"));
        //    ms.Commands.Add(new UICommand("No"));
        //    var result = await ms.ShowAsync();

        //    if(result.Label == "Yes")
        //    {
        //        MyButton.Content = "yes";
        //    }
        //    else
        //    {
        //        MyButton.Content = "no";
        //    }



        //}

        /*private void Button_Click(object sender, RoutedEventArgs e)
        {
            clicks++;
            MyText.Text = $"You clicked {clicks} times";
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            MyText1.Text = InputText.Text.Length.ToString();

        }*/
    }
}
