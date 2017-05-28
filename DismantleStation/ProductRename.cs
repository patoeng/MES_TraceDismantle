using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace DismantleStation
{
    public partial class ProductRename : Form
    {
        public string NewDataMatrix;
        public bool Rename;
        public ProductRename()
        {
            InitializeComponent();
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            Rename = true;
            NewDataMatrix = tbReadBarcode.Text;
            Close();
        }
    }
}
