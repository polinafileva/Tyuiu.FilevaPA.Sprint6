namespace Tyuiu.FilevaA.Sprint6.Task0.V1;
    using Tyuiu.FilevaPA.Sprint6.Task0.V1.Lib;


    partial class FormMain
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

    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));

        // pictureBoxFormula_SIS
        pictureBoxFormula_SIS = new PictureBox();
        pictureBoxFormula_SIS.Image = CreateFormulaImage();
        pictureBoxFormula_SIS.Location = new Point(20, 20);
        pictureBoxFormula_SIS.Size = new Size(200, 80);
        pictureBoxFormula_SIS.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBoxFormula_SIS.TabIndex = 0;
        pictureBoxFormula_SIS.TabStop = false;

        // labelVarA_SIS
        labelVarA_SIS = new Label();
        labelVarA_SIS.Text = "Введите значение x:";
        labelVarA_SIS.Font = new Font("Arial", 10, FontStyle.Regular);
        labelVarA_SIS.Location = new Point(20, 120);
        labelVarA_SIS.Size = new Size(150, 20);
        labelVarA_SIS.TabIndex = 1;

        // textBoxVarA_SIS
        textBoxVarA_SIS = new TextBox();
        textBoxVarA_SIS.Location = new Point(180, 120);
        textBoxVarA_SIS.Size = new Size(100, 20);
        textBoxVarA_SIS.Font = new Font("Arial", 10, FontStyle.Regular);
        textBoxVarA_SIS.TabIndex = 2;
        textBoxVarA_SIS.Text = "3";

        // labelResult_SIS
        labelResult_SIS = new Label();
        labelResult_SIS.Text = "Результат s(x):";
        labelResult_SIS.Font = new Font("Arial", 10, FontStyle.Regular);
        labelResult_SIS.Location = new Point(20, 160);
        labelResult_SIS.Size = new Size(150, 20);
        labelResult_SIS.TabIndex = 3;

        // textBoxResult_SIS
        textBoxResult_SIS = new TextBox();
        textBoxResult_SIS.Location = new Point(180, 160);
        textBoxResult_SIS.Size = new Size(100, 20);
        textBoxResult_SIS.Font = new Font("Arial", 10, FontStyle.Regular);
        textBoxResult_SIS.ReadOnly = true;
        textBoxResult_SIS.TabStop = false;
        textBoxResult_SIS.BackColor = Color.LightYellow;
        textBoxResult_SIS.TabIndex = 4;

        // buttonDone_SIS
        buttonDone_SIS = new Button();
        buttonDone_SIS.Text = "Вычислить";
        buttonDone_SIS.Font = new Font("Arial", 10, FontStyle.Bold);
        buttonDone_SIS.Location = new Point(20, 200);
        buttonDone_SIS.Size = new Size(120, 35);
        buttonDone_SIS.TabIndex = 5;
        buttonDone_SIS.BackColor = Color.LightBlue;
        buttonDone_SIS.Click += new EventHandler(buttonDone_SIS_Click);

        // buttonInfo_SIS
        buttonInfo_SIS = new Button();
        buttonInfo_SIS.Text = "Справка";
        buttonInfo_SIS.Font = new Font("Arial", 10, FontStyle.Regular);
        buttonInfo_SIS.Location = new Point(160, 200);
        buttonInfo_SIS.Size = new Size(120, 35);
        buttonInfo_SIS.TabIndex = 6;
        buttonInfo_SIS.BackColor = Color.LightGreen;
        buttonInfo_SIS.Click += new EventHandler(buttonInfo_SIS_Click);

        // FormMain
        this.ClientSize = new Size(300, 250);
        this.Text = "Вычисление функции s(x)";
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Controls.Add(pictureBoxFormula_SIS);
        this.Controls.Add(labelVarA_SIS);
        this.Controls.Add(textBoxVarA_SIS);
        this.Controls.Add(labelResult_SIS);
        this.Controls.Add(textBoxResult_SIS);
        this.Controls.Add(buttonDone_SIS);
        this.Controls.Add(buttonInfo_SIS);
    }

    private Image CreateFormulaImage()
    {
        // Создаем изображение с формулой
        Bitmap bitmap = new Bitmap(200, 80);
        using (Graphics g = Graphics.FromImage(bitmap))
        {
            g.Clear(Color.White);
            using (Font font = new Font("Arial", 14, FontStyle.Bold))
            {
                g.DrawString("     x", font, Brushes.Black, 10, 10);
                g.DrawString("s(x) = —————", font, Brushes.Black, 60, 10);
                g.DrawString("    x³ + 2", font, Brushes.Black, 70, 40);
            }
        }
        return bitmap;
    }
}

