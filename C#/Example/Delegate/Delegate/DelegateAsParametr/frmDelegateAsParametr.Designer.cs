namespace Delegate.DelegateAsParametr
{
    partial class frmDelegateAsParametr
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
            this.rdbMultiply = new System.Windows.Forms.RadioButton();
            this.rdbDevide = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnOneAction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdbMultiply
            // 
            this.rdbMultiply.AutoSize = true;
            this.rdbMultiply.Location = new System.Drawing.Point(74, 84);
            this.rdbMultiply.Name = "rdbMultiply";
            this.rdbMultiply.Size = new System.Drawing.Size(85, 17);
            this.rdbMultiply.TabIndex = 0;
            this.rdbMultiply.TabStop = true;
            this.rdbMultiply.Text = "Умножение";
            this.rdbMultiply.UseVisualStyleBackColor = true;
            // 
            // rdbDevide
            // 
            this.rdbDevide.AutoSize = true;
            this.rdbDevide.Location = new System.Drawing.Point(187, 84);
            this.rdbDevide.Name = "rdbDevide";
            this.rdbDevide.Size = new System.Drawing.Size(70, 17);
            this.rdbDevide.TabIndex = 1;
            this.rdbDevide.TabStop = true;
            this.rdbDevide.Text = "Деление";
            this.rdbDevide.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(66, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(172, 47);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // btnOneAction
            // 
            this.btnOneAction.Location = new System.Drawing.Point(114, 121);
            this.btnOneAction.Name = "btnOneAction";
            this.btnOneAction.Size = new System.Drawing.Size(116, 23);
            this.btnOneAction.TabIndex = 4;
            this.btnOneAction.Text = "Сделать";
            this.btnOneAction.UseVisualStyleBackColor = true;
            this.btnOneAction.Click += new System.EventHandler(this.btnOneAction_Click);
            // 
            // frmDelegateAsParametr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 198);
            this.Controls.Add(this.btnOneAction);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rdbDevide);
            this.Controls.Add(this.rdbMultiply);
            this.Name = "frmDelegateAsParametr";
            this.Text = "frmDelegateAsParametr";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbMultiply;
        private System.Windows.Forms.RadioButton rdbDevide;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnOneAction;
    }
}