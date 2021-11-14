
namespace GraphicalPhysicCalculator
{
    partial class distanceForm
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
            this.speed = new System.Windows.Forms.NumericUpDown();
            this.time = new System.Windows.Forms.NumericUpDown();
            this.Graph = new System.Windows.Forms.ProgressBar();
            this.tmr_emulation = new System.Windows.Forms.Timer(this.components);
            this.startBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.remainingDst = new System.Windows.Forms.Label();
            this.totalDst = new System.Windows.Forms.Label();
            this.stopButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.speed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.time)).BeginInit();
            this.SuspendLayout();
            // 
            // speed
            // 
            this.speed.Location = new System.Drawing.Point(12, 18);
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(120, 22);
            this.speed.TabIndex = 0;
            this.speed.ValueChanged += new System.EventHandler(this.speed_ValueChanged);
            // 
            // time
            // 
            this.time.Location = new System.Drawing.Point(12, 46);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(120, 22);
            this.time.TabIndex = 1;
            this.time.ValueChanged += new System.EventHandler(this.time_ValueChanged);
            // 
            // Graph
            // 
            this.Graph.Location = new System.Drawing.Point(190, 15);
            this.Graph.Name = "Graph";
            this.Graph.Size = new System.Drawing.Size(513, 50);
            this.Graph.TabIndex = 2;
            this.Graph.Click += new System.EventHandler(this.Graph_Click);
            // 
            // tmr_emulation
            // 
            this.tmr_emulation.Interval = 1000;
            this.tmr_emulation.Tick += new System.EventHandler(this.tmr_emulation_Tick);
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(12, 74);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(107, 23);
            this.startBtn.TabIndex = 3;
            this.startBtn.Text = "Присвоить";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(385, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Осталось:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(395, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Прошел:";
            // 
            // remainingDst
            // 
            this.remainingDst.AutoSize = true;
            this.remainingDst.Location = new System.Drawing.Point(457, 71);
            this.remainingDst.Name = "remainingDst";
            this.remainingDst.Size = new System.Drawing.Size(32, 17);
            this.remainingDst.TabIndex = 6;
            this.remainingDst.Text = "rem";
            // 
            // totalDst
            // 
            this.totalDst.AutoSize = true;
            this.totalDst.Location = new System.Drawing.Point(457, 85);
            this.totalDst.Name = "totalDst";
            this.totalDst.Size = new System.Drawing.Size(35, 17);
            this.totalDst.TabIndex = 7;
            this.totalDst.Text = "total";
            this.totalDst.Click += new System.EventHandler(this.totalDst_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(190, 68);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 9;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // distanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 103);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.totalDst);
            this.Controls.Add(this.remainingDst);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.Graph);
            this.Controls.Add(this.time);
            this.Controls.Add(this.speed);
            this.Name = "distanceForm";
            this.Text = "Расстояние";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.speed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.time)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown speed;
        private System.Windows.Forms.NumericUpDown time;
        private System.Windows.Forms.ProgressBar Graph;
        private System.Windows.Forms.Timer tmr_emulation;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label remainingDst;
        private System.Windows.Forms.Label totalDst;
        private System.Windows.Forms.Button stopButton;
    }
}