namespace proje
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            textBox1 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            dataGridView1 = new DataGridView();
            button6 = new Button();
            textBox8 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Tomato;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(868, 153);
            button1.Name = "button1";
            button1.Size = new Size(159, 57);
            button1.TabIndex = 0;
            button1.Text = "LİSTELE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Tomato;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(868, 239);
            button2.Name = "button2";
            button2.Size = new Size(159, 57);
            button2.TabIndex = 1;
            button2.Text = "EKLEME";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Tomato;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(868, 333);
            button3.Name = "button3";
            button3.Size = new Size(159, 57);
            button3.TabIndex = 2;
            button3.Text = "GÜNCELLEME";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Tomato;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(868, 419);
            button4.Name = "button4";
            button4.Size = new Size(159, 57);
            button4.TabIndex = 3;
            button4.Text = "ARAMA";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Tomato;
            button5.FlatAppearance.BorderColor = Color.Black;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(868, 506);
            button5.Name = "button5";
            button5.Size = new Size(159, 57);
            button5.TabIndex = 4;
            button5.Text = "SİLME";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.CadetBlue;
            textBox1.Location = new Point(56, 183);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Otel No:";
            textBox1.Size = new Size(154, 27);
            textBox1.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.CadetBlue;
            textBox4.Location = new Point(56, 254);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Adı";
            textBox4.Size = new Size(154, 27);
            textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.CadetBlue;
            textBox5.Location = new Point(56, 322);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Yıldız Sayısı";
            textBox5.Size = new Size(154, 27);
            textBox5.TabIndex = 11;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.CadetBlue;
            textBox6.Location = new Point(56, 392);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "Adresi";
            textBox6.Size = new Size(154, 27);
            textBox6.TabIndex = 12;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Beige;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(252, 256);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(594, 334);
            dataGridView1.TabIndex = 14;
            // 
            // button6
            // 
            button6.BackColor = Color.CadetBlue;
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(445, 600);
            button6.Name = "button6";
            button6.Size = new Size(197, 53);
            button6.TabIndex = 15;
            button6.Text = "Ana Sayfaya Dön";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // textBox8
            // 
            textBox8.BackColor = Color.CadetBlue;
            textBox8.ForeColor = Color.White;
            textBox8.Location = new Point(12, 482);
            textBox8.Name = "textBox8";
            textBox8.PlaceholderText = "OTEL ADI ARAMA";
            textBox8.Size = new Size(234, 27);
            textBox8.TabIndex = 16;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1128, 665);
            Controls.Add(textBox8);
            Controls.Add(button6);
            Controls.Add(dataGridView1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private TextBox textBox1;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private DataGridView dataGridView1;
        private Button button6;
        private TextBox textBox8;
    }
}