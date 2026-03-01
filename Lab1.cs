using System.DirectoryServices;

namespace Lab1_514_2_grp1
{
    public partial class Lab1 : Form
    {
        const int MaxN = 4;
        int n = 3;
        TextBox[,] MatrText = null;
        public TextBox[,] ResMatrText = null;
        double[,] inMtx = new double[MaxN, MaxN];
        double[] inVec1 = new double[MaxN];
        double[] inVec2 = new double[MaxN];
        double constant = 0;
        bool fmtx, fvec1, fvec2;
        int dx = 40, dy = 20;
        InputMtxForm form2 = null;
        ResultForm resultForm = null;
        public Lab1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            nTextBox.Text = "";
            mtxDoneLabel.Text = "false";
            int i, j;
            form2 = new InputMtxForm();
            resultForm = new ResultForm();
            MatrText = new TextBox[MaxN, MaxN];
            ResMatrText = new TextBox[MaxN, MaxN];
            for (i = 0; i < MaxN; i++)
                for (j = 0; j < MaxN; j++)
                {
                    MatrText[i, j] = new TextBox();
                    MatrText[i, j].Text = "0";
                    MatrText[i, j].Location = new System.Drawing.Point(10 + i * dx, 10 + j * dy);
                    MatrText[i, j].Size = new System.Drawing.Size(dx, dy);
                    MatrText[i, j].Visible = false;
                    form2.Controls.Add(MatrText[i, j]);

                    ResMatrText[i, j] = new TextBox();
                    ResMatrText[i, j].Text = "0";
                    ResMatrText[i, j].Location = new System.Drawing.Point(10 + i * dx, 10 + j * dy);
                    ResMatrText[i, j].Size = new System.Drawing.Size(dx, dy);
                    ResMatrText[i, j].Visible = false;
                    resultForm.Controls.Add(ResMatrText[i, j]);
                }
        }
        private void prepareInput(bool prepareMatrix)
        {
            for (int i = 0; i < MaxN; i++)
                for (int j = 0; j < MaxN; j++)
                {
                    MatrText[i, j].Visible = false;
                }
            if (nTextBox.Text == "") return;
            n = int.Parse(nTextBox.Text);
            if (prepareMatrix)
            {
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                    {
                        MatrText[i, j].TabIndex = i * n + j + 1;
                        MatrText[i, j].Visible = true;
                    }
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    MatrText[i, 0].TabIndex = i * n + 1;
                    MatrText[i, 0].Visible = true;
                }
            }
            form2.Width = 10 + n * dx + 20;
            form2.Height = 10 + n * dy + form2.button1.Height + 50;
            form2.button1.Left = 10;
            form2.button1.Top = 10 + n * dy + 10;
        }
        private void inputMtx_Click(object sender, EventArgs e)
        {
            prepareInput(prepareMatrix: true);
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    MatrText[i, j].Text = inMtx[i, j].ToString();
            if (form2.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                        if (MatrText[i, j].Text != "")
                            inMtx[i, j] = Double.Parse(MatrText[i, j].Text);
                        else
                            inMtx[i, j] = 0;
                fmtx = true;
                mtxDoneLabel.Text = "true";
            }
        }
        private void inputVector1Btn_Click(object sender, EventArgs e)
        {
            prepareInput(prepareMatrix: false);
            for (int i = 0; i < n; i++)
            {
                MatrText[i, 0].Text = inVec1[i].ToString();
            }
            if (form2.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < n; i++)
                    if (MatrText[i, 0].Text != "")
                        inVec1[i] = Double.Parse(MatrText[i, 0].Text);
                    else
                        inVec1[i] = 0;
                fmtx = true;
                mtxDoneLabel.Text = "true";
            }
        }
        private void inputVector2Btn_Click(object sender, EventArgs e)
        {
            prepareInput(prepareMatrix: false);

            for (int i = 0; i < n; i++)
            {
                MatrText[i, 0].Text = inVec2[i].ToString();
            }
            if (form2.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < n; i++)
                    if (MatrText[i, 0].Text != "")
                        inVec2[i] = Double.Parse(MatrText[i, 0].Text);
                    else
                        inVec2[i] = 0;
                fmtx = true;
                mtxDoneLabel.Text = "true";
            }
        }
        private void resetResult()
        {
            for (int i = 0; i < MaxN; i++)
                for (int j = 0; j < MaxN; j++)
                    ResMatrText[i, j].Visible = false;
        }
        private void task1Btn_Click(object sender, EventArgs e)
        {
            resetResult();
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    ResMatrText[i, j].TabIndex = i * n + j + 1;
                    ResMatrText[i, j].Visible = true;
                }
            double constant = Double.Parse(constantTextBox.Text);
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    ResMatrText[i, j].Text = (inMtx[i, j] * constant).ToString();
            resultForm.ShowDialog();
        }

        private void task2Btn_Click(object sender, EventArgs e)
        {
            resetResult();
            ResMatrText[0, 0].TabIndex = 1;
            ResMatrText[0, 0].Visible = true;
            double res = 0;
            for (int i = 0; i < n; i++)
                res += inVec1[i] * inVec1[i];
            ResMatrText[0, 0].Text = Math.Sqrt(res).ToString();
            resultForm.ShowDialog();
        }

        private void task3Btn_Click(object sender, EventArgs e)
        {
            resetResult();
            ResMatrText[0, 0].TabIndex = 1;
            ResMatrText[0, 0].Visible = true;
            double res = 0;
            for (int i = 0; i < n; i++)
                res += inVec1[i] * inVec2[i];
            ResMatrText[0, 0].Text = Math.Sqrt(res).ToString();
            resultForm.ShowDialog();
        }

        private void task5Btn_Click(object sender, EventArgs e)
        {
            resetResult();
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    ResMatrText[i, j].TabIndex = i * n + j + 1;
                    ResMatrText[i, j].Visible = true;
                }
            double constant = Double.Parse(constantTextBox.Text);
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    ResMatrText[i, j].Text = (inMtx[j, i]).ToString();
            resultForm.ShowDialog();
        }

        private void task4Btn_Click(object sender, EventArgs e)
        {
            resetResult();
            // FIXME: вывод ошибки при n!=3
            if (n != 3)
            {
                return;
            }
            for (int i = 0; i < 3; i++)
            {
                ResMatrText[i, 0].TabIndex = i * n + 1;
                ResMatrText[i, 0].Visible = true;
            }
            ResMatrText[0, 0].Text = (inVec1[1] * inVec2[2] - inVec1[2] * inVec2[1]).ToString();
            ResMatrText[1, 0].Text = (inVec1[2] * inVec2[0] - inVec1[0] * inVec2[2]).ToString();
            ResMatrText[2, 0].Text = (inVec1[0] * inVec2[1] - inVec1[1] * inVec2[0]).ToString();
            resultForm.ShowDialog();
        }

        private void task6Btn_Click(object sender, EventArgs e)
        {
            resetResult();
            for (int i = 0; i < n; i++)
            {
                ResMatrText[i, 0].TabIndex = i * n + 1;
                ResMatrText[i, 0].Visible = true;
            }
            double constant = Double.Parse(constantTextBox.Text);
            for (int i = 0; i < n; i++)
                ResMatrText[i, 0].Text = (inVec1[i] * constant).ToString();
            resultForm.ShowDialog();
        }

        private void fillRandomMtxBtn_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 0; i < MaxN; i++)
                for (int j = 0; j < MaxN; j++)
                {
                    inMtx[i, j] = rnd.Next(-10, 10);
                }
            fmtx = true;
            mtxDoneLabel.Text = "true";
        }
        private void fillRandomVec1Btn_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                inVec1[i] = rnd.Next(-10, 10);
            fvec1 = true;
            vec1DoneLabel.Text = "true";
        }
        private void fillRandomVec2Btn_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                inVec2[i] = rnd.Next(-10, 10);
            fvec2 = true;
            vec2DoneLabel.Text = "true";
        }

        private void nTextBox_Leave(object sender, EventArgs e)
        {
            if (nTextBox.Text == "") return;
            int nn = int.Parse(nTextBox.Text);
            if (nn != n)
            {
                fmtx = fvec1 = fvec2 = false;
                vec1DoneLabel.Text = vec2DoneLabel.Text = mtxDoneLabel.Text = "false";
            }
        }
    }
}
