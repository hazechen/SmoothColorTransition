namespace SmoothColorTransition
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelb = new System.Windows.Forms.Label();
            this.labelg = new System.Windows.Forms.Label();
            this.labelr = new System.Windows.Forms.Label();
            this.timerR = new System.Windows.Forms.Timer(this.components);
            this.timerG = new System.Windows.Forms.Timer(this.components);
            this.timerB = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.labelb);
            this.panel1.Controls.Add(this.labelg);
            this.panel1.Controls.Add(this.labelr);
            this.panel1.Location = new System.Drawing.Point(231, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(52, 86);
            this.panel1.TabIndex = 3;
            // 
            // labelb
            // 
            this.labelb.AutoSize = true;
            this.labelb.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelb.Location = new System.Drawing.Point(2, 62);
            this.labelb.Name = "labelb";
            this.labelb.Size = new System.Drawing.Size(20, 13);
            this.labelb.TabIndex = 2;
            this.labelb.Text = "B: ";
            // 
            // labelg
            // 
            this.labelg.AutoSize = true;
            this.labelg.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelg.Location = new System.Drawing.Point(2, 36);
            this.labelg.Name = "labelg";
            this.labelg.Size = new System.Drawing.Size(21, 13);
            this.labelg.TabIndex = 1;
            this.labelg.Text = "G: ";
            // 
            // labelr
            // 
            this.labelr.AutoSize = true;
            this.labelr.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelr.Location = new System.Drawing.Point(2, 10);
            this.labelr.Name = "labelr";
            this.labelr.Size = new System.Drawing.Size(18, 13);
            this.labelr.TabIndex = 0;
            this.labelr.Text = "R:";
            // 
            // timerR
            // 
            this.timerR.Interval = 50;
            this.timerR.Tick += new System.EventHandler(this.timerR_Tick);
            // 
            // timerG
            // 
            this.timerG.Interval = 50;
            this.timerG.Tick += new System.EventHandler(this.timerG_Tick);
            // 
            // timerB
            // 
            this.timerB.Interval = 50;
            this.timerB.Tick += new System.EventHandler(this.timerB_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "SmoothColorTransition";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelb;
        private System.Windows.Forms.Label labelg;
        private System.Windows.Forms.Label labelr;
        private System.Windows.Forms.Timer timerR;
        private System.Windows.Forms.Timer timerG;
        private System.Windows.Forms.Timer timerB;
    }
}

