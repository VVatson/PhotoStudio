namespace YouPhotoClientApp.Views.Controls
{
    partial class AutorizationView
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
            this.buttonReg = new System.Windows.Forms.Button();
            this.textName = new System.Windows.Forms.TextBox();
            this.textPas = new System.Windows.Forms.TextBox();
            this.buttonAut = new System.Windows.Forms.Button();
            this.comboUser = new System.Windows.Forms.ComboBox();
            this.labelError = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonReg
            // 
            this.buttonReg.Location = new System.Drawing.Point(12, 103);
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.Size = new System.Drawing.Size(119, 23);
            this.buttonReg.TabIndex = 0;
            this.buttonReg.Text = "Registration";
            this.buttonReg.UseVisualStyleBackColor = true;
            this.buttonReg.Click += new System.EventHandler(this.buttonReg_Click);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(85, 12);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(187, 20);
            this.textName.TabIndex = 1;
            // 
            // textPas
            // 
            this.textPas.Location = new System.Drawing.Point(85, 38);
            this.textPas.Name = "textPas";
            this.textPas.Size = new System.Drawing.Size(187, 20);
            this.textPas.TabIndex = 2;
            // 
            // buttonAut
            // 
            this.buttonAut.Location = new System.Drawing.Point(150, 103);
            this.buttonAut.Name = "buttonAut";
            this.buttonAut.Size = new System.Drawing.Size(122, 23);
            this.buttonAut.TabIndex = 3;
            this.buttonAut.Text = "Authentication";
            this.buttonAut.UseVisualStyleBackColor = true;
            this.buttonAut.Click += new System.EventHandler(this.buttonAut_Click);
            // 
            // comboUser
            // 
            this.comboUser.FormattingEnabled = true;
            this.comboUser.Items.AddRange(new object[] {
            "Client",
            "Manager",
            "Operator"});
            this.comboUser.Location = new System.Drawing.Point(85, 64);
            this.comboUser.Name = "comboUser";
            this.comboUser.Size = new System.Drawing.Size(187, 21);
            this.comboUser.TabIndex = 4;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(117, 143);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 13);
            this.labelError.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "UserLevel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 9;
            // 
            // AutorizationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 165);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.comboUser);
            this.Controls.Add(this.buttonAut);
            this.Controls.Add(this.textPas);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.buttonReg);
            this.Name = "AutorizationView";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonReg;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textPas;
        private System.Windows.Forms.Button buttonAut;
        private System.Windows.Forms.ComboBox comboUser;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

