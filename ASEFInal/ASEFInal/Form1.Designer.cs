﻿
namespace ASEFInal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_Draw = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_StartPosX = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_StartPosY = new System.Windows.Forms.Label();
            this.txt_cmd = new System.Windows.Forms.TextBox();
            this.txt_command = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnExecute = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // pnl_Draw
            // 
            this.pnl_Draw.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnl_Draw.Location = new System.Drawing.Point(12, 40);
            this.pnl_Draw.Name = "pnl_Draw";
            this.pnl_Draw.Size = new System.Drawing.Size(384, 398);
            this.pnl_Draw.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_StartPosY);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbl_StartPosX);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(503, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Co-ordinates";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Y";
            // 
            // lbl_StartPosX
            // 
            this.lbl_StartPosX.AutoSize = true;
            this.lbl_StartPosX.Location = new System.Drawing.Point(43, 48);
            this.lbl_StartPosX.Name = "lbl_StartPosX";
            this.lbl_StartPosX.Size = new System.Drawing.Size(32, 17);
            this.lbl_StartPosX.TabIndex = 1;
            this.lbl_StartPosX.Text = "000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "X";
            // 
            // lbl_StartPosY
            // 
            this.lbl_StartPosY.AutoSize = true;
            this.lbl_StartPosY.Location = new System.Drawing.Point(162, 48);
            this.lbl_StartPosY.Name = "lbl_StartPosY";
            this.lbl_StartPosY.Size = new System.Drawing.Size(32, 17);
            this.lbl_StartPosY.TabIndex = 3;
            this.lbl_StartPosY.Text = "000";
            // 
            // txt_cmd
            // 
            this.txt_cmd.Location = new System.Drawing.Point(503, 165);
            this.txt_cmd.Name = "txt_cmd";
            this.txt_cmd.Size = new System.Drawing.Size(285, 22);
            this.txt_cmd.TabIndex = 3;
            // 
            // txt_command
            // 
            this.txt_command.Location = new System.Drawing.Point(503, 255);
            this.txt_command.Multiline = true;
            this.txt_command.Name = "txt_command";
            this.txt_command.Size = new System.Drawing.Size(285, 128);
            this.txt_command.TabIndex = 4;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(503, 205);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 5;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(503, 405);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(75, 23);
            this.btnExecute.TabIndex = 6;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.txt_command);
            this.Controls.Add(this.txt_cmd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnl_Draw);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_Draw;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_StartPosY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_StartPosX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_cmd;
        private System.Windows.Forms.TextBox txt_command;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnExecute;
    }
}
