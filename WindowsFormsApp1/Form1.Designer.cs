namespace WindowsFormsApp1
{
    partial class Form1
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

        private void InitializeComponent()
        {
            this.pictureBoxFormula_SIS = new System.Windows.Forms.PictureBox();
            this.labelVarA_SIS = new System.Windows.Forms.Label();
            this.textBoxVarA_SIS = new System.Windows.Forms.TextBox();
            this.labelResult_SIS = new System.Windows.Forms.Label();
            this.textBoxResult_SIS = new System.Windows.Forms.TextBox();
            this.buttonDone_SIS = new System.Windows.Forms.Button();
            this.buttonInfo_SIS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_SIS)).BeginInit();
            this.SuspendLayout();

            // pictureBoxFormula_SIS
            this.pictureBoxFormula_SIS.Location = new System.Drawing.Point(20, 20);
            this.pictureBoxFormula_SIS.Name = "pictureBoxFormula_SIS";
            this.pictureBoxFormula_SIS.Size = new System.Drawing.Size(200, 80);
            this.pictureBoxFormula_SIS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFormula_SIS.TabIndex = 0;
            this.pictureBoxFormula_SIS.TabStop = false;

            // labelVarA_SIS
            this.labelVarA_SIS.AutoSize = true;
            this.labelVarA_SIS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVarA_SIS.Location = new System.Drawing.Point(20, 120);
            this.labelVarA_SIS.Name = "labelVarA_SIS";
            this.labelVarA_SIS.Size = new System.Drawing.Size(134, 17);
            this.labelVarA_SIS.TabIndex = 1;
            this.labelVarA_SIS.Text = "Введите значение x:";

            // textBoxVarA_SIS
            this.textBoxVarA_SIS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxVarA_SIS.Location = new System.Drawing.Point(180, 117);
            this.textBoxVarA_SIS.Name = "textBoxVarA_SIS";
            this.textBoxVarA_SIS.Size = new System.Drawing.Size(100, 23);
            this.textBoxVarA_SIS.TabIndex = 2;
            this.textBoxVarA_SIS.Text = "3";
            this.textBoxVarA_SIS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            // labelResult_SIS
            this.labelResult_SIS.AutoSize = true;
            this.labelResult_SIS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult_SIS.Location = new System.Drawing.Point(20, 160);
            this.labelResult_SIS.Name = "labelResult_SIS";
            this.labelResult_SIS.Size = new System.Drawing.Size(112, 17);
            this.labelResult_SIS.TabIndex = 3;
            this.labelResult_SIS.Text = "Результат s(x):";

            // textBoxResult_SIS
            this.textBoxResult_SIS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult_SIS.Location = new System.Drawing.Point(180, 157);
            this.textBoxResult_SIS.Name = "textBoxResult_SIS";
            this.textBoxResult_SIS.ReadOnly = true;
            this.textBoxResult_SIS.Size = new System.Drawing.Size(100, 23);
            this.textBoxResult_SIS.TabIndex = 4;
            this.textBoxResult_SIS.TabStop = false;
            this.textBoxResult_SIS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxResult_SIS.BackColor = System.Drawing.Color.LightYellow;

            // buttonDone_SIS
            this.buttonDone_SIS.BackColor = System.Drawing.Color.LightBlue;
            this.buttonDone_SIS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone_SIS.Location = new System.Drawing.Point(20, 200);
            this.buttonDone_SIS.Name = "buttonDone_SIS";
            this.buttonDone_SIS.Size = new System.Drawing.Size(120, 35);
            this.buttonDone_SIS.TabIndex = 5;
            this.buttonDone_SIS.Text = "Вычислить";
            this.buttonDone_SIS.UseVisualStyleBackColor = false;
            this.buttonDone_SIS.Click += new System.EventHandler(this.buttonDone_SIS_Click);

            // buttonInfo_SIS
            this.buttonInfo_SIS.BackColor = System.Drawing.Color.LightGreen;
            this.buttonInfo_SIS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInfo_SIS.Location = new System.Drawing.Point(160, 200);
            this.buttonInfo_SIS.Name = "buttonInfo_SIS";
            this.buttonInfo_SIS.Size = new System.Drawing.Size(120, 35);
            this.buttonInfo_SIS.TabIndex = 6;
            this.buttonInfo_SIS.Text = "Справка";
            this.buttonInfo_SIS.UseVisualStyleBackColor = false;
            this.buttonInfo_SIS.Click += new System.EventHandler(this.buttonInfo_SIS_Click);

            // FormMain
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 250);
            this.Controls.Add(this.buttonInfo_SIS);
            this.Controls.Add(this.buttonDone_SIS);
            this.Controls.Add(this.textBoxResult_SIS);
            this.Controls.Add(this.labelResult_SIS);
            this.Controls.Add(this.textBoxVarA_SIS);
            this.Controls.Add(this.labelVarA_SIS);
            this.Controls.Add(this.pictureBoxFormula_SIS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вычисление функции s(x)";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_SIS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }#region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
    }
}

