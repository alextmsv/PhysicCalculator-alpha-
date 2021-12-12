
namespace GraphicalPhysicCalculator
{
    partial class SpeedForm
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
            this.tmr_emulation = new System.Windows.Forms.Timer(this.components);
            this.Graph = new System.Windows.Forms.ProgressBar();
            this.distance = new System.Windows.Forms.NumericUpDown();
            this.time = new System.Windows.Forms.NumericUpDown();
            this.startBtn = new System.Windows.Forms.Button();
            this.currentSpd = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.stopButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.distance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.time)).BeginInit();
            this.SuspendLayout();
            // 
            // tmr_emulation
            // 
            this.tmr_emulation.Interval = 1000;
            this.tmr_emulation.Tick += new System.EventHandler(this.tmr_emulation_Tick);
            // 
            // Graph
            // 
            this.Graph.Location = new System.Drawing.Point(190, 15);
            this.Graph.Name = "Graph";
            this.Graph.Size = new System.Drawing.Size(513, 50);
            this.Graph.TabIndex = 3;
            // 
            // distance
            // 
            this.distance.Location = new System.Drawing.Point(12, 18);
            this.distance.Name = "distance";
            this.distance.Size = new System.Drawing.Size(120, 22);
            this.distance.TabIndex = 4;
            // 
            // time
            // 
            this.time.Location = new System.Drawing.Point(12, 46);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(120, 22);
            this.time.TabIndex = 5;
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(12, 74);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(107, 23);
            this.startBtn.TabIndex = 6;
            this.startBtn.Text = "Присвоить";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // currentSpd
            // 
            this.currentSpd.AutoSize = true;
            this.currentSpd.Location = new System.Drawing.Point(478, 74);
            this.currentSpd.Name = "currentSpd";
            this.currentSpd.Size = new System.Drawing.Size(47, 17);
            this.currentSpd.TabIndex = 8;
            this.currentSpd.Text = "speed";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(339, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Текущая скорость:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(190, 68);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 11;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // SpeedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 104);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.currentSpd);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.time);
            this.Controls.Add(this.distance);
            this.Controls.Add(this.Graph);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SpeedForm";
            this.ShowIcon = false;
            this.Text = "Скорость";
            this.Load += new System.EventHandler(this.SpeedForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.distance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.time)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmr_emulation;
        private System.Windows.Forms.ProgressBar Graph;
        private System.Windows.Forms.NumericUpDown distance;
        private System.Windows.Forms.NumericUpDown time;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label currentSpd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button stopButton;
    }
}