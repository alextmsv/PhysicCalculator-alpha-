
namespace GraphicalPhysicCalculator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.Graph = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.remainingTime = new System.Windows.Forms.Label();
            this.passedTime = new System.Windows.Forms.Label();
            this.stopButton = new System.Windows.Forms.Button();
            this.tmr_emulation = new System.Windows.Forms.Timer(this.components);
            this.Distance = new System.Windows.Forms.NumericUpDown();
            this.Speed = new System.Windows.Forms.NumericUpDown();
            this.total = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Distance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Speed)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Присвоить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Graph
            // 
            this.Graph.Location = new System.Drawing.Point(190, 15);
            this.Graph.Name = "Graph";
            this.Graph.Size = new System.Drawing.Size(513, 50);
            this.Graph.TabIndex = 3;
            this.Graph.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(453, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Осталось:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(463, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Прошел:";
            // 
            // remainingTime
            // 
            this.remainingTime.AutoSize = true;
            this.remainingTime.Location = new System.Drawing.Point(534, 65);
            this.remainingTime.Name = "remainingTime";
            this.remainingTime.Size = new System.Drawing.Size(0, 17);
            this.remainingTime.TabIndex = 6;
            // 
            // passedTime
            // 
            this.passedTime.AutoSize = true;
            this.passedTime.Location = new System.Drawing.Point(534, 82);
            this.passedTime.Name = "passedTime";
            this.passedTime.Size = new System.Drawing.Size(0, 17);
            this.passedTime.TabIndex = 7;
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(190, 68);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 8;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // tmr_emulation
            // 
            this.tmr_emulation.Interval = 1000;
            this.tmr_emulation.Tick += new System.EventHandler(this.tmr_emulation_Tick);
            // 
            // Distance
            // 
            this.Distance.Location = new System.Drawing.Point(13, 12);
            this.Distance.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.Distance.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Distance.Name = "Distance";
            this.Distance.Size = new System.Drawing.Size(99, 22);
            this.Distance.TabIndex = 9;
            this.Distance.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Speed
            // 
            this.Speed.Location = new System.Drawing.Point(13, 40);
            this.Speed.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.Speed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Speed.Name = "Speed";
            this.Speed.Size = new System.Drawing.Size(99, 22);
            this.Speed.TabIndex = 10;
            this.Speed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Location = new System.Drawing.Point(534, 82);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(0, 17);
            this.total.TabIndex = 11;
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(640, 68);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(63, 31);
            this.backBtn.TabIndex = 12;
            this.backBtn.Text = "Назад";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 103);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.total);
            this.Controls.Add(this.Speed);
            this.Controls.Add(this.Distance);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.passedTime);
            this.Controls.Add(this.remainingTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Graph);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Вычисление времени";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Distance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Speed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar Graph;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label remainingTime;
        private System.Windows.Forms.Label passedTime;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Timer tmr_emulation;
        private System.Windows.Forms.NumericUpDown Distance;
        private System.Windows.Forms.NumericUpDown Speed;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Button backBtn;
    }
}

