using System.DirectoryServices;

namespace Lab1_514_2_grp1
{
    /* 
     * В этом коде для ввода матриц и векторов используется всего один двумерный массив.
     * При вводе вектора просто отображается ввод матрицы m*1,
     * что позволяет использовать только один массив для ввода всех данных.
     * То есть для ввода отображается часть матрицы, и когда данные введены
     * они записываются в соответствующий массив -- inMtx, inVec1, inVec2.
     * При вводе другого вектора или другой матрицы используется тот-же массив полей ввода.
     * 
     * Результат операций никуда не сохраняется, он просто тут-же отображается в окне результата.
     */

    public partial class Lab1 : Form
    {
        // объявление и инициализация полей класса
        const int MaxN = 4; // по условию задания макс 4х4 матрица
        int n = 3; // дефолтное значение потому что почему нет
        TextBox[,] MatrText = null;
        public TextBox[,] ResMatrText = null;
        double[,] inMtx = new double[MaxN, MaxN]; // Вводимая матрица сохраняется сюда
        double[] inVec1 = new double[MaxN]; // аналогично первый вектор
        double[] inVec2 = new double[MaxN]; // и второй
        bool fmtx, fvec1, fvec2; // переменные для отслеживания введены ли соответствующие данные
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
            form2 = new InputMtxForm();
            resultForm = new ResultForm();
            MatrText = new TextBox[MaxN, MaxN];
            ResMatrText = new TextBox[MaxN, MaxN];
            for (int i = 0; i < MaxN; i++)
                for (int j = 0; j < MaxN; j++)
                {
                    // создание потенциальной разметки полей ввода
                    // (для полей которые должны будут быть отображены затем будет изменено поле Visible на true
                    // и текстовое поле будет отображено в этом месте)
                    MatrText[i, j] = new TextBox();
                    MatrText[i, j].Text = "0";
                    MatrText[i, j].Location = new System.Drawing.Point(10 + i * dx, 10 + j * dy);
                    MatrText[i, j].Size = new System.Drawing.Size(dx, dy);
                    MatrText[i, j].Visible = false;
                    form2.Controls.Add(MatrText[i, j]);

                    // Аналогично для разметки полей результата
                    ResMatrText[i, j] = new TextBox();
                    ResMatrText[i, j].Text = "0";
                    ResMatrText[i, j].Location = new System.Drawing.Point(10 + i * dx, 10 + j * dy);
                    ResMatrText[i, j].Size = new System.Drawing.Size(dx, dy);
                    ResMatrText[i, j].Visible = false;
                    resultForm.Controls.Add(ResMatrText[i, j]);
                }
        }
        /* Функция отвечающая за отображение лишних и скрытие нужных полей ввода
         * вызывается перед каждой из функций ввода матрицы или векторов
         * Так-же изменяет расположение кнопки "ОК" в зависимости от размера поля;
         */
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
        // функция обработчки нажатия кнопки ввода матрицы
        private void inputMtx_Click(object sender, EventArgs e)
        {
            // подготовка ввода
            prepareInput(prepareMatrix: true);
            // загрузка данных из массива матрицы в ячейки ввода
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    MatrText[i, j].Text = inMtx[i, j].ToString();
            // запуск окна ввода и выгрузка данных из текстовых полей ввода в массив матрицы
            if (form2.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                        if (MatrText[i, j].Text != "")
                            inMtx[i, j] = Double.Parse(MatrText[i, j].Text);
                        else
                            inMtx[i, j] = 0;
                // изменение статуса ввода матрицы
                fmtx = true;
                mtxDoneLabel.Text = "true";
            }
        }
        // функция обработчки нажатия кнопки ввода матрицы
        private void inputVector1Btn_Click(object sender, EventArgs e)
        {
            // подготовка ввода
            prepareInput(prepareMatrix: false);
            // загрузка данных из массива матрицы в ячейки ввода
            for (int i = 0; i < n; i++)
            {
                MatrText[i, 0].Text = inVec1[i].ToString();
            }
            // запуск окна ввода и выгрузка данных из текстовых полей ввода в массив вектора
            if (form2.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < n; i++)
                    if (MatrText[i, 0].Text != "")
                        inVec1[i] = Double.Parse(MatrText[i, 0].Text);
                    else
                        inVec1[i] = 0;
                // изменение статуса ввода матрицы
                fvec1 = true;
                vec1DoneLabel.Text = "true";
            }
        }
        // аналогично предыдущей функции
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
        /* 
         * скрытие всех ячеек вывода
         * (например когда при первом запуске был размер 3 а потом стал 2 позволя,
         * или при смене результата с матрицы на вектор или на число
         * (модуль вектора, скалярное произведение) и любые другие комбинации смены размера вывода
        */
        private void resetResult()
        {
            for (int i = 0; i < MaxN; i++)
                for (int j = 0; j < MaxN; j++)
                    ResMatrText[i, j].Visible = false;
        }
        // Задание 1: матрица на константу
        private void task1Btn_Click(object sender, EventArgs e)
        {
            if (!fmtx) {
                MessageBox.Show("Матрица не заполнена!");
                return;
            }
            // скрытие всех ячеек результата
            resetResult();
            // Отображение нужных ячеек матрицы
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    ResMatrText[i, j].TabIndex = i * n + j + 1;
                    ResMatrText[i, j].Visible = true;
                }
            // Чтение значения константы из поля ввода константы
            double constant = Double.Parse(constantTextBox.Text);
            // расчет значений произведения матрицы на константу и изменение значения в текстовом поле
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    ResMatrText[i, j].Text = (inMtx[i, j] * constant).ToString();
            // отобразить форму с результатом
            resultForm.ShowDialog();
        }
        // Задание 2: модуль вектора 1
        private void task2Btn_Click(object sender, EventArgs e)
        {
            if (!fvec1)
            {
                MessageBox.Show("Вектор 1 не заполнен!");
                return;
            }
            // скрытие всех ячеек результата
            resetResult();
            // модуль это одно число, отобразим только одну ячейку результата
            ResMatrText[0, 0].TabIndex = 1;
            ResMatrText[0, 0].Visible = true;
            // считаем сумму квадратов координат вектора 1
            double res = 0;
            for (int i = 0; i < n; i++)
                res += inVec1[i] * inVec1[i];
            // Записываем модуль вектора в первую ячейку результата
            ResMatrText[0, 0].Text = Math.Sqrt(res).ToString();
            // отобразить форму с результатом
            resultForm.ShowDialog();
        }
        // Задание 3: скалярное произведение векторов
        private void task3Btn_Click(object sender, EventArgs e)
        {
            if (!(fvec2 && fvec1))
            {
                MessageBox.Show("Вектора не заполнены!");
                return;
            }
            // скрытие всех ячеек результата
            resetResult();
            // скалярное произведение это одно число, отобразим только одну ячейку результата
            ResMatrText[0, 0].TabIndex = 1;
            ResMatrText[0, 0].Visible = true;
            // считаем сумму произведений координат векторов
            double res = 0;
            for (int i = 0; i < n; i++)
                res += inVec1[i] * inVec2[i];
            // Записываем скалярное произведение в первую ячейку результата
            ResMatrText[0, 0].Text = Math.Sqrt(res).ToString();
            // отобразить форму с результатом
            resultForm.ShowDialog();
        }
        // Задание 5: транспонирование матрицы
        // аналогично первому заданию с произведением матрицы на константу
        private void task5Btn_Click(object sender, EventArgs e)
        {
            if (!fmtx)
            {
                MessageBox.Show("Матрица не заполнена!");
                return;
            }
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
        // Задание 4: векторное произведение, определено только для трехмерных векторов
        private void task4Btn_Click(object sender, EventArgs e)
        {
            if (!(fvec2 && fvec1))
            {
                MessageBox.Show("Вектора не заполнены!");
                return;
            }
            resetResult();
            // FIXME: вывод ошибки при n!=3
            if (n != 3)
            {
                MessageBox.Show("Векторное произведение определено только для 3х мерных векторов");
                return;
            }
            for (int i = 0; i < 3; i++)
            {
                ResMatrText[i, 0].TabIndex = i * n + 1;
                ResMatrText[i, 0].Visible = true;
            }
            // формула векторного произведения
            ResMatrText[0, 0].Text = (inVec1[1] * inVec2[2] - inVec1[2] * inVec2[1]).ToString();
            ResMatrText[1, 0].Text = (inVec1[2] * inVec2[0] - inVec1[0] * inVec2[2]).ToString();
            ResMatrText[2, 0].Text = (inVec1[0] * inVec2[1] - inVec1[1] * inVec2[0]).ToString();
            resultForm.ShowDialog();
        }
        // Задание 7: произведение вектора на константу
        private void task6Btn_Click(object sender, EventArgs e)
        {
            if (!fvec1)
            {
                MessageBox.Show("Вектор 1 не заполнен!");
                return;
            }
            // скрытие всех ячеек результата
            resetResult();
            // Отобразим первую строку матрицы результатов, т.к. в результате получаем вектор
            for (int i = 0; i < n; i++)
            {
                ResMatrText[i, 0].TabIndex = i * n + 1;
                ResMatrText[i, 0].Visible = true;
            }
            double constant = Double.Parse(constantTextBox.Text);
            // расчет произведения вектора на константу
            for (int i = 0; i < n; i++)
                ResMatrText[i, 0].Text = (inVec1[i] * constant).ToString();
            // отобразить форму с результатом
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
        // когда поле ввода размера покидается выполняется этот хук
        private void nTextBox_Leave(object sender, EventArgs e)
        {
            if (nTextBox.Text == "") return;
            int nn = int.Parse(nTextBox.Text);
            // если размер поля изменился сбросить флаги о введенности всех массиввов
            if (nn != n)
            {
                fmtx = fvec1 = fvec2 = false;
                vec1DoneLabel.Text = vec2DoneLabel.Text = mtxDoneLabel.Text = "false";
            }
        }
    }
}
