namespace Ejercicio5
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
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InactiveCaption;
            textBox1.Location = new Point(160, 150);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(189, 31);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.RosyBrown;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(160, 225);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(419, 154);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Gainsboro;
            button1.Location = new Point(395, 127);
            button1.Name = "button1";
            button1.Size = new Size(159, 77);
            button1.TabIndex = 2;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private ListBox listBox1;
        private Button button1;
    }
}
