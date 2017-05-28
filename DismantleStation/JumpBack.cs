
using System;
using System.Windows.Forms;

namespace DismantleStation
{
    public partial class JumpBack : Form
    {
        public JumpBack()
        {
            InitializeComponent();
        }

        public int SelectedProcess = -1;
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SelectedProcess = cbPrevProcess.SelectedIndex;
            Close();
        }

        private void JumpBack_Load(object sender, EventArgs e)
        {

        }
        
    }
}
