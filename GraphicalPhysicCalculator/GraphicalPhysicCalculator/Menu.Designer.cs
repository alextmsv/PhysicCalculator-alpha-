﻿
namespace GraphicalPhysicCalculator
{
    partial class Menu
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
            this.timeCalc = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timeCalc
            // 
            this.timeCalc.Location = new System.Drawing.Point(17, 29);
            this.timeCalc.Name = "timeCalc";
            this.timeCalc.Size = new System.Drawing.Size(162, 37);
            this.timeCalc.TabIndex = 0;
            this.timeCalc.Text = "Время";
            this.timeCalc.UseVisualStyleBackColor = true;
            this.timeCalc.Click += new System.EventHandler(this.timeCalc_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(229, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Расстояние";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(436, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 36);
            this.button2.TabIndex = 2;
            this.button2.Text = "Скорость";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(17, 100);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 36);
            this.button3.TabIndex = 3;
            this.button3.Text = "Сила (с тупизмом)";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 207);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.timeCalc);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button timeCalc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}