using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardDesignerGUI
{
    public partial class frmCardDesignerHome : Form
    {
        public frmCardDesignerHome()
        {
            InitializeComponent();
        }

        // Declare and intialize global program array.
        string[] images =
        {
            "C:/Users/Mae/OneDrive/Desktop/MerileeAnnaGlickAWD1100-HOTs/HOT-4/HOT4CardStoreGUI/CardDesignerGUI/images/CardStore.jpg"
        };

        private void frmCardDesignerHome_Load(object sender, EventArgs e)
        {
            ShowHomeImage();
        }

        private void btnCardDesigner_Click(object sender, EventArgs e)
        {
            OpenCardDesigner();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitProgramOrNot();
        }

        private void ShowHomeImage()
        {
            pbHome.Image = Image.FromFile(images[0]);
        }

        private void OpenCardDesigner()
        {
            Form cardDesignerForm = new frmCardDesigner();

            cardDesignerForm.ShowDialog();
        }

        private void ExitProgramOrNot()
        {
            DialogResult dialog = MessageBox.Show("Do You Really Want To Exit The Program?",
                                                  "Exit Now?",
                                  MessageBoxButtons.YesNo,
                                  MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
