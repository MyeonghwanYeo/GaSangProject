using System.Drawing;
using System;
using System.Drawing.Drawing2D;

namespace ArduinoTest
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.monitoringIcon = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.registerButton = new System.Windows.Forms.Button();
            this.logInButton = new System.Windows.Forms.Button();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.logOutIcon = new System.Windows.Forms.PictureBox();
            this.simulationIcon = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monitoringIcon)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logOutIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simulationIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.monitoringIcon);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.logOutIcon);
            this.panel1.Controls.Add(this.simulationIcon);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1880, 1017);
            this.panel1.TabIndex = 2;
            // 
            // monitoringIcon
            // 
            this.monitoringIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.monitoringIcon.Image = ((System.Drawing.Image)(resources.GetObject("monitoringIcon.Image")));
            this.monitoringIcon.Location = new System.Drawing.Point(92, 252);
            this.monitoringIcon.Name = "monitoringIcon";
            this.monitoringIcon.Size = new System.Drawing.Size(540, 540);
            this.monitoringIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.monitoringIcon.TabIndex = 7;
            this.monitoringIcon.TabStop = false;
            this.monitoringIcon.Visible = false;
            this.monitoringIcon.Click += new System.EventHandler(this.monitoringIcon_Click);
            this.monitoringIcon.MouseEnter += new System.EventHandler(this.monitoringIcon_MouseEnter);
            this.monitoringIcon.MouseLeave += new System.EventHandler(this.monitoringIcon_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.registerButton);
            this.panel2.Controls.Add(this.logInButton);
            this.panel2.Controls.Add(this.passwordBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(712, 320);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(480, 330);
            this.panel2.TabIndex = 5;
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.registerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerButton.Font = new System.Drawing.Font("Segoe UI Variable Display", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.registerButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(30)))), ((int)(((byte)(91)))));
            this.registerButton.Location = new System.Drawing.Point(252, 182);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(187, 50);
            this.registerButton.TabIndex = 3;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = false;
            // 
            // logInButton
            // 
            this.logInButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.logInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logInButton.Font = new System.Drawing.Font("Segoe UI Variable Display", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.logInButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(37)))), ((int)(((byte)(91)))));
            this.logInButton.Location = new System.Drawing.Point(46, 182);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(187, 50);
            this.logInButton.TabIndex = 2;
            this.logInButton.Text = "Log In";
            this.logInButton.UseVisualStyleBackColor = false;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // passwordBox
            // 
            this.passwordBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordBox.BackColor = System.Drawing.SystemColors.Window;
            this.passwordBox.Font = new System.Drawing.Font("Segoe UI Variable Display", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.passwordBox.Location = new System.Drawing.Point(227, 120);
            this.passwordBox.MaxLength = 16;
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(212, 36);
            this.passwordBox.TabIndex = 1;
            this.passwordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordBox.UseSystemPasswordChar = true;
            this.passwordBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordBox_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Display", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(37)))), ((int)(((byte)(91)))));
            this.label2.Location = new System.Drawing.Point(46, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 43);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(51, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(37)))), ((int)(((byte)(91)))));
            this.label1.Location = new System.Drawing.Point(75, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 47);
            this.label1.TabIndex = 4;
            this.label1.Text = "odelab";
            // 
            // logOutIcon
            // 
            this.logOutIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logOutIcon.Image = ((System.Drawing.Image)(resources.GetObject("logOutIcon.Image")));
            this.logOutIcon.Location = new System.Drawing.Point(1274, 252);
            this.logOutIcon.Name = "logOutIcon";
            this.logOutIcon.Size = new System.Drawing.Size(540, 540);
            this.logOutIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logOutIcon.TabIndex = 6;
            this.logOutIcon.TabStop = false;
            this.logOutIcon.Visible = false;
            this.logOutIcon.Click += new System.EventHandler(this.logOutIcon_Click);
            this.logOutIcon.MouseEnter += new System.EventHandler(this.logOutIcon_MouseEnter);
            this.logOutIcon.MouseLeave += new System.EventHandler(this.logOutIcon_MouseLeave);
            // 
            // simulationIcon
            // 
            this.simulationIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.simulationIcon.Image = ((System.Drawing.Image)(resources.GetObject("simulationIcon.Image")));
            this.simulationIcon.Location = new System.Drawing.Point(683, 252);
            this.simulationIcon.Name = "simulationIcon";
            this.simulationIcon.Size = new System.Drawing.Size(540, 540);
            this.simulationIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.simulationIcon.TabIndex = 8;
            this.simulationIcon.TabStop = false;
            this.simulationIcon.Visible = false;
            this.simulationIcon.MouseEnter += new System.EventHandler(this.SimulationIcon_MouseEnter);
            this.simulationIcon.MouseLeave += new System.EventHandler(this.SimulationIcon_MouseLeave);
            // 
            // Form2
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(232)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monitoringIcon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logOutIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simulationIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button logInButton;
        private System.Windows.Forms.PictureBox logOutIcon;
        private System.Windows.Forms.PictureBox monitoringIcon;
        private System.Windows.Forms.PictureBox simulationIcon;
    }
}