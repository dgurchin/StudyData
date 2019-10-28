namespace MotherProject
{
    partial class Form1
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
            this.btnMother = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_I_Mother = new System.Windows.Forms.Button();
            this.btnAbstractMother = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMother
            // 
            this.btnMother.Location = new System.Drawing.Point(32, 146);
            this.btnMother.Name = "btnMother";
            this.btnMother.Size = new System.Drawing.Size(198, 23);
            this.btnMother.TabIndex = 0;
            this.btnMother.Text = "Обычное наследование";
            this.btnMother.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(32, 23);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(198, 95);
            this.listBox1.TabIndex = 1;
            // 
            // btn_I_Mother
            // 
            this.btn_I_Mother.Location = new System.Drawing.Point(32, 175);
            this.btn_I_Mother.Name = "btn_I_Mother";
            this.btn_I_Mother.Size = new System.Drawing.Size(198, 23);
            this.btn_I_Mother.TabIndex = 2;
            this.btn_I_Mother.Text = "Наследование через Interface";
            this.btn_I_Mother.UseVisualStyleBackColor = true;
            // 
            // btnAbstractMother
            // 
            this.btnAbstractMother.Location = new System.Drawing.Point(32, 204);
            this.btnAbstractMother.Name = "btnAbstractMother";
            this.btnAbstractMother.Size = new System.Drawing.Size(198, 45);
            this.btnAbstractMother.TabIndex = 3;
            this.btnAbstractMother.Text = "Наследование через абстракные классы";
            this.btnAbstractMother.UseVisualStyleBackColor = true;
            this.btnAbstractMother.Click += new System.EventHandler(this.btnAbstractMother_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnAbstractMother);
            this.Controls.Add(this.btn_I_Mother);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnMother);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMother;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_I_Mother;
        private System.Windows.Forms.Button btnAbstractMother;
    }
}

