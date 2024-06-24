namespace Lab3_sem2
{
    partial class TFormTest
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
            this.RTB_Question = new System.Windows.Forms.RichTextBox();
            this.GB_rbAnswers = new System.Windows.Forms.GroupBox();
            this.TB_TextAswer = new System.Windows.Forms.TextBox();
            this.BT_Next = new System.Windows.Forms.Button();
            this.BT_Start = new System.Windows.Forms.Button();
            this.label_que_num = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // RTB_Question
            // 
            this.RTB_Question.Location = new System.Drawing.Point(142, 58);
            this.RTB_Question.Name = "RTB_Question";
            this.RTB_Question.Size = new System.Drawing.Size(605, 43);
            this.RTB_Question.TabIndex = 0;
            this.RTB_Question.Text = "";
            // 
            // GB_rbAnswers
            // 
            this.GB_rbAnswers.Location = new System.Drawing.Point(142, 116);
            this.GB_rbAnswers.Name = "GB_rbAnswers";
            this.GB_rbAnswers.Size = new System.Drawing.Size(174, 252);
            this.GB_rbAnswers.TabIndex = 2;
            this.GB_rbAnswers.TabStop = false;
            this.GB_rbAnswers.Text = "Варианты ответов";
            this.GB_rbAnswers.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // TB_TextAswer
            // 
            this.TB_TextAswer.Location = new System.Drawing.Point(322, 125);
            this.TB_TextAswer.Name = "TB_TextAswer";
            this.TB_TextAswer.Size = new System.Drawing.Size(174, 22);
            this.TB_TextAswer.TabIndex = 3;
            this.TB_TextAswer.Visible = false;
            // 
            // BT_Next
            // 
            this.BT_Next.Location = new System.Drawing.Point(387, 339);
            this.BT_Next.Name = "BT_Next";
            this.BT_Next.Size = new System.Drawing.Size(94, 23);
            this.BT_Next.TabIndex = 4;
            this.BT_Next.Text = "Следующий";
            this.BT_Next.UseVisualStyleBackColor = true;
            this.BT_Next.Click += new System.EventHandler(this.BT_Next_Click);
            // 
            // BT_Start
            // 
            this.BT_Start.Location = new System.Drawing.Point(12, 31);
            this.BT_Start.Name = "BT_Start";
            this.BT_Start.Size = new System.Drawing.Size(94, 23);
            this.BT_Start.TabIndex = 5;
            this.BT_Start.Text = "Начать";
            this.BT_Start.UseVisualStyleBackColor = true;
            this.BT_Start.Click += new System.EventHandler(this.BT_start_click);
            // 
            // label_que_num
            // 
            this.label_que_num.AutoSize = true;
            this.label_que_num.Location = new System.Drawing.Point(139, 31);
            this.label_que_num.Name = "label_que_num";
            this.label_que_num.Size = new System.Drawing.Size(44, 16);
            this.label_que_num.TabIndex = 6;
            this.label_que_num.Text = "label1";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(545, 280);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(103, 20);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // TFormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 388);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.TB_TextAswer);
            this.Controls.Add(this.label_que_num);
            this.Controls.Add(this.BT_Start);
            this.Controls.Add(this.BT_Next);
            this.Controls.Add(this.GB_rbAnswers);
            this.Controls.Add(this.RTB_Question);
            this.Name = "TFormTest";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox RTB_Question;
        private System.Windows.Forms.GroupBox GB_rbAnswers;
        private System.Windows.Forms.TextBox TB_TextAswer;
        private System.Windows.Forms.Button BT_Next;
        private System.Windows.Forms.Button BT_Start;
        private System.Windows.Forms.Label label_que_num;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}