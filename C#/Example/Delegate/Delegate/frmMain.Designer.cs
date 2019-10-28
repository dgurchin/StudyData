namespace Delegate
{
    partial class frmMain
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
            this.btnMulticastDelegate = new System.Windows.Forms.Button();
            this.btnAnonymousMethods = new System.Windows.Forms.Button();
            this.btnDelegateAsParametr = new System.Windows.Forms.Button();
            this.btnEvents = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMulticastDelegate
            // 
            this.btnMulticastDelegate.Location = new System.Drawing.Point(31, 64);
            this.btnMulticastDelegate.Name = "btnMulticastDelegate";
            this.btnMulticastDelegate.Size = new System.Drawing.Size(192, 23);
            this.btnMulticastDelegate.TabIndex = 0;
            this.btnMulticastDelegate.Text = "MulticastDelegate";
            this.btnMulticastDelegate.UseVisualStyleBackColor = true;
            this.btnMulticastDelegate.Click += new System.EventHandler(this.btnMulticastDelegate_Click);
            // 
            // btnAnonymousMethods
            // 
            this.btnAnonymousMethods.Location = new System.Drawing.Point(31, 93);
            this.btnAnonymousMethods.Name = "btnAnonymousMethods";
            this.btnAnonymousMethods.Size = new System.Drawing.Size(192, 23);
            this.btnAnonymousMethods.TabIndex = 1;
            this.btnAnonymousMethods.Text = "Anonymous methods";
            this.btnAnonymousMethods.UseVisualStyleBackColor = true;
            this.btnAnonymousMethods.Click += new System.EventHandler(this.btnAnonymousMethods_Click);
            // 
            // btnDelegateAsParametr
            // 
            this.btnDelegateAsParametr.Location = new System.Drawing.Point(31, 122);
            this.btnDelegateAsParametr.Name = "btnDelegateAsParametr";
            this.btnDelegateAsParametr.Size = new System.Drawing.Size(192, 23);
            this.btnDelegateAsParametr.TabIndex = 2;
            this.btnDelegateAsParametr.Text = "Delegates as method parameters";
            this.btnDelegateAsParametr.UseVisualStyleBackColor = true;
            this.btnDelegateAsParametr.Click += new System.EventHandler(this.btnDelegateAsParametr_Click);
            // 
            // btnEvents
            // 
            this.btnEvents.Location = new System.Drawing.Point(31, 151);
            this.btnEvents.Name = "btnEvents";
            this.btnEvents.Size = new System.Drawing.Size(192, 23);
            this.btnEvents.TabIndex = 3;
            this.btnEvents.Text = "Events";
            this.btnEvents.UseVisualStyleBackColor = true;
            this.btnEvents.Click += new System.EventHandler(this.btnEvents_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "JavaCallBack";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEvents);
            this.Controls.Add(this.btnDelegateAsParametr);
            this.Controls.Add(this.btnAnonymousMethods);
            this.Controls.Add(this.btnMulticastDelegate);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMulticastDelegate;
        private System.Windows.Forms.Button btnAnonymousMethods;
        private System.Windows.Forms.Button btnDelegateAsParametr;
        private System.Windows.Forms.Button btnEvents;
        private System.Windows.Forms.Button button1;
    }
}

