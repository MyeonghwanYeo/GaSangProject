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
            this.panel3 = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.newPWCheckBox = new System.Windows.Forms.TextBox();
            this.newPWBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chanePWButton = new System.Windows.Forms.Button();
            this.presentPWBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.monitoringIcon = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.changeButton = new System.Windows.Forms.Button();
            this.logInButton = new System.Windows.Forms.Button();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.logOutIcon = new System.Windows.Forms.PictureBox();
            this.simulationIcon = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.panel1.Controls.Add(this.panel3);
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.cancelButton);
            this.panel3.Controls.Add(this.newPWCheckBox);
            this.panel3.Controls.Add(this.newPWBox);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.chanePWButton);
            this.panel3.Controls.Add(this.presentPWBox);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(638, 317);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(630, 330);
            this.panel3.TabIndex = 6;
            this.panel3.Visible = false;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cancelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(30)))), ((int)(((byte)(91)))));
            this.cancelButton.Location = new System.Drawing.Point(327, 246);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(249, 50);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // newPWCheckBox
            // 
            this.newPWCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newPWCheckBox.BackColor = System.Drawing.SystemColors.Window;
            this.newPWCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.newPWCheckBox.Location = new System.Drawing.Point(327, 175);
            this.newPWCheckBox.MaxLength = 16;
            this.newPWCheckBox.Name = "newPWCheckBox";
            this.newPWCheckBox.Size = new System.Drawing.Size(247, 32);
            this.newPWCheckBox.TabIndex = 2;
            this.newPWCheckBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.newPWCheckBox.UseSystemPasswordChar = true;
            // 
            // newPWBox
            // 
            this.newPWBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newPWBox.BackColor = System.Drawing.SystemColors.Window;
            this.newPWBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.newPWBox.Location = new System.Drawing.Point(327, 104);
            this.newPWBox.MaxLength = 16;
            this.newPWBox.Name = "newPWBox";
            this.newPWBox.Size = new System.Drawing.Size(247, 32);
            this.newPWBox.TabIndex = 1;
            this.newPWBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.newPWBox.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(37)))), ((int)(((byte)(91)))));
            this.label5.Location = new System.Drawing.Point(48, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(272, 45);
            this.label5.TabIndex = 5;
            this.label5.Text = "New PW (Check)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(37)))), ((int)(((byte)(91)))));
            this.label4.Location = new System.Drawing.Point(48, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 45);
            this.label4.TabIndex = 5;
            this.label4.Text = "New PW";
            // 
            // chanePWButton
            // 
            this.chanePWButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.chanePWButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chanePWButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chanePWButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(30)))), ((int)(((byte)(91)))));
            this.chanePWButton.Location = new System.Drawing.Point(50, 246);
            this.chanePWButton.Name = "chanePWButton";
            this.chanePWButton.Size = new System.Drawing.Size(249, 50);
            this.chanePWButton.TabIndex = 3;
            this.chanePWButton.Text = "Change Password";
            this.chanePWButton.UseVisualStyleBackColor = false;
            this.chanePWButton.Click += new System.EventHandler(this.changePWButton_Click);
            // 
            // presentPWBox
            // 
            this.presentPWBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.presentPWBox.BackColor = System.Drawing.SystemColors.Window;
            this.presentPWBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.presentPWBox.Location = new System.Drawing.Point(327, 33);
            this.presentPWBox.MaxLength = 16;
            this.presentPWBox.Name = "presentPWBox";
            this.presentPWBox.Size = new System.Drawing.Size(247, 32);
            this.presentPWBox.TabIndex = 0;
            this.presentPWBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.presentPWBox.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(37)))), ((int)(((byte)(91)))));
            this.label3.Location = new System.Drawing.Point(48, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 45);
            this.label3.TabIndex = 5;
            this.label3.Text = "Present PW";
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
            this.panel2.Controls.Add(this.changeButton);
            this.panel2.Controls.Add(this.logInButton);
            this.panel2.Controls.Add(this.passwordBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(712, 320);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(480, 330);
            this.panel2.TabIndex = 5;
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.changeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.changeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(30)))), ((int)(((byte)(91)))));
            this.changeButton.Location = new System.Drawing.Point(252, 182);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(187, 50);
            this.changeButton.TabIndex = 2;
            this.changeButton.Text = "Change PW";
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // logInButton
            // 
            this.logInButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.logInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logInButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.logInButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(37)))), ((int)(((byte)(91)))));
            this.logInButton.Location = new System.Drawing.Point(46, 182);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(187, 50);
            this.logInButton.TabIndex = 1;
            this.logInButton.Text = "Log In";
            this.logInButton.UseVisualStyleBackColor = false;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // passwordBox
            // 
            this.passwordBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordBox.BackColor = System.Drawing.SystemColors.Window;
            this.passwordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.passwordBox.Location = new System.Drawing.Point(227, 120);
            this.passwordBox.MaxLength = 16;
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(212, 32);
            this.passwordBox.TabIndex = 0;
            this.passwordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordBox.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(37)))), ((int)(((byte)(91)))));
            this.label2.Location = new System.Drawing.Point(46, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 45);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 12);
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
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(37)))), ((int)(((byte)(91)))));
            this.label1.Location = new System.Drawing.Point(25, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 47);
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
            this.simulationIcon.Click += new System.EventHandler(this.simulationIcon_Click);
            this.simulationIcon.MouseEnter += new System.EventHandler(this.SimulationIcon_MouseEnter);
            this.simulationIcon.MouseLeave += new System.EventHandler(this.SimulationIcon_MouseLeave);
            // 
            // Form2
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(232)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(1904, 1021);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button logInButton;
        private System.Windows.Forms.PictureBox logOutIcon;
        private System.Windows.Forms.PictureBox monitoringIcon;
        private System.Windows.Forms.PictureBox simulationIcon;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button chanePWButton;
        private System.Windows.Forms.TextBox presentPWBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox newPWCheckBox;
        private System.Windows.Forms.TextBox newPWBox;
        private System.Windows.Forms.Button cancelButton;
    }
}