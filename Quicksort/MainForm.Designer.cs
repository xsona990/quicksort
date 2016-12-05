namespace Quicksort
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.elCountBox = new System.Windows.Forms.TextBox();
            this.generatedArrayBox = new System.Windows.Forms.RichTextBox();
            this.sortedArrayBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.maxValueBox = new System.Windows.Forms.TextBox();
            this.minValueBox = new System.Windows.Forms.TextBox();
            this.generateBtn = new System.Windows.Forms.Button();
            this.sortBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Array elements count:";
            // 
            // elCountBox
            // 
            this.elCountBox.Location = new System.Drawing.Point(128, 10);
            this.elCountBox.Name = "elCountBox";
            this.elCountBox.Size = new System.Drawing.Size(52, 20);
            this.elCountBox.TabIndex = 1;
            // 
            // generatedArrayBox
            // 
            this.generatedArrayBox.Location = new System.Drawing.Point(16, 58);
            this.generatedArrayBox.Name = "generatedArrayBox";
            this.generatedArrayBox.ReadOnly = true;
            this.generatedArrayBox.Size = new System.Drawing.Size(277, 179);
            this.generatedArrayBox.TabIndex = 2;
            this.generatedArrayBox.TabStop = false;
            this.generatedArrayBox.Text = "";
            // 
            // sortedArrayBox
            // 
            this.sortedArrayBox.Location = new System.Drawing.Point(301, 58);
            this.sortedArrayBox.Name = "sortedArrayBox";
            this.sortedArrayBox.ReadOnly = true;
            this.sortedArrayBox.Size = new System.Drawing.Size(315, 179);
            this.sortedArrayBox.TabIndex = 3;
            this.sortedArrayBox.TabStop = false;
            this.sortedArrayBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Generated Array: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(360, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "MAX Random value:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "MIN Random Value:";
            // 
            // maxValueBox
            // 
            this.maxValueBox.Location = new System.Drawing.Point(471, 10);
            this.maxValueBox.Name = "maxValueBox";
            this.maxValueBox.Size = new System.Drawing.Size(52, 20);
            this.maxValueBox.TabIndex = 8;
            // 
            // minValueBox
            // 
            this.minValueBox.Location = new System.Drawing.Point(299, 10);
            this.minValueBox.Name = "minValueBox";
            this.minValueBox.Size = new System.Drawing.Size(52, 20);
            this.minValueBox.TabIndex = 7;
            // 
            // generateBtn
            // 
            this.generateBtn.Location = new System.Drawing.Point(16, 243);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(183, 23);
            this.generateBtn.TabIndex = 9;
            this.generateBtn.Text = "Generate";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // sortBtn
            // 
            this.sortBtn.Location = new System.Drawing.Point(223, 243);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(183, 23);
            this.sortBtn.TabIndex = 10;
            this.sortBtn.Text = "Sort";
            this.sortBtn.UseVisualStyleBackColor = true;
            this.sortBtn.Click += new System.EventHandler(this.sortBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(428, 243);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(183, 23);
            this.exitBtn.TabIndex = 11;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(298, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Soted Array: ";
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(13, 273);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(603, 23);
            this.progress.TabIndex = 13;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(14, 299);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 13);
            this.status.TabIndex = 14;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 318);
            this.Controls.Add(this.status);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.sortBtn);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.minValueBox);
            this.Controls.Add(this.maxValueBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sortedArrayBox);
            this.Controls.Add(this.generatedArrayBox);
            this.Controls.Add(this.elCountBox);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "QuicksortDemostrationApp";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox elCountBox;
        private System.Windows.Forms.RichTextBox generatedArrayBox;
        private System.Windows.Forms.RichTextBox sortedArrayBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox maxValueBox;
        private System.Windows.Forms.TextBox minValueBox;
        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.Button sortBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.Label status;
    }
}

