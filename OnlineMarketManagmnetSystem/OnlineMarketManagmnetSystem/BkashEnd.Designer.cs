﻿namespace OnlineMarketManagmnetSystem
{
    partial class BkashEnd
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BkashEnd));
            label1 = new Label();
            progressBar1 = new ProgressBar();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            buttonBkashendotpConfirm = new Guna.UI2.WinForms.Guna2Button();
            bkashendlogout = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FloralWhite;
            label1.Location = new Point(70, 37);
            label1.Name = "label1";
            label1.Size = new Size(435, 37);
            label1.TabIndex = 26;
            label1.Text = "Please Wait To Confirm Payment";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(128, 185);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(314, 23);
            progressBar1.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FloralWhite;
            label2.Location = new Point(233, 140);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 28;
            label2.Text = "Loading......";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // buttonBkashendotpConfirm
            // 
            buttonBkashendotpConfirm.BorderColor = Color.Transparent;
            buttonBkashendotpConfirm.CustomizableEdges = customizableEdges1;
            buttonBkashendotpConfirm.DisabledState.BorderColor = Color.DarkGray;
            buttonBkashendotpConfirm.DisabledState.CustomBorderColor = Color.DarkGray;
            buttonBkashendotpConfirm.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            buttonBkashendotpConfirm.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            buttonBkashendotpConfirm.FillColor = Color.FromArgb(128, 128, 255);
            buttonBkashendotpConfirm.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBkashendotpConfirm.ForeColor = Color.White;
            buttonBkashendotpConfirm.HoverState.ForeColor = Color.FromArgb(0, 192, 0);
            buttonBkashendotpConfirm.Location = new Point(128, 263);
            buttonBkashendotpConfirm.Name = "buttonBkashendotpConfirm";
            buttonBkashendotpConfirm.ShadowDecoration.CustomizableEdges = customizableEdges2;
            buttonBkashendotpConfirm.Size = new Size(154, 26);
            buttonBkashendotpConfirm.TabIndex = 29;
            buttonBkashendotpConfirm.Text = "Continue Shopping";
            buttonBkashendotpConfirm.Click += buttonBkashendotpConfirm_Click;
            // 
            // bkashendlogout
            // 
            bkashendlogout.BorderColor = Color.Transparent;
            bkashendlogout.CustomizableEdges = customizableEdges3;
            bkashendlogout.DisabledState.BorderColor = Color.DarkGray;
            bkashendlogout.DisabledState.CustomBorderColor = Color.DarkGray;
            bkashendlogout.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            bkashendlogout.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            bkashendlogout.FillColor = Color.FromArgb(128, 128, 255);
            bkashendlogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bkashendlogout.ForeColor = Color.White;
            bkashendlogout.HoverState.ForeColor = Color.FromArgb(0, 192, 0);
            bkashendlogout.Location = new Point(368, 263);
            bkashendlogout.Name = "bkashendlogout";
            bkashendlogout.ShadowDecoration.CustomizableEdges = customizableEdges4;
            bkashendlogout.Size = new Size(101, 26);
            bkashendlogout.TabIndex = 30;
            bkashendlogout.Text = "Logout";
            bkashendlogout.Click += bkashendlogout_Click;
            // 
            // BkashEnd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(592, 325);
            Controls.Add(bkashendlogout);
            Controls.Add(buttonBkashendotpConfirm);
            Controls.Add(label2);
            Controls.Add(progressBar1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BkashEnd";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BkashEnd";
            Load += BkashEnd_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ProgressBar progressBar1;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private Guna.UI2.WinForms.Guna2Button buttonBkashendotpConfirm;
        private Guna.UI2.WinForms.Guna2Button bkashendlogout;
    }
}