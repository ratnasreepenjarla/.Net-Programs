namespace WindowsTask1
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
            this.lbinput = new System.Windows.Forms.ListBox();
            this.lboutput = new System.Windows.Forms.ListBox();
            this.btnaddsingle = new System.Windows.Forms.Button();
            this.btndeletesingle = new System.Windows.Forms.Button();
            this.btnaddmultiple = new System.Windows.Forms.Button();
            this.btndeletemultiple = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbinput
            // 
            this.lbinput.FormattingEnabled = true;
            this.lbinput.Location = new System.Drawing.Point(32, 53);
            this.lbinput.Name = "lbinput";
            this.lbinput.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbinput.Size = new System.Drawing.Size(160, 212);
            this.lbinput.TabIndex = 0;
            // 
            // lboutput
            // 
            this.lboutput.FormattingEnabled = true;
            this.lboutput.Location = new System.Drawing.Point(320, 53);
            this.lboutput.Name = "lboutput";
            this.lboutput.Size = new System.Drawing.Size(160, 212);
            this.lboutput.TabIndex = 0;
           
            // btnaddsingle
            // 
            this.btnaddsingle.Location = new System.Drawing.Point(217, 65);
            this.btnaddsingle.Name = "btnaddsingle";
            this.btnaddsingle.Size = new System.Drawing.Size(75, 23);
            this.btnaddsingle.TabIndex = 1;
            this.btnaddsingle.Text = "addsingle";
            this.btnaddsingle.UseVisualStyleBackColor = true;
            this.btnaddsingle.Click += new System.EventHandler(this.btnaddsingle_Click);
            // 
            // btndeletesingle
            // 
            this.btndeletesingle.Location = new System.Drawing.Point(217, 183);
            this.btndeletesingle.Name = "btndeletesingle";
            this.btndeletesingle.Size = new System.Drawing.Size(75, 23);
            this.btndeletesingle.TabIndex = 1;
            this.btndeletesingle.Text = "deletesingle";
            this.btndeletesingle.UseVisualStyleBackColor = true;
            this.btndeletesingle.Click += new System.EventHandler(this.btndeletesingle_Click);
            // 
            // btnaddmultiple
            // 
            this.btnaddmultiple.Location = new System.Drawing.Point(217, 126);
            this.btnaddmultiple.Name = "btnaddmultiple";
            this.btnaddmultiple.Size = new System.Drawing.Size(75, 23);
            this.btnaddmultiple.TabIndex = 1;
            this.btnaddmultiple.Text = "addmultiple";
            this.btnaddmultiple.UseVisualStyleBackColor = true;
            this.btnaddmultiple.Click += new System.EventHandler(this.btnaddmultiple_Click);
            // 
            // btndeletemultiple
            // 
            this.btndeletemultiple.Location = new System.Drawing.Point(217, 242);
            this.btndeletemultiple.Name = "btndeletemultiple";
            this.btndeletemultiple.Size = new System.Drawing.Size(75, 23);
            this.btndeletemultiple.TabIndex = 1;
            this.btndeletemultiple.Text = "deletemultiple";
            this.btndeletemultiple.UseVisualStyleBackColor = true;
            this.btndeletemultiple.Click += new System.EventHandler(this.btndeletemultiple_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 338);
            this.Controls.Add(this.btnaddmultiple);
            this.Controls.Add(this.btndeletemultiple);
            this.Controls.Add(this.btndeletesingle);
            this.Controls.Add(this.btnaddsingle);
            this.Controls.Add(this.lboutput);
            this.Controls.Add(this.lbinput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbinput;
        private System.Windows.Forms.ListBox lboutput;
        private System.Windows.Forms.Button btnaddsingle;
        private System.Windows.Forms.Button btndeletesingle;
        private System.Windows.Forms.Button btnaddmultiple;
        private System.Windows.Forms.Button btndeletemultiple;
    }
}

