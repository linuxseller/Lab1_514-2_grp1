namespace Lab1_514_2_grp1
{
    partial class Lab1
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
            inputMtx = new Button();
            task1Btn = new Button();
            mtxDoneLabel = new Label();
            label3 = new Label();
            nTextBox = new TextBox();
            label5 = new Label();
            constantTextBox = new TextBox();
            fillRandomMtxBtn = new Button();
            inputVector1Btn = new Button();
            fillRandomVec1Btn = new Button();
            fillRandomVec2Btn = new Button();
            inputVector2Btn = new Button();
            vec1DoneLabel = new Label();
            vec2DoneLabel = new Label();
            task2Btn = new Button();
            task3Btn = new Button();
            task4Btn = new Button();
            task5Btn = new Button();
            task6Btn = new Button();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // inputMtx
            // 
            inputMtx.Location = new Point(29, 35);
            inputMtx.Name = "inputMtx";
            inputMtx.Size = new Size(111, 23);
            inputMtx.TabIndex = 0;
            inputMtx.Text = "Ввод матрицы";
            inputMtx.UseVisualStyleBackColor = true;
            inputMtx.Click += inputMtx_Click;
            // 
            // task1Btn
            // 
            task1Btn.Location = new Point(29, 150);
            task1Btn.Name = "task1Btn";
            task1Btn.Size = new Size(310, 23);
            task1Btn.TabIndex = 2;
            task1Btn.Text = "Матрица*константа";
            task1Btn.UseVisualStyleBackColor = true;
            task1Btn.Click += task1Btn_Click;
            // 
            // mtxDoneLabel
            // 
            mtxDoneLabel.AutoSize = true;
            mtxDoneLabel.Location = new Point(301, 39);
            mtxDoneLabel.Name = "mtxDoneLabel";
            mtxDoneLabel.Size = new Size(31, 15);
            mtxDoneLabel.TabIndex = 5;
            mtxDoneLabel.Text = "false";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 9);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 7;
            label3.Text = "n =";
            // 
            // nTextBox
            // 
            nTextBox.Location = new Point(60, 6);
            nTextBox.Name = "nTextBox";
            nTextBox.Size = new Size(113, 23);
            nTextBox.TabIndex = 8;
            nTextBox.Leave += nTextBox_Leave;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 125);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 11;
            label5.Text = "константа =";
            // 
            // constantTextBox
            // 
            constantTextBox.Location = new Point(108, 122);
            constantTextBox.Name = "constantTextBox";
            constantTextBox.Size = new Size(231, 23);
            constantTextBox.TabIndex = 12;
            // 
            // fillRandomMtxBtn
            // 
            fillRandomMtxBtn.Location = new Point(146, 35);
            fillRandomMtxBtn.Name = "fillRandomMtxBtn";
            fillRandomMtxBtn.Size = new Size(149, 23);
            fillRandomMtxBtn.TabIndex = 15;
            fillRandomMtxBtn.Text = "Случайное заполнение";
            fillRandomMtxBtn.UseVisualStyleBackColor = true;
            fillRandomMtxBtn.Click += fillRandomMtxBtn_Click;
            // 
            // inputVector1Btn
            // 
            inputVector1Btn.Location = new Point(29, 64);
            inputVector1Btn.Name = "inputVector1Btn";
            inputVector1Btn.Size = new Size(111, 23);
            inputVector1Btn.TabIndex = 16;
            inputVector1Btn.Text = "Ввод вектора 1";
            inputVector1Btn.UseVisualStyleBackColor = true;
            inputVector1Btn.Click += inputVector1Btn_Click;
            // 
            // fillRandomVec1Btn
            // 
            fillRandomVec1Btn.Location = new Point(146, 64);
            fillRandomVec1Btn.Name = "fillRandomVec1Btn";
            fillRandomVec1Btn.Size = new Size(149, 23);
            fillRandomVec1Btn.TabIndex = 17;
            fillRandomVec1Btn.Text = "Случайное заполнение";
            fillRandomVec1Btn.UseVisualStyleBackColor = true;
            fillRandomVec1Btn.Click += fillRandomVec1Btn_Click;
            // 
            // fillRandomVec2Btn
            // 
            fillRandomVec2Btn.Location = new Point(146, 93);
            fillRandomVec2Btn.Name = "fillRandomVec2Btn";
            fillRandomVec2Btn.Size = new Size(149, 23);
            fillRandomVec2Btn.TabIndex = 19;
            fillRandomVec2Btn.Text = "Случайное заполнение";
            fillRandomVec2Btn.UseVisualStyleBackColor = true;
            fillRandomVec2Btn.Click += fillRandomVec2Btn_Click;
            // 
            // inputVector2Btn
            // 
            inputVector2Btn.Location = new Point(29, 93);
            inputVector2Btn.Name = "inputVector2Btn";
            inputVector2Btn.Size = new Size(111, 23);
            inputVector2Btn.TabIndex = 18;
            inputVector2Btn.Text = "Ввод вектора 2";
            inputVector2Btn.UseVisualStyleBackColor = true;
            inputVector2Btn.Click += inputVector2Btn_Click;
            // 
            // vec1DoneLabel
            // 
            vec1DoneLabel.AutoSize = true;
            vec1DoneLabel.Location = new Point(301, 68);
            vec1DoneLabel.Name = "vec1DoneLabel";
            vec1DoneLabel.Size = new Size(31, 15);
            vec1DoneLabel.TabIndex = 20;
            vec1DoneLabel.Text = "false";
            // 
            // vec2DoneLabel
            // 
            vec2DoneLabel.AutoSize = true;
            vec2DoneLabel.Location = new Point(301, 97);
            vec2DoneLabel.Name = "vec2DoneLabel";
            vec2DoneLabel.Size = new Size(31, 15);
            vec2DoneLabel.TabIndex = 21;
            vec2DoneLabel.Text = "false";
            // 
            // task2Btn
            // 
            task2Btn.Location = new Point(29, 179);
            task2Btn.Name = "task2Btn";
            task2Btn.Size = new Size(310, 23);
            task2Btn.TabIndex = 22;
            task2Btn.Text = "Модуль вектора";
            task2Btn.UseVisualStyleBackColor = true;
            task2Btn.Click += task2Btn_Click;
            // 
            // task3Btn
            // 
            task3Btn.Location = new Point(29, 208);
            task3Btn.Name = "task3Btn";
            task3Btn.Size = new Size(310, 23);
            task3Btn.TabIndex = 23;
            task3Btn.Text = "(vec, vec)";
            task3Btn.UseVisualStyleBackColor = true;
            task3Btn.Click += task3Btn_Click;
            // 
            // task4Btn
            // 
            task4Btn.Location = new Point(29, 237);
            task4Btn.Name = "task4Btn";
            task4Btn.Size = new Size(310, 23);
            task4Btn.TabIndex = 24;
            task4Btn.Text = "[vec, vec]";
            task4Btn.UseVisualStyleBackColor = true;
            task4Btn.Click += task4Btn_Click;
            // 
            // task5Btn
            // 
            task5Btn.Location = new Point(29, 266);
            task5Btn.Name = "task5Btn";
            task5Btn.Size = new Size(310, 23);
            task5Btn.TabIndex = 25;
            task5Btn.Text = "A^T";
            task5Btn.UseVisualStyleBackColor = true;
            task5Btn.Click += task5Btn_Click;
            // 
            // task6Btn
            // 
            task6Btn.Location = new Point(29, 295);
            task6Btn.Name = "task6Btn";
            task6Btn.Size = new Size(310, 23);
            task6Btn.TabIndex = 26;
            task6Btn.Text = "Вектор*константа";
            task6Btn.UseVisualStyleBackColor = true;
            task6Btn.Click += task6Btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(345, 154);
            label1.Name = "label1";
            label1.Size = new Size(121, 15);
            label1.TabIndex = 27;
            label1.Text = "Юрченко Александр";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(345, 183);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 28;
            label2.Text = "Коренюк Диана";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(345, 212);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 29;
            label4.Text = "Коренюк Диана";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(345, 241);
            label6.Name = "label6";
            label6.Size = new Size(97, 15);
            label6.TabIndex = 30;
            label6.Text = "Пестрецов Илья";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(345, 270);
            label7.Name = "label7";
            label7.Size = new Size(102, 15);
            label7.TabIndex = 31;
            label7.Text = "Васильева Алина";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(345, 299);
            label8.Name = "label8";
            label8.Size = new Size(35, 15);
            label8.TabIndex = 32;
            label8.Text = "Илья";
            // 
            // Lab1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(task6Btn);
            Controls.Add(task5Btn);
            Controls.Add(task4Btn);
            Controls.Add(task3Btn);
            Controls.Add(task2Btn);
            Controls.Add(vec2DoneLabel);
            Controls.Add(vec1DoneLabel);
            Controls.Add(fillRandomVec2Btn);
            Controls.Add(inputVector2Btn);
            Controls.Add(fillRandomVec1Btn);
            Controls.Add(inputVector1Btn);
            Controls.Add(fillRandomMtxBtn);
            Controls.Add(constantTextBox);
            Controls.Add(label5);
            Controls.Add(nTextBox);
            Controls.Add(label3);
            Controls.Add(mtxDoneLabel);
            Controls.Add(task1Btn);
            Controls.Add(inputMtx);
            Name = "Lab1";
            Text = "Зад. Руковод";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button inputMtx;
        private Button task1Btn;
        private Label mtxDoneLabel;
        private Label label3;
        private TextBox nTextBox;
        private Label label5;
        private TextBox constantTextBox;
        private Button fillRandomMtxBtn;
        private Button inputVector1Btn;
        private Button fillRandomVec1Btn;
        private Button fillRandomVec2Btn;
        private Button inputVector2Btn;
        private Label vec1DoneLabel;
        private Label vec2DoneLabel;
        private Button task2Btn;
        private Button task3Btn;
        private Button task4Btn;
        private Button task5Btn;
        private Button task6Btn;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}
