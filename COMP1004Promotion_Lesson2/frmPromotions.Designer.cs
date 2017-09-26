namespace COMP1004Promotion_Lesson2
{
    partial class frmPromotions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPromotions));
            this.label1 = new System.Windows.Forms.Label();
            this.lblOWNER = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.mtxMemberId = new System.Windows.Forms.MaskedTextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.grpDepartment = new System.Windows.Forms.GroupBox();
            this.rtxWelcome = new System.Windows.Forms.RichTextBox();
            this.txtPromotion = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnSignIn = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.rdoClothing = new System.Windows.Forms.RadioButton();
            this.rdoEquipmentAccessories = new System.Windows.Forms.RadioButton();
            this.rdoJuiceBar = new System.Windows.Forms.RadioButton();
            this.rdoMembership = new System.Windows.Forms.RadioButton();
            this.rdoPersonalTraining = new System.Windows.Forms.RadioButton();
            this.chkPicture = new System.Windows.Forms.CheckBox();
            this.picDeparment = new System.Windows.Forms.PictureBox();
            this.printForm1 = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
            this.grpInput.SuspendLayout();
            this.grpDepartment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDeparment)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Look Sharp Fitness Center";
            // 
            // lblOWNER
            // 
            this.lblOWNER.AutoSize = true;
            this.lblOWNER.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOWNER.Location = new System.Drawing.Point(685, 533);
            this.lblOWNER.Name = "lblOWNER";
            this.lblOWNER.Size = new System.Drawing.Size(122, 20);
            this.lblOWNER.TabIndex = 10;
            this.lblOWNER.Text = "Prit Chikawala";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(76, 26);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "&Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "&Member ID";
            // 
            // grpInput
            // 
            this.grpInput.Controls.Add(this.mtxMemberId);
            this.grpInput.Controls.Add(this.txtName);
            this.grpInput.Controls.Add(this.lblName);
            this.grpInput.Controls.Add(this.label4);
            this.grpInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInput.Location = new System.Drawing.Point(391, 83);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(385, 100);
            this.grpInput.TabIndex = 0;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Member Login";
            // 
            // mtxMemberId
            // 
            this.mtxMemberId.Location = new System.Drawing.Point(128, 63);
            this.mtxMemberId.Mask = "00000";
            this.mtxMemberId.Name = "mtxMemberId";
            this.mtxMemberId.Size = new System.Drawing.Size(44, 20);
            this.mtxMemberId.TabIndex = 3;
            this.toolTip1.SetToolTip(this.mtxMemberId, "Please Enter Your 5 Digit Number");
            this.mtxMemberId.ValidatingType = typeof(int);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(128, 23);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(208, 20);
            this.txtName.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtName, "Please Enter Your name");
            // 
            // grpDepartment
            // 
            this.grpDepartment.Controls.Add(this.rdoPersonalTraining);
            this.grpDepartment.Controls.Add(this.rdoMembership);
            this.grpDepartment.Controls.Add(this.rdoJuiceBar);
            this.grpDepartment.Controls.Add(this.rdoEquipmentAccessories);
            this.grpDepartment.Controls.Add(this.rdoClothing);
            this.grpDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDepartment.Location = new System.Drawing.Point(43, 83);
            this.grpDepartment.Name = "grpDepartment";
            this.grpDepartment.Size = new System.Drawing.Size(173, 189);
            this.grpDepartment.TabIndex = 2;
            this.grpDepartment.TabStop = false;
            this.grpDepartment.Text = "Deparment";
            // 
            // rtxWelcome
            // 
            this.rtxWelcome.Location = new System.Drawing.Point(391, 190);
            this.rtxWelcome.Name = "rtxWelcome";
            this.rtxWelcome.ReadOnly = true;
            this.rtxWelcome.Size = new System.Drawing.Size(385, 94);
            this.rtxWelcome.TabIndex = 8;
            this.rtxWelcome.TabStop = false;
            this.rtxWelcome.Text = "";
            // 
            // txtPromotion
            // 
            this.txtPromotion.Location = new System.Drawing.Point(391, 303);
            this.txtPromotion.Multiline = true;
            this.txtPromotion.Name = "txtPromotion";
            this.txtPromotion.ReadOnly = true;
            this.txtPromotion.Size = new System.Drawing.Size(385, 43);
            this.txtPromotion.TabIndex = 9;
            this.txtPromotion.TabStop = false;
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(701, 363);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(75, 23);
            this.btnSignIn.TabIndex = 1;
            this.btnSignIn.Text = "&Sign In";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(701, 400);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(701, 437);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "&Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(701, 474);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // rdoClothing
            // 
            this.rdoClothing.AutoSize = true;
            this.rdoClothing.Location = new System.Drawing.Point(6, 24);
            this.rdoClothing.Name = "rdoClothing";
            this.rdoClothing.Size = new System.Drawing.Size(71, 17);
            this.rdoClothing.TabIndex = 0;
            this.rdoClothing.TabStop = true;
            this.rdoClothing.Text = "C&lothing";
            this.rdoClothing.UseVisualStyleBackColor = true;
            this.rdoClothing.CheckedChanged += new System.EventHandler(this.rdoClothing_CheckedChanged);
            // 
            // rdoEquipmentAccessories
            // 
            this.rdoEquipmentAccessories.AutoSize = true;
            this.rdoEquipmentAccessories.Location = new System.Drawing.Point(6, 56);
            this.rdoEquipmentAccessories.Name = "rdoEquipmentAccessories";
            this.rdoEquipmentAccessories.Size = new System.Drawing.Size(158, 17);
            this.rdoEquipmentAccessories.TabIndex = 1;
            this.rdoEquipmentAccessories.TabStop = true;
            this.rdoEquipmentAccessories.Text = "Eq&uipment/Accessories";
            this.rdoEquipmentAccessories.UseVisualStyleBackColor = true;
            // 
            // rdoJuiceBar
            // 
            this.rdoJuiceBar.AutoSize = true;
            this.rdoJuiceBar.Location = new System.Drawing.Point(6, 88);
            this.rdoJuiceBar.Name = "rdoJuiceBar";
            this.rdoJuiceBar.Size = new System.Drawing.Size(78, 17);
            this.rdoJuiceBar.TabIndex = 2;
            this.rdoJuiceBar.TabStop = true;
            this.rdoJuiceBar.Text = "&Juice Bar";
            this.rdoJuiceBar.UseVisualStyleBackColor = true;
            // 
            // rdoMembership
            // 
            this.rdoMembership.AutoSize = true;
            this.rdoMembership.Location = new System.Drawing.Point(6, 120);
            this.rdoMembership.Name = "rdoMembership";
            this.rdoMembership.Size = new System.Drawing.Size(92, 17);
            this.rdoMembership.TabIndex = 3;
            this.rdoMembership.TabStop = true;
            this.rdoMembership.Text = "Mem&bership";
            this.rdoMembership.UseVisualStyleBackColor = true;
            // 
            // rdoPersonalTraining
            // 
            this.rdoPersonalTraining.AutoSize = true;
            this.rdoPersonalTraining.Location = new System.Drawing.Point(6, 152);
            this.rdoPersonalTraining.Name = "rdoPersonalTraining";
            this.rdoPersonalTraining.Size = new System.Drawing.Size(124, 17);
            this.rdoPersonalTraining.TabIndex = 4;
            this.rdoPersonalTraining.TabStop = true;
            this.rdoPersonalTraining.Text = "Personal &Training";
            this.rdoPersonalTraining.UseVisualStyleBackColor = true;
            // 
            // chkPicture
            // 
            this.chkPicture.AutoSize = true;
            this.chkPicture.Location = new System.Drawing.Point(43, 369);
            this.chkPicture.Name = "chkPicture";
            this.chkPicture.Size = new System.Drawing.Size(88, 17);
            this.chkPicture.TabIndex = 3;
            this.chkPicture.Text = "Image &Visible";
            this.chkPicture.UseVisualStyleBackColor = true;
            this.chkPicture.CheckedChanged += new System.EventHandler(this.chkPicture_CheckedChanged);
            // 
            // picDeparment
            // 
            this.picDeparment.Location = new System.Drawing.Point(43, 392);
            this.picDeparment.Name = "picDeparment";
            this.picDeparment.Size = new System.Drawing.Size(316, 105);
            this.picDeparment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDeparment.TabIndex = 13;
            this.picDeparment.TabStop = false;
            // 
            // printForm1
            // 
            this.printForm1.DocumentName = "document";
            this.printForm1.Form = this;
            this.printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
            this.printForm1.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("printForm1.PrinterSettings")));
            this.printForm1.PrintFileName = null;
            // 
            // frmPromotions
            // 
            this.AcceptButton = this.btnSignIn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(819, 562);
            this.Controls.Add(this.picDeparment);
            this.Controls.Add(this.chkPicture);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.txtPromotion);
            this.Controls.Add(this.rtxWelcome);
            this.Controls.Add(this.grpDepartment);
            this.Controls.Add(this.grpInput);
            this.Controls.Add(this.lblOWNER);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPromotions";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Promotions";
            this.Load += new System.EventHandler(this.frmPromotions_Load);
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.grpDepartment.ResumeLayout(false);
            this.grpDepartment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDeparment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOWNER;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.GroupBox grpDepartment;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.MaskedTextBox mtxMemberId;
        private System.Windows.Forms.RichTextBox rtxWelcome;
        private System.Windows.Forms.TextBox txtPromotion;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton rdoPersonalTraining;
        private System.Windows.Forms.RadioButton rdoMembership;
        private System.Windows.Forms.RadioButton rdoJuiceBar;
        private System.Windows.Forms.RadioButton rdoEquipmentAccessories;
        private System.Windows.Forms.RadioButton rdoClothing;
        private System.Windows.Forms.CheckBox chkPicture;
        private System.Windows.Forms.PictureBox picDeparment;
        private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm printForm1;
    }
}

