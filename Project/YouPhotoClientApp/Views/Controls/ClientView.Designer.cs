namespace YouPhotoClientApp.Views.Controls
{
    partial class ClientView
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
            this.buttonBreakOrder = new System.Windows.Forms.Button();
            this.buttonMakeOrder = new System.Windows.Forms.Button();
            this.buttonOrderStatus = new System.Windows.Forms.Button();
            this.textStatusOrder = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonBreakOrder
            // 
            this.buttonBreakOrder.Location = new System.Drawing.Point(150, 139);
            this.buttonBreakOrder.Name = "buttonBreakOrder";
            this.buttonBreakOrder.Size = new System.Drawing.Size(122, 23);
            this.buttonBreakOrder.TabIndex = 5;
            this.buttonBreakOrder.Text = "Break Order";
            this.buttonBreakOrder.UseVisualStyleBackColor = true;
            this.buttonBreakOrder.Click += new System.EventHandler(this.buttonBreakOrder_Click);
            // 
            // buttonMakeOrder
            // 
            this.buttonMakeOrder.Location = new System.Drawing.Point(12, 139);
            this.buttonMakeOrder.Name = "buttonMakeOrder";
            this.buttonMakeOrder.Size = new System.Drawing.Size(119, 23);
            this.buttonMakeOrder.TabIndex = 4;
            this.buttonMakeOrder.Text = "Make Order";
            this.buttonMakeOrder.UseVisualStyleBackColor = true;
            this.buttonMakeOrder.Click += new System.EventHandler(this.buttonMakeOrder_Click);
            // 
            // buttonOrderStatus
            // 
            this.buttonOrderStatus.Location = new System.Drawing.Point(150, 100);
            this.buttonOrderStatus.Name = "buttonOrderStatus";
            this.buttonOrderStatus.Size = new System.Drawing.Size(122, 23);
            this.buttonOrderStatus.TabIndex = 6;
            this.buttonOrderStatus.Text = "Order status";
            this.buttonOrderStatus.UseVisualStyleBackColor = true;
            this.buttonOrderStatus.Click += new System.EventHandler(this.buttonOrderStatus_Click);
            // 
            // textStatusOrder
            // 
            this.textStatusOrder.Location = new System.Drawing.Point(150, 64);
            this.textStatusOrder.Name = "textStatusOrder";
            this.textStatusOrder.Size = new System.Drawing.Size(122, 20);
            this.textStatusOrder.TabIndex = 7;
            this.textStatusOrder.TextChanged += new System.EventHandler(this.textStatusOrder_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(150, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(122, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(150, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(122, 20);
            this.textBox2.TabIndex = 9;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ссылка на фото";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Статус";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 13;
            // 
            // ClientView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 207);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textStatusOrder);
            this.Controls.Add(this.buttonOrderStatus);
            this.Controls.Add(this.buttonBreakOrder);
            this.Controls.Add(this.buttonMakeOrder);
            this.Name = "ClientView";
            this.Text = "ClientView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBreakOrder;
        private System.Windows.Forms.Button buttonMakeOrder;
        private System.Windows.Forms.Button buttonOrderStatus;
        private System.Windows.Forms.TextBox textStatusOrder;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}