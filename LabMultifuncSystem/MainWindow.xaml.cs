using System;
using System.Collections.Generic;
using System.Windows;
using DevExpress.Xpf.Core;

namespace LabMultifuncSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ThemedWindow
    {
        internal static MainWindow MyMainWindow;
        public MainWindow()
        {
            InitializeComponent();
            MyMainWindow = this;
            Certifications ctf = new Certifications();
            List<string> abc = ctf.LoadXlsClientInfo("abc");
        }
    }
}
