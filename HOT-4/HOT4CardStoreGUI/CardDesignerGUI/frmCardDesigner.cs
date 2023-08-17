using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;

namespace CardDesignerGUI
{
    public partial class frmCardDesigner : Form
    {
        public frmCardDesigner()
        {
            InitializeComponent();
        }

        // Declare and intialize global program arrays.
        string[] occasions =
        {
                   "Select An Occasion",
               "Birthday ($3.50/ each)",
            "Anniversary ($2.75/ each)",
             "Graduation ($3.00/ each)"
        };

        string[] birthdayStyles =
        {
            "Select A Style",
                  "Balloons",
                      "Cake",
                   "Flowers"
        };

        string[] anniversaryStyles =
        {
            "Select A Style",
                      "Blue",
                   "Flowers",
                 "Succulent"
        };

        string[] graduationStyles =
        {
            "Select A Style",
                      "Hats",
                     "Pants",
                     "Sloth"
        };

        string[] images =
        {
            // Occasion-Birthday, Style-Balloons:
            "C:/Users/Mae/OneDrive/Desktop/MerileeAnnaGlickAWD1100-HOTs/HOT-4/HOT4CardStoreGUI/CardDesignerGUI/" +
                "images/BirthdayBalloons.jpg",

            // Occasion-Birthday, Style-Cake:
            "C:/Users/Mae/OneDrive/Desktop/MerileeAnnaGlickAWD1100-HOTs/HOT-4/HOT4CardStoreGUI/CardDesignerGUI/" +
                "images/BirthdayCake.jpg",

            // Occasion-Birthday, Style-Flowers:
            "C:/Users/Mae/OneDrive/Desktop/MerileeAnnaGlickAWD1100-HOTs/HOT-4/HOT4CardStoreGUI/CardDesignerGUI/" +
                "images/BirthdayFlowers.jpg",

            // Occasion-Anniversary, Style-Blue:
            "C:/Users/Mae/OneDrive/Desktop/MerileeAnnaGlickAWD1100-HOTs/HOT-4/HOT4CardStoreGUI/CardDesignerGUI/" +
                "images/AnniversaryBlue.jpg",

            // Occasion-Anniversary, Style-Flowers:
            "C:/Users/Mae/OneDrive/Desktop/MerileeAnnaGlickAWD1100-HOTs/HOT-4/HOT4CardStoreGUI/CardDesignerGUI/" +
                "images/AnniversaryFlowers.jpg",

            // Occasion-Anniversary, Style-Succulents:
            "C:/Users/Mae/OneDrive/Desktop/MerileeAnnaGlickAWD1100-HOTs/HOT-4/HOT4CardStoreGUI/CardDesignerGUI/" +
                "images/AnniversarySucculent.jpg",

            // Occasion-Graduation, Style-Hats:
            "C:/Users/Mae/OneDrive/Desktop/MerileeAnnaGlickAWD1100-HOTs/HOT-4/HOT4CardStoreGUI/CardDesignerGUI/" +
                "images/GraduationHats.jpg",

            // Occasion-Graduation, Style-Pants:
            "C:/Users/Mae/OneDrive/Desktop/MerileeAnnaGlickAWD1100-HOTs/HOT-4/HOT4CardStoreGUI/CardDesignerGUI/" +
                "images/GraduationPants.jpg",

            // Occasion-Graduation, Style-Sloth:
            "C:/Users/Mae/OneDrive/Desktop/MerileeAnnaGlickAWD1100-HOTs/HOT-4/HOT4CardStoreGUI/CardDesignerGUI/" +
                "images/GraduationSloth.jpg"
        };

        // Declare and intialize global program constants.
        const decimal ENVELOPE = 0.25m;
        const decimal STAMP    = 0.50m;
        const decimal MESSAGE  = 0.30m;

        private void frmCardDesigner_Load(object sender, EventArgs e)
        {
            DisplayControls();
        }

        private void cboOccasion_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetToDefault();
            UpdateStyles();
        }

