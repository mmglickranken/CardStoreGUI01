namespace CardDesignerGUI
{
    partial class frmCardDesigner
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
            this.lblOccasion = new System.Windows.Forms.Label();
            this.lblStyle = new System.Windows.Forms.Label();
            this.cboOccasions = new System.Windows.Forms.ComboBox();
            this.cboStyles = new System.Windows.Forms.ComboBox();
            this.ckbEnvelope = new System.Windows.Forms.CheckBox();
            this.ckbStamp = new System.Windows.Forms.CheckBox();
            this.ckbMessage = new System.Windows.Forms.CheckBox();
            this.rtxtMessage = new System.Windows.Forms.RichTextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblCost = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.pbCard = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCard)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOccasion
            // 
            this.lblOccasion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblOccasion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOccasion.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOccasion.Location = new System.Drawing.Point(23, 20);
            this.lblOccasion.Name = "lblOccasion";
            this.lblOccasion.Size = new System.Drawing.Size(156, 46);
            this.lblOccasion.TabIndex = 9;
            this.lblOccasion.Text = "Occasion:";
            this.lblOccasion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStyle
            // 
            this.lblStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblStyle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStyle.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStyle.Location = new System.Drawing.Point(23, 80);
            this.lblStyle.Name = "lblStyle";
            this.lblStyle.Size = new System.Drawing.Size(156, 46);
            this.lblStyle.TabIndex = 10;
            this.lblStyle.Text = "Style:";
            this.lblStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboOccasions
            // 
            this.cboOccasions.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboOccasions.FormattingEnabled = true;
            this.cboOccasions.Location = new System.Drawing.Point(194, 27);
            this.cboOccasions.Name = "cboOccasions";
            this.cboOccasions.Size = new System.Drawing.Size(303, 35);
            this.cboOccasions.TabIndex = 0;
            this.cboOccasions.SelectedIndexChanged += new System.EventHandler(this.cboOccasion_SelectedIndexChanged);
            // 
            // cboStyles
            // 
            this.cboStyles.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStyles.FormattingEnabled = true;
            this.cboStyles.Location = new System.Drawing.Point(194, 87);
            this.cboStyles.Name = "cboStyles";
            this.cboStyles.Size = new System.Drawing.Size(303, 35);
            this.cboStyles.TabIndex = 1;
            this.cboStyles.SelectedIndexChanged += new System.EventHandler(this.cboStyles_SelectedIndexChanged);
            // 
            // ckbEnvelope
            // 
            this.ckbEnvelope.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ckbEnvelope.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbEnvelope.Location = new System.Drawing.Point(23, 139);
            this.ckbEnvelope.Name = "ckbEnvelope";
            this.ckbEnvelope.Size = new System.Drawing.Size(239, 33);
            this.ckbEnvelope.TabIndex = 2;
            this.ckbEnvelope.Text = "Envelope ($0.25)";
            this.ckbEnvelope.UseVisualStyleBackColor = false;
            // 
            // ckbStamp
            // 
            this.ckbStamp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ckbStamp.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbStamp.Location = new System.Drawing.Point(23, 178);
            this.ckbStamp.Name = "ckbStamp";
            this.ckbStamp.Size = new System.Drawing.Size(239, 33);
            this.ckbStamp.TabIndex = 3;
            this.ckbStamp.Text = "Stamp ($0.50)";
            this.ckbStamp.UseVisualStyleBackColor = false;
            // 
            // ckbMessage
            // 
            this.ckbMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ckbMessage.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbMessage.Location = new System.Drawing.Point(23, 218);
            this.ckbMessage.Name = "ckbMessage";
            this.ckbMessage.Size = new System.Drawing.Size(239, 33);
            this.ckbMessage.TabIndex = 4;
            this.ckbMessage.Text = "Custom Message ($0.30)";
            this.ckbMessage.UseVisualStyleBackColor = false;
            this.ckbMessage.CheckedChanged += new System.EventHandler(this.ckbMessage_CheckedChanged);
            // 
            // rtxtMessage
            // 
            this.rtxtMessage.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtMessage.Location = new System.Drawing.Point(23, 302);
            this.rtxtMessage.Name = "rtxtMessage";
            this.rtxtMessage.ReadOnly = true;
            this.rtxtMessage.Size = new System.Drawing.Size(474, 123);
            this.rtxtMessage.TabIndex = 5;
            this.rtxtMessage.Text = "";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(23, 511);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(173, 54);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnHome
            // 
            this.btnHome.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHome.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(212, 511);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(173, 54);
            this.btnHome.TabIndex = 7;
            this.btnHome.Text = "Return Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblCost
            // 
            this.lblCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCost.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(24, 443);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(183, 44);
            this.lblCost.TabIndex = 12;
            this.lblCost.Text = "Cost:";
            this.lblCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCost
            // 
            this.txtCost.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtCost.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCost.Location = new System.Drawing.Point(223, 445);
            this.txtCost.Name = "txtCost";
            this.txtCost.ReadOnly = true;
            this.txtCost.Size = new System.Drawing.Size(272, 37);
            this.txtCost.TabIndex = 8;
            // 
            // pbCard
            // 
            this.pbCard.Location = new System.Drawing.Point(522, 39);
            this.pbCard.Name = "pbCard";
            this.pbCard.Size = new System.Drawing.Size(512, 512);
            this.pbCard.TabIndex = 14;
            this.pbCard.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "Please Enter Your Custom Message Below:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCardDesigner
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CancelButton = this.btnHome;
            this.ClientSize = new System.Drawing.Size(1058, 581);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbCard);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.rtxtMessage);
            this.Controls.Add(this.ckbMessage);
            this.Controls.Add(this.ckbStamp);
            this.Controls.Add(this.ckbEnvelope);
            this.Controls.Add(this.cboStyles);
            this.Controls.Add(this.cboOccasions);
            this.Controls.Add(this.lblStyle);
            this.Controls.Add(this.lblOccasion);
            this.Name = "frmCardDesigner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Card Desginer";
            this.Load += new System.EventHandler(this.frmCardDesigner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOccasion;
        private System.Windows.Forms.Label lblStyle;
        private System.Windows.Forms.ComboBox cboOccasions;
        private System.Windows.Forms.ComboBox cboStyles;
        private System.Windows.Forms.CheckBox ckbEnvelope;
        private System.Windows.Forms.CheckBox ckbStamp;
        private System.Windows.Forms.CheckBox ckbMessage;
        private System.Windows.Forms.RichTextBox rtxtMessage;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.PictureBox pbCard;
        private System.Windows.Forms.Label label1;
    }
}

