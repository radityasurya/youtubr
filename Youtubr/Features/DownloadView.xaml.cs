using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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
using YoutubeExtractor;

namespace Youtubr.Features
{
    /// <summary>
    /// Interaction logic for DownloadView.xaml
    /// </summary>
    public partial class DownloadView : UserControl
    {
        public DownloadView()
        {
            InitializeComponent();
            tbURL.Text = "https://www.youtube.com/watch?v=HCTvupT1zJc";
        }

        void SaveVideoToDisk(string link)
        {
           
        }

        private void btnDownload_Click(object sender, RoutedEventArgs e)
        {
            pbProgress.Value = 0;
            
        }

        private void pbProgress_ValueChanged(object sender, ProgressEventArgs e)
        {

        }
    }
}
