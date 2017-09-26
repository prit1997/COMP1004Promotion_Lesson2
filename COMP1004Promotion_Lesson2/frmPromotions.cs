using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004Promotion_Lesson2
{
    public partial class frmPromotions : Form
    {
        public frmPromotions()
        {
            InitializeComponent();
        }

        private void frmPromotions_Load(object sender, EventArgs e)
        {
            StartUp();
        }
        /// <summary>
        ///  Opreations when form is loaded/cleared 
        /// </summary>
        private void StartUp()
        {
            //disable input controls 
            grpDepartment.Enabled = false;
            chkPicture.Enabled = false;
            picDeparment.Visible = false;
            //disable output controls
            rtxWelcome.Visible = false;
            txtPromotion.Visible = false;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            // Check Name and Member ID is Provided
            if (txtName.Text.Equals(String.Empty))
            {
                MessageBox.Show("Please provide your Name", "Name Missing");
                txtName.Focus();
            }
            else
            if (mtxMemberId.Text.Length != 5)
            {
                MessageBox.Show("Please provide your 5 digit member ID", "Member ID ERROR");
                mtxMemberId.Focus();
            }
            else
            {
                // Show a Welcome Messsage
                rtxWelcome.Visible = true;
                txtPromotion.Visible = true;
                rtxWelcome.Text = "Welcome" + txtName.Text + Environment.NewLine +
                                  "Your Member ID" + mtxMemberId.Text + "is Verified.";

                // Disable Sign in Input And Button 
                grpInput.Enabled = false;
                btnSignIn.Enabled = false;

                // Enable other Inputs for User 
                grpDepartment.Enabled = true;
                chkPicture.Enabled = true;
            }
        }
        /// <summary>
        /// Handles when the clothing department is chosen.
        /// </summary>
        /// <param name="sender">Clothing Radio Button</param>
        /// <param name="e">The Event Arguments</param>
        private void rdoClothing_CheckedChanged(object sender, EventArgs e)
        {
            txtPromotion.Text = "30% OFF Clearence Items";
            picDeparment.Image = Properties.Resources.Clothing;
        }

        private void chkPicture_CheckedChanged(object sender, EventArgs e)
        {
            picDeparment.Visible = chkPicture.Checked;
        }
        /// <summary>
        /// Bring the Form to its Start Default State
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clear all previous inputs; Enable Inputs 
            txtName.Text = String.Empty;
            mtxMemberId.Text = "";
            chkPicture.Checked = false;
            rdoJuiceBar.Checked = true;
            rdoJuiceBar.Checked = false;
            grpInput.Enabled = true;
            btnSignIn.Enabled = true;
            txtName.Focus();

            //Clear the Outputs
            rtxWelcome.Text = String.Empty;
            txtPromotion.Text = String.Empty;
            
            // Bringing the StartUp
            StartUp();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
            printForm1.Print();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
