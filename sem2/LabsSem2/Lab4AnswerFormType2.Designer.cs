namespace Lab3_sem2
{
    partial class Lab4AnswerFormType2
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
            this.answer_radioButton1 = new System.Windows.Forms.RadioButton();
            this.answer_radioButton2 = new System.Windows.Forms.RadioButton();
            this.answer_radioButton3 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // answer_radioButton1
            // 
            this.answer_radioButton1.AutoSize = true;
            this.answer_radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answer_radioButton1.Location = new System.Drawing.Point(310, 233);
            this.answer_radioButton1.Name = "answer_radioButton1";
            this.answer_radioButton1.Size = new System.Drawing.Size(782, 29);
            this.answer_radioButton1.TabIndex = 0;
            this.answer_radioButton1.TabStop = true;
            this.answer_radioButton1.Text = "a) оптимизация производственных процессов и улучшение качества продукции";
            this.answer_radioButton1.UseVisualStyleBackColor = true;
            // 
            // answer_radioButton2
            // 
            this.answer_radioButton2.AutoSize = true;
            this.answer_radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answer_radioButton2.Location = new System.Drawing.Point(310, 282);
            this.answer_radioButton2.Name = "answer_radioButton2";
            this.answer_radioButton2.Size = new System.Drawing.Size(649, 29);
            this.answer_radioButton2.TabIndex = 1;
            this.answer_radioButton2.TabStop = true;
            this.answer_radioButton2.Text = "b) автоматизация управления персоналом и рабочим временем;";
            this.answer_radioButton2.UseVisualStyleBackColor = true;
            // 
            // answer_radioButton3
            // 
            this.answer_radioButton3.AutoSize = true;
            this.answer_radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answer_radioButton3.Location = new System.Drawing.Point(310, 333);
            this.answer_radioButton3.Name = "answer_radioButton3";
            this.answer_radioButton3.Size = new System.Drawing.Size(764, 29);
            this.answer_radioButton3.TabIndex = 2;
            this.answer_radioButton3.TabStop = true;
            this.answer_radioButton3.Text = "c) увеличение объемов продаж за счет улучшения маркетинговой стратегии.";
            this.answer_radioButton3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(521, 467);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ответить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(521, 508);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(218, 38);
            this.button2.TabIndex = 4;
            this.button2.Text = "Пропустить вопрос";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.skip_question_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(305, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(672, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Каковы основные цели внедрения АСУП на предприятии?";
            // 
            // Lab4AnswerFormType2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 758);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.answer_radioButton3);
            this.Controls.Add(this.answer_radioButton2);
            this.Controls.Add(this.answer_radioButton1);
            this.Name = "Lab4AnswerFormType2";
            this.Text = "Lab4AnswerFormType2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton answer_radioButton1;
        private System.Windows.Forms.RadioButton answer_radioButton2;
        private System.Windows.Forms.RadioButton answer_radioButton3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
    }
}