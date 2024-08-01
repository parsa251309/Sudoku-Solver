namespace Sudoku_Solver
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
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            btnSolve = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(602, 595);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.Paint += Draw;
            pictureBox1.MouseClick += pictureBox1_MouseClick;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += Update;
            // 
            // btnSolve
            // 
            btnSolve.Location = new Point(610, 392);
            btnSolve.Name = "btnSolve";
            btnSolve.Size = new Size(186, 64);
            btnSolve.TabIndex = 1;
            btnSolve.Text = "Solve";
            btnSolve.UseVisualStyleBackColor = true;
            btnSolve.Click += btnSolve_Click;
            // 
            // button1
            // 
            button1.Location = new Point(0, 603);
            button1.Name = "button1";
            button1.Size = new Size(94, 68);
            button1.TabIndex = 2;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += ButtonsClick;
            // 
            // button2
            // 
            button2.Location = new Point(100, 603);
            button2.Name = "button2";
            button2.Size = new Size(94, 68);
            button2.TabIndex = 3;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += ButtonsClick;
            // 
            // button3
            // 
            button3.Location = new Point(200, 603);
            button3.Name = "button3";
            button3.Size = new Size(94, 68);
            button3.TabIndex = 4;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += ButtonsClick;
            // 
            // button4
            // 
            button4.Location = new Point(300, 603);
            button4.Name = "button4";
            button4.Size = new Size(94, 68);
            button4.TabIndex = 5;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += ButtonsClick;
            // 
            // button5
            // 
            button5.Location = new Point(500, 603);
            button5.Name = "button5";
            button5.Size = new Size(94, 68);
            button5.TabIndex = 6;
            button5.Text = "6";
            button5.UseVisualStyleBackColor = true;
            button5.Click += ButtonsClick;
            // 
            // button6
            // 
            button6.Location = new Point(400, 603);
            button6.Name = "button6";
            button6.Size = new Size(94, 68);
            button6.TabIndex = 7;
            button6.Text = "5";
            button6.UseVisualStyleBackColor = true;
            button6.Click += ButtonsClick;
            // 
            // button7
            // 
            button7.Location = new Point(600, 603);
            button7.Name = "button7";
            button7.Size = new Size(94, 68);
            button7.TabIndex = 8;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += ButtonsClick;
            // 
            // button8
            // 
            button8.Location = new Point(700, 603);
            button8.Name = "button8";
            button8.Size = new Size(94, 68);
            button8.TabIndex = 9;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += ButtonsClick;
            // 
            // button9
            // 
            button9.Location = new Point(607, 529);
            button9.Name = "button9";
            button9.Size = new Size(187, 68);
            button9.TabIndex = 10;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += ButtonsClick;
            // 
            // button10
            // 
            button10.Location = new Point(608, 460);
            button10.Name = "button10";
            button10.Size = new Size(187, 68);
            button10.TabIndex = 11;
            button10.Text = "0";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 673);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnSolve);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private Button btnSolve;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
    }
}