        private void cboStyles_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetToDefault();
            DisplayImage();
        }

        private void ckbMessage_CheckedChanged(object sender, EventArgs e)
        {
            UpdateMessageBox();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            VerifyInputs();
        }

        private void DisplayControls()
        {
            foreach(string occasion in occasions)
            {
                cboOccasions.Items.Add(occasion);
            }

            cboOccasions.SelectedIndex = 0;
        }

        private void SetToDefault()
        {
            ckbEnvelope.Checked = false;
               ckbStamp.Checked = false;
             ckbMessage.Checked = false;

            txtCost.Clear();
        }

        private void UpdateStyles()
        {
            cboStyles.Items.Clear();

            switch (cboOccasions.SelectedIndex)
            {
                case (1):
                    foreach (string style in birthdayStyles)
                    {
                        cboStyles.Items.Add(style);
                    }

                    cboStyles.SelectedIndex = 0;
                    break;

                case (2):
                    foreach (string style in anniversaryStyles)
                    {
                        cboStyles.Items.Add(style);
                    }

                    cboStyles.SelectedIndex = 0;
                    break;

                case (3):
                    foreach (string style in graduationStyles)
                    {
                        cboStyles.Items.Add(style);
                    }

                    cboStyles.SelectedIndex = 0;
                    break;
            }
        }

        private void DisplayImage()
        {
            int occasionsSelectedIndex = cboOccasions.SelectedIndex;
            int stylesSelectedIndex    = cboStyles.SelectedIndex;

            txtCost.Clear();

            switch (occasionsSelectedIndex)
            {
                case (1):
                    switch (stylesSelectedIndex)
                    {
                        case (1):

                            pbCard.Image    =       Image.FromFile(images[0]);
                            pbCard.SizeMode = PictureBoxSizeMode.StretchImage;
                            break;

                        case (2):

                            pbCard.Image    =       Image.FromFile(images[1]);
                            pbCard.SizeMode = PictureBoxSizeMode.StretchImage;
                            break;

                        case (3):

                            pbCard.Image    =       Image.FromFile(images[2]);
                            pbCard.SizeMode = PictureBoxSizeMode.StretchImage;
                            break;
                    }

                    break;

                case (2):
                    switch (stylesSelectedIndex)
                    {
                        case (1):

                            pbCard.Image    =       Image.FromFile(images[3]);
                            pbCard.SizeMode = PictureBoxSizeMode.StretchImage;
                            break;

                        case (2):

                            pbCard.Image    =       Image.FromFile(images[4]);
                            pbCard.SizeMode = PictureBoxSizeMode.StretchImage;
                            break;

                        case (3):

                            pbCard.Image    =       Image.FromFile(images[5]);
                            pbCard.SizeMode = PictureBoxSizeMode.StretchImage;
                            break;
                    }

                    break;

                case (3):
                    switch (stylesSelectedIndex)
                    {
                        case (1):
                            pbCard.Image    =       Image.FromFile(images[6]);
                            pbCard.SizeMode = PictureBoxSizeMode.StretchImage;
                            break;

                        case (2):
                            pbCard.Image    =       Image.FromFile(images[7]);
                            pbCard.SizeMode = PictureBoxSizeMode.StretchImage;
                            break;

                        case (3):
                            pbCard.Image    =       Image.FromFile(images[8]);
                            pbCard.SizeMode = PictureBoxSizeMode.StretchImage;
                            break;
                    }

                    break;
            }
        }

        private void UpdateMessageBox()
        {
            if (ckbMessage.Checked == true)
            {
                rtxtMessage.ReadOnly = false;
            }

            else
            {
                rtxtMessage.Clear();
                rtxtMessage.ReadOnly = true;
            }
        }

        private void VerifyInputs()
        {
            if (cboOccasions.SelectedIndex <= 0)
            {
                ShowErrorMessage("You must select an occasion!", "Invalid Or Empty Occasion");

                cboOccasions.SelectedIndex = 0;
                txtCost.Clear();
                return;
            }

            if (cboStyles.SelectedIndex <= 0)
            {
                ShowErrorMessage("You must select a style!", "Invalid Or Empty Style");

                cboStyles.SelectedIndex = 0;
                txtCost.Clear();
                return;
            }

            if (ckbMessage.Checked == true)
            {
                VerifyMessage();
            }

            else
            {
                CalculateCost();
            }
        }

        private void VerifyMessage()
        {
            if (rtxtMessage.Text == "")
            {
                ShowErrorMessage("If you select message, you must enter a message!", "Empty Message");
                ckbMessage.Checked = false;
                txtCost.Clear();
            }

            else
            {
                CalculateCost();
            }
        }

        private void CalculateCost()
        {
            decimal birthday    = 3.50m;
            decimal anniversary = 2.75m;
            decimal graduation  = 3.00m;
            decimal cost        = 0.00m;

            string  customMessage = rtxtMessage.Text;

            if (cboOccasions.SelectedIndex == 1)
            {
                if (ckbEnvelope.Checked == true)
                {
                    cost += ENVELOPE;
                }

                if (ckbStamp.Checked == true)
                {
                    cost += STAMP;
                }

                if (ckbMessage.Checked == true)
                {
                    ShowMessage($"Your custom message: {customMessage}", "Custom Message");

                    cost += MESSAGE;
                }

                       cost += birthday;
                txtCost.Text = cost.ToString();
            }

            if (cboOccasions.SelectedIndex == 2)
            {
                if (ckbEnvelope.Checked == true)
                {
                    cost += ENVELOPE;
                }

                if (ckbStamp.Checked == true)
                {
                    cost += STAMP;
                }

                if (ckbMessage.Checked == true)
                {
                    ShowMessage($"Your custom message: {customMessage}", "Custom Message");

                    cost += MESSAGE;
                }

                       cost += anniversary;
                txtCost.Text = cost.ToString();
            }

            if (cboOccasions.SelectedIndex == 3)
            {
                if (ckbEnvelope.Checked == true)
                {
                    cost += ENVELOPE;
                }

                if (ckbStamp.Checked == true)
                {
                    cost += STAMP;
                }

                if (ckbMessage.Checked == true)
                {
                    ShowMessage($"Your custom message: {customMessage}", "Custom Message");

                    cost += MESSAGE;
                }

                       cost += graduation;
                txtCost.Text = cost.ToString();
            }
        }

        private void ShowErrorMessage(string msg, string title)
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ShowMessage(string msg, string title)
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ReturnToHomeForm();
        }

        private void ReturnToHomeForm()
        {
            this.Hide();
        }
    }
}
