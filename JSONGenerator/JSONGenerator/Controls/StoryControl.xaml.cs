using System.Windows;
using System.Windows.Controls;
using Microsoft.Win32;

namespace JSONGenerator.Controls
{
    /// <summary>
    /// Logique d'interaction pour StoryControl.xaml
    /// </summary>
    public partial class StoryControl : UserControl
    {
        public StoryControl()
        {
            InitializeComponent();
        }

        private void btnOpenFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
                ImagePathStory.Text = openFileDialog.FileName;
        }
    }
}
