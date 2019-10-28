namespace Inheritance
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
            this.btnClassic = new System.Windows.Forms.Button();
            this.btnAbstract = new System.Windows.Forms.Button();
            this.btnInerface = new System.Windows.Forms.Button();
            this.btnTemplate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClassic
            // 
            this.btnClassic.Location = new System.Drawing.Point(239, 123);
            this.btnClassic.Name = "btnClassic";
            this.btnClassic.Size = new System.Drawing.Size(75, 23);
            this.btnClassic.TabIndex = 0;
            this.btnClassic.Text = "Classic";
            this.btnClassic.UseVisualStyleBackColor = true;
            this.btnClassic.Click += new System.EventHandler(this.btnClassic_Click);
            // 
            // btnAbstract
            // 
            this.btnAbstract.Location = new System.Drawing.Point(239, 152);
            this.btnAbstract.Name = "btnAbstract";
            this.btnAbstract.Size = new System.Drawing.Size(75, 23);
            this.btnAbstract.TabIndex = 1;
            this.btnAbstract.Text = "Abstract";
            this.btnAbstract.UseVisualStyleBackColor = true;
            this.btnAbstract.Click += new System.EventHandler(this.btnAbstract_Click);
            // 
            // btnInerface
            // 
            this.btnInerface.Location = new System.Drawing.Point(239, 181);
            this.btnInerface.Name = "btnInerface";
            this.btnInerface.Size = new System.Drawing.Size(75, 23);
            this.btnInerface.TabIndex = 2;
            this.btnInerface.Text = "Interface";
            this.btnInerface.UseVisualStyleBackColor = true;
            this.btnInerface.Click += new System.EventHandler(this.btnInerface_Click);
            // 
            // btnTemplate
            // 
            this.btnTemplate.Location = new System.Drawing.Point(55, 272);
            this.btnTemplate.Name = "btnTemplate";
            this.btnTemplate.Size = new System.Drawing.Size(168, 23);
            this.btnTemplate.TabIndex = 3;
            this.btnTemplate.Text = "Template";
            this.btnTemplate.UseVisualStyleBackColor = true;
            this.btnTemplate.Click += new System.EventHandler(this.btnTemplate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 340);
            this.Controls.Add(this.btnTemplate);
            this.Controls.Add(this.btnInerface);
            this.Controls.Add(this.btnAbstract);
            this.Controls.Add(this.btnClassic);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClassic;
        private System.Windows.Forms.Button btnAbstract;
        private System.Windows.Forms.Button btnInerface;
        private System.Windows.Forms.Button btnTemplate;
    }
}

