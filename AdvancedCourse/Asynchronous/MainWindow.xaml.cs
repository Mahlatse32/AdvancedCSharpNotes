﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
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

namespace Asynchronous
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DownloadAsync("http://msdn.microsoft.com");
        }

        public async void DownloadAsync(string url)
        {
            var webClient = new WebClient();
            var html = await webClient.DownloadStringTaskAsync(url);

            using (var streamWriter = new StreamWriter(@"C:\Users\mahlatset\desktop\result.html"))
            {
                await streamWriter.WriteAsync(html);
            }
        }

        public void Download(string url)
        {
            var webClient = new WebClient();
            var html = webClient.DownloadString(url);

            using(var streamWriter = new StreamWriter(@"C:\Users\mahlatset\desktop\result.html"))
            {
                streamWriter.Write(html);
            }
        }
    }
}
