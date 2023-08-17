namespace CardDesignerGUI
{
    partial class frmCardDesignerHome
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
            this.pbHome = new System.Windows.Forms.PictureBox();
            this.btnCardDesigner = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).BeginInit();
            this.SuspendLayout();
            // 
            // pbHome
            // 
            this.pbHome.Location = new System.Drawing.Point(24, 23);
            this.pbHome.Name = "pbHome";
            this.pbHome.Size = new System.Drawing.Size(470, 445);
            this.pbHome.TabIndex = 0;
            this.pbHome.TabStop = false;
            // 
            // btnCardDesigner
            // 
            this.btnCardDesigner.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCardDesigner.Location = new System.Drawing.Point(21, 491);
            this.btnCardDesigner.Name = "btnCardDesigner";
            this.btnCardDesigner.Size = new System.Drawing.Size(224, 51);
            this.btnCardDesigner.TabIndex = 0;
            this.btnCardDesigner.Text = "Card Designer";
            this.btnCardDesigner.UseVisualStyleBackColor = true;
            this.btnCardDesigner.Click += new System.EventHandler(this.btnCardDesigner_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(270, 491);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(224, 51);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmCardDesignerHome
            // 
            this.AcceptButton = this.btnCardDesigner;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(518, 563);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCardDesigner);
            this.Controls.Add(this.pbHome);
            this.Name = "frmCardDesignerHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome To The Card Designer!";
            this.Load += new System.EventHandler(this.frmCardDesignerHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbHome;
        private System.Windows.Forms.Button btnCardDesigner;
        private System.Windows.Forms.Button btnExit;
    }
}