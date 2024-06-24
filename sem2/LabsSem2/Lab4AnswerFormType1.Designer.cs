namespace Lab3_sem2
{
    partial class Lab4AnswerFormType1
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
            this.answer_textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // answer_textBox1
            // 
            this.answer_textBox1.Location = new System.Drawing.Point(449, 345);
            this.answer_textBox1.Name = "answer_textBox1";
            this.answer_textBox1.Size = new System.Drawing.Size(286, 22);
            this.answer_textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(449, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(286, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ответить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(234, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(744, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Как сокращенно называют числовое программное управление (аббревиатура)";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(449, 424);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(286, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "Пропустить вопрос";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.skip_question_button_Click);
            // 
            // Lab4AnswerFormType1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 795);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.answer_textBox1);
            this.Name = "Lab4AnswerFormType1";
            this.Text = "Lab4CalculateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox answer_textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}