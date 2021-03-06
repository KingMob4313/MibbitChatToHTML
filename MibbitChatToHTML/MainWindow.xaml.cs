﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Windows;

namespace MibbitChatToHTML
{
    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static public string lineFromDialog = string.Empty;
        List<Tuple<int, string>> annotatedChatLines = null;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            annotatedChatLines = new List<Tuple<int, string>>();
            List<string> justChatLines = new List<string>();

            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "Text|chat*.txt|All|*.*";
            OFD.FileName = "chat";
            bool? result = OFD.ShowDialog();

            if (result == true)
            {
                var currentFileName = OFD.FileName;
                FileNameTextBox.Text = currentFileName;

                justChatLines = ChatFile.ProcessChatFile(OFD.FileName, this);

            }
            string allChat = StreamOutLines(justChatLines);
            ChatTextBox.Text = allChat;
        }

        private string StreamOutLines(List<string> justChatLines)
        {
            string chat = string.Empty;
            foreach (string line in justChatLines)
            {
                chat = chat + line;
            }
            return chat;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetData(DataFormats.UnicodeText, (Object)ChatTextBox.Text);
            MessageBox.Show("Data Copied.");
        }

        private void CBCleanedCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            UnformattedCheckBox.IsChecked = false;
        }

        private void UnformattedCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            CBCleanedCheckBox.IsChecked = false;
        }
    }
}
