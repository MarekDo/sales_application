
namespace sales_application
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelHead = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btn_1 = new System.Windows.Forms.Button();
            this.panelForButton = new System.Windows.Forms.Panel();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.panelMain.SuspendLayout();
            this.panelForButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Silver;
            this.panelMain.Controls.Add(this.panelForButton);
            this.panelMain.Controls.Add(this.btn_1);
            this.panelMain.Controls.Add(this.panelLogo);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(153, 561);
            this.panelMain.TabIndex = 0;
            // 
            // panelHead
            // 
            this.panelHead.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHead.Location = new System.Drawing.Point(153, 0);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(931, 64);
            this.panelHead.TabIndex = 1;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(153, 64);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(931, 497);
            this.panelDesktop.TabIndex = 2;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.DarkRed;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(153, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // btn_1
            // 
            this.btn_1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_1.Location = new System.Drawing.Point(0, 100);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(153, 34);
            this.btn_1.TabIndex = 1;
            this.btn_1.Text = "Przycisk_1";
            this.btn_1.UseVisualStyleBackColor = true;
            // 
            // panelForButton
            // 
            this.panelForButton.Controls.Add(this.btn_5);
            this.panelForButton.Controls.Add(this.btn_4);
            this.panelForButton.Controls.Add(this.btn_3);
            this.panelForButton.Controls.Add(this.btn_2);
            this.panelForButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelForButton.Location = new System.Drawing.Point(0, 134);
            this.panelForButton.Name = "panelForButton";
            this.panelForButton.Size = new System.Drawing.Size(153, 94);
            this.panelForButton.TabIndex = 2;
            // 
            // btn_2
            // 
            this.btn_2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_2.Location = new System.Drawing.Point(0, 0);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(153, 23);
            this.btn_2.TabIndex = 0;
            this.btn_2.Text = "Przycisk_2";
            this.btn_2.UseVisualStyleBackColor = true;
            // 
            // btn_3
            // 
            this.btn_3.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_3.Location = new System.Drawing.Point(0, 23);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(153, 23);
            this.btn_3.TabIndex = 1;
            this.btn_3.Text = "Przycisk_3";
            this.btn_3.UseVisualStyleBackColor = true;
            // 
            // btn_4
            // 
            this.btn_4.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_4.Location = new System.Drawing.Point(0, 46);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(153, 23);
            this.btn_4.TabIndex = 2;
            this.btn_4.Text = "Przycisk_4";
            this.btn_4.UseVisualStyleBackColor = true;
            // 
            // btn_5
            // 
            this.btn_5.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_5.Location = new System.Drawing.Point(0, 69);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(153, 23);
            this.btn_5.TabIndex = 3;
            this.btn_5.Text = "Przycisk_5";
            this.btn_5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 561);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelHead);
            this.Controls.Add(this.panelMain);
            this.Name = "Form1";
            this.Text = "Sales App";
            this.panelMain.ResumeLayout(false);
            this.panelForButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelHead;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Panel panelForButton;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_2;
    }
}

