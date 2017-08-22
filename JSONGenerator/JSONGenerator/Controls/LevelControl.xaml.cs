using System.IO;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Win32;

namespace JSONGenerator.Controls
{
    /// <summary>
    /// Logique d'interaction pour LevelControl.xaml
    /// </summary>
    public partial class LevelControl : UserControl
    {
        public LevelControl()
        {
            InitializeComponent();
        }

        private void btnOpenFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
                ImagePathLevel.Text = openFileDialog.FileName;
        }
    }
}
