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
using System.Windows.Shapes;

namespace TextToSQL
{
    /// <summary>
    /// Interaction logic for frmGetExcelInfo.xaml
    /// </summary>
    public partial class frmGetExcelInfo : Window
    {

        private string sFileName;
        public frmGetExcelInfo()
        {
            InitializeComponent();
        }

        public frmGetExcelInfo(string fileName)
        {
            InitializeComponent();

            sFileName = fileName;
        }
    }
}
