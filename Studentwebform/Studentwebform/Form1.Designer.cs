﻿namespace Studentwebform
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label5 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            label6 = new Label();
            textBox5 = new TextBox();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(181, 118);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(352, 111);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(198, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(352, 177);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(198, 27);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(181, 184);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 2;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(181, 234);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 4;
            label3.Text = "PhoneNumber";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(181, 296);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 5;
            label4.Text = "Collage";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(352, 231);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(198, 27);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(352, 293);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(198, 27);
            textBox4.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(191, 378);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 8;
            label5.Text = "Branch";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "CS" });
            comboBox1.Location = new Point(352, 370);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(198, 28);
            comboBox1.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(168, 472);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 10;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(325, 472);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 11;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(181, 66);
            label6.Name = "label6";
            label6.Size = new Size(73, 20);
            label6.TabIndex = 12;
            label6.Text = "StudentId";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(352, 59);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(198, 27);
            textBox5.TabIndex = 13;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // button3
            // 
            button3.Location = new Point(474, 472);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 14;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(624, 472);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 15;
            button4.Text = "Clear";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 805);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label5;
        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
        private Label label6;
        private TextBox textBox5;
        private Button button3;
        private Button button4;
    }
}
