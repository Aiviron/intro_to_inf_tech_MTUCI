﻿namespace Lab3_sem2
{
    partial class Lab4AnswerFormType5
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
            this.button1 = new System.Windows.Forms.Button();
            this.answer_radioButton1 = new System.Windows.Forms.RadioButton();
            this.answer_radioButton2 = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(438, 608);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(303, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ответить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // answer_radioButton1
            // 
            this.answer_radioButton1.AutoSize = true;
            this.answer_radioButton1.Location = new System.Drawing.Point(31, 98);
            this.answer_radioButton1.Name = "answer_radioButton1";
            this.answer_radioButton1.Size = new System.Drawing.Size(302, 20);
            this.answer_radioButton1.TabIndex = 1;
            this.answer_radioButton1.Text = "Аналитическая система учета персонала";
            this.answer_radioButton1.UseVisualStyleBackColor = true;
            // 
            // answer_radioButton2
            // 
            this.answer_radioButton2.AutoSize = true;
            this.answer_radioButton2.Location = new System.Drawing.Point(31, 136);
            this.answer_radioButton2.Name = "answer_radioButton2";
            this.answer_radioButton2.Size = new System.Drawing.Size(416, 20);
            this.answer_radioButton2.TabIndex = 2;
            this.answer_radioButton2.Text = "Автоматизированная система управления производством";
            this.answer_radioButton2.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(31, 334);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(474, 132);
            this.listBox1.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(621, 284);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(498, 22);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(91, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Что относится к основным функциям АСУП?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(28, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(346, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Как расшифровывается аббревиатура АСУП?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(618, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(501, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "3. Каким термином обозначают внедрение АСУП на предприятии?";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(438, 692);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(303, 51);
            this.button2.TabIndex = 9;
            this.button2.Text = "Пропустить вопрос";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.skip_question_button_Click);
            // 
            // Lab4AnswerFormType5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 764);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.answer_radioButton2);
            this.Controls.Add(this.answer_radioButton1);
            this.Controls.Add(this.button1);
            this.Name = "Lab4AnswerFormType5";
            this.Text = "Lab4AnswerFormType6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton answer_radioButton1;
        private System.Windows.Forms.RadioButton answer_radioButton2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}