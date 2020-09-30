namespace ProgrammingTest
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblJune = new System.Windows.Forms.Label();
            this.lblJuly = new System.Windows.Forms.Label();
            this.lblAugust = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "June points earned:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "July points earned:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "August points earned:";
            // 
            // lblJune
            // 
            this.lblJune.AutoSize = true;
            this.lblJune.Location = new System.Drawing.Point(271, 112);
            this.lblJune.Name = "lblJune";
            this.lblJune.Size = new System.Drawing.Size(0, 13);
            this.lblJune.TabIndex = 3;
            // 
            // lblJuly
            // 
            this.lblJuly.AutoSize = true;
            this.lblJuly.Location = new System.Drawing.Point(266, 143);
            this.lblJuly.Name = "lblJuly";
            this.lblJuly.Size = new System.Drawing.Size(0, 13);
            this.lblJuly.TabIndex = 4;
            // 
            // lblAugust
            // 
            this.lblAugust.AutoSize = true;
            this.lblAugust.Location = new System.Drawing.Point(298, 185);
            this.lblAugust.Name = "lblAugust";
            this.lblAugust.Size = new System.Drawing.Size(0, 13);
            this.lblAugust.TabIndex = 5;
            this.lblAugust.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAugust);
            this.Controls.Add(this.lblJuly);
            this.Controls.Add(this.lblJune);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblJune;
        private System.Windows.Forms.Label lblJuly;
        private System.Windows.Forms.Label lblAugust;
    }
}

