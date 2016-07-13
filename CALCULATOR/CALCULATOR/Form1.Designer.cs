namespace CALCULATOR
{
    partial class FormCalculator
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
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonDivision = new System.Windows.Forms.Button();
            this.buttonMultiplication = new System.Windows.Forms.Button();
            this.labelOutputSimbol = new System.Windows.Forms.Label();
            this.textBoxInput1 = new System.Windows.Forms.TextBox();
            this.textBoxInput2 = new System.Windows.Forms.TextBox();
            this.labelOutput = new System.Windows.Forms.Label();
            this.buttonSqrt = new System.Windows.Forms.Button();
            this.buttonCos = new System.Windows.Forms.Button();
            this.buttonSin = new System.Windows.Forms.Button();
            this.buttonLn = new System.Windows.Forms.Button();
            this.buttonTan = new System.Windows.Forms.Button();
            this.buttonSqrQube = new System.Windows.Forms.Button();
            this.buttonSqr = new System.Windows.Forms.Button();
            this.buttonLog = new System.Windows.Forms.Button();
            this.buttonInverse = new System.Windows.Forms.Button();
            this.buttonCtg = new System.Windows.Forms.Button();
            this.buttonSqrxy = new System.Windows.Forms.Button();
            this.buttonLogTwoArg = new System.Windows.Forms.Button();
            this.buttonSqrtx = new System.Windows.Forms.Button();
            this.buttonAtan2 = new System.Windows.Forms.Button();
            this.buttonExp = new System.Windows.Forms.Button();
            this.buttonAbc = new System.Windows.Forms.Button();
            this.Mass = new System.Windows.Forms.TextBox();
            this.Click = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPlus
            // 
            this.buttonPlus.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPlus.Location = new System.Drawing.Point(12, 179);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(75, 23);
            this.buttonPlus.TabIndex = 0;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMinus.Location = new System.Drawing.Point(91, 179);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(75, 23);
            this.buttonMinus.TabIndex = 1;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonDivision
            // 
            this.buttonDivision.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDivision.Location = new System.Drawing.Point(169, 179);
            this.buttonDivision.Name = "buttonDivision";
            this.buttonDivision.Size = new System.Drawing.Size(75, 23);
            this.buttonDivision.TabIndex = 2;
            this.buttonDivision.Text = "/";
            this.buttonDivision.UseVisualStyleBackColor = true;
            this.buttonDivision.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonMultiplication
            // 
            this.buttonMultiplication.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMultiplication.Location = new System.Drawing.Point(250, 179);
            this.buttonMultiplication.Name = "buttonMultiplication";
            this.buttonMultiplication.Size = new System.Drawing.Size(75, 23);
            this.buttonMultiplication.TabIndex = 3;
            this.buttonMultiplication.Text = "*";
            this.buttonMultiplication.UseVisualStyleBackColor = true;
            this.buttonMultiplication.Click += new System.EventHandler(this.button_Click);
            // 
            // labelOutputSimbol
            // 
            this.labelOutputSimbol.Location = new System.Drawing.Point(0, 0);
            this.labelOutputSimbol.Name = "labelOutputSimbol";
            this.labelOutputSimbol.Size = new System.Drawing.Size(100, 23);
            this.labelOutputSimbol.TabIndex = 10;
            // 
            // textBoxInput1
            // 
            this.textBoxInput1.Location = new System.Drawing.Point(12, 12);
            this.textBoxInput1.Name = "textBoxInput1";
            this.textBoxInput1.Size = new System.Drawing.Size(313, 20);
            this.textBoxInput1.TabIndex = 6;
            // 
            // textBoxInput2
            // 
            this.textBoxInput2.Location = new System.Drawing.Point(12, 75);
            this.textBoxInput2.Name = "textBoxInput2";
            this.textBoxInput2.Size = new System.Drawing.Size(313, 20);
            this.textBoxInput2.TabIndex = 8;
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(166, 136);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(0, 13);
            this.labelOutput.TabIndex = 9;
            // 
            // buttonSqrt
            // 
            this.buttonSqrt.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSqrt.Location = new System.Drawing.Point(12, 208);
            this.buttonSqrt.Name = "buttonSqrt";
            this.buttonSqrt.Size = new System.Drawing.Size(75, 25);
            this.buttonSqrt.TabIndex = 11;
            this.buttonSqrt.Text = "Sqrt";
            this.buttonSqrt.UseVisualStyleBackColor = true;
            this.buttonSqrt.Click += new System.EventHandler(this.button_ClickOne);
            // 
            // buttonCos
            // 
            this.buttonCos.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCos.Location = new System.Drawing.Point(93, 207);
            this.buttonCos.Name = "buttonCos";
            this.buttonCos.Size = new System.Drawing.Size(75, 26);
            this.buttonCos.TabIndex = 12;
            this.buttonCos.Text = "Cos";
            this.buttonCos.UseVisualStyleBackColor = true;
            this.buttonCos.Click += new System.EventHandler(this.button_ClickOne);
            // 
            // buttonSin
            // 
            this.buttonSin.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSin.Location = new System.Drawing.Point(169, 207);
            this.buttonSin.Name = "buttonSin";
            this.buttonSin.Size = new System.Drawing.Size(75, 26);
            this.buttonSin.TabIndex = 13;
            this.buttonSin.Text = "Sin";
            this.buttonSin.UseVisualStyleBackColor = true;
            this.buttonSin.Click += new System.EventHandler(this.button_ClickOne);
            // 
            // buttonLn
            // 
            this.buttonLn.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLn.Location = new System.Drawing.Point(250, 207);
            this.buttonLn.Name = "buttonLn";
            this.buttonLn.Size = new System.Drawing.Size(75, 26);
            this.buttonLn.TabIndex = 14;
            this.buttonLn.Text = "ln";
            this.buttonLn.UseVisualStyleBackColor = true;
            this.buttonLn.Click += new System.EventHandler(this.button_ClickOne);
            // 
            // buttonTan
            // 
            this.buttonTan.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTan.Location = new System.Drawing.Point(250, 239);
            this.buttonTan.Name = "buttonTan";
            this.buttonTan.Size = new System.Drawing.Size(75, 26);
            this.buttonTan.TabIndex = 18;
            this.buttonTan.Text = "tan";
            this.buttonTan.UseVisualStyleBackColor = true;
            this.buttonTan.Click += new System.EventHandler(this.button_ClickOne);
            // 
            // buttonSqrQube
            // 
            this.buttonSqrQube.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSqrQube.Location = new System.Drawing.Point(169, 239);
            this.buttonSqrQube.Name = "buttonSqrQube";
            this.buttonSqrQube.Size = new System.Drawing.Size(75, 26);
            this.buttonSqrQube.TabIndex = 17;
            this.buttonSqrQube.Text = "x^3";
            this.buttonSqrQube.UseVisualStyleBackColor = true;
            this.buttonSqrQube.Click += new System.EventHandler(this.button_ClickOne);
            // 
            // buttonSqr
            // 
            this.buttonSqr.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSqr.Location = new System.Drawing.Point(93, 239);
            this.buttonSqr.Name = "buttonSqr";
            this.buttonSqr.Size = new System.Drawing.Size(75, 26);
            this.buttonSqr.TabIndex = 16;
            this.buttonSqr.Text = "x^2";
            this.buttonSqr.UseVisualStyleBackColor = true;
            this.buttonSqr.Click += new System.EventHandler(this.button_ClickOne);
            // 
            // buttonLog
            // 
            this.buttonLog.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLog.Location = new System.Drawing.Point(12, 240);
            this.buttonLog.Name = "buttonLog";
            this.buttonLog.Size = new System.Drawing.Size(75, 25);
            this.buttonLog.TabIndex = 15;
            this.buttonLog.Text = "Log";
            this.buttonLog.UseVisualStyleBackColor = true;
            this.buttonLog.Click += new System.EventHandler(this.button_ClickOne);
            // 
            // buttonInverse
            // 
            this.buttonInverse.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInverse.Location = new System.Drawing.Point(169, 271);
            this.buttonInverse.Name = "buttonInverse";
            this.buttonInverse.Size = new System.Drawing.Size(75, 26);
            this.buttonInverse.TabIndex = 22;
            this.buttonInverse.Text = "+/-";
            this.buttonInverse.UseVisualStyleBackColor = true;
            this.buttonInverse.Click += new System.EventHandler(this.button_ClickOne);
            // 
            // buttonCtg
            // 
            this.buttonCtg.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCtg.Location = new System.Drawing.Point(250, 271);
            this.buttonCtg.Name = "buttonCtg";
            this.buttonCtg.Size = new System.Drawing.Size(75, 26);
            this.buttonCtg.TabIndex = 21;
            this.buttonCtg.Text = "Ctg";
            this.buttonCtg.UseVisualStyleBackColor = true;
            this.buttonCtg.Click += new System.EventHandler(this.button_ClickOne);
            // 
            // buttonSqrxy
            // 
            this.buttonSqrxy.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSqrxy.Location = new System.Drawing.Point(88, 303);
            this.buttonSqrxy.Name = "buttonSqrxy";
            this.buttonSqrxy.Size = new System.Drawing.Size(75, 26);
            this.buttonSqrxy.TabIndex = 20;
            this.buttonSqrxy.Text = "x^y";
            this.buttonSqrxy.UseVisualStyleBackColor = true;
            this.buttonSqrxy.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonLogTwoArg
            // 
            this.buttonLogTwoArg.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLogTwoArg.Location = new System.Drawing.Point(12, 304);
            this.buttonLogTwoArg.Name = "buttonLogTwoArg";
            this.buttonLogTwoArg.Size = new System.Drawing.Size(70, 25);
            this.buttonLogTwoArg.TabIndex = 19;
            this.buttonLogTwoArg.Text = "Logy(x)";
            this.buttonLogTwoArg.UseVisualStyleBackColor = true;
            this.buttonLogTwoArg.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonSqrtx
            // 
            this.buttonSqrtx.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSqrtx.Location = new System.Drawing.Point(245, 304);
            this.buttonSqrtx.Name = "buttonSqrtx";
            this.buttonSqrtx.Size = new System.Drawing.Size(80, 26);
            this.buttonSqrtx.TabIndex = 26;
            this.buttonSqrtx.Text = "Sqrt(x)";
            this.buttonSqrtx.UseVisualStyleBackColor = true;
            this.buttonSqrtx.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonAtan2
            // 
            this.buttonAtan2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAtan2.Location = new System.Drawing.Point(169, 303);
            this.buttonAtan2.Name = "buttonAtan2";
            this.buttonAtan2.Size = new System.Drawing.Size(75, 26);
            this.buttonAtan2.TabIndex = 25;
            this.buttonAtan2.Text = "Atan2";
            this.buttonAtan2.UseVisualStyleBackColor = true;
            this.buttonAtan2.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonExp
            // 
            this.buttonExp.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExp.Location = new System.Drawing.Point(93, 271);
            this.buttonExp.Name = "buttonExp";
            this.buttonExp.Size = new System.Drawing.Size(75, 26);
            this.buttonExp.TabIndex = 24;
            this.buttonExp.Text = "Exp";
            this.buttonExp.UseVisualStyleBackColor = true;
            this.buttonExp.Click += new System.EventHandler(this.button_ClickOne);
            // 
            // buttonAbc
            // 
            this.buttonAbc.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAbc.Location = new System.Drawing.Point(12, 272);
            this.buttonAbc.Name = "buttonAbc";
            this.buttonAbc.Size = new System.Drawing.Size(75, 25);
            this.buttonAbc.TabIndex = 23;
            this.buttonAbc.Text = "Abc";
            this.buttonAbc.UseVisualStyleBackColor = true;
            this.buttonAbc.Click += new System.EventHandler(this.button_ClickOne);
            // 
            // Mass
            // 
            this.Mass.Location = new System.Drawing.Point(12, 340);
            this.Mass.Name = "Mass";
            this.Mass.Size = new System.Drawing.Size(313, 20);
            this.Mass.TabIndex = 27;
            this.Mass.TextChanged += new System.EventHandler(this.Mass_TextChanged);
            // 
            // Click
            // 
            this.Click.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Click.Location = new System.Drawing.Point(12, 366);
            this.Click.Name = "Click";
            this.Click.Size = new System.Drawing.Size(308, 23);
            this.Click.TabIndex = 0;
            this.Click.Text = "Click";
            this.Click.UseVisualStyleBackColor = true;
            this.Click.Click += new System.EventHandler(this.ClickMass);
            // 
            // FormCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 392);
            this.Controls.Add(this.Mass);
            this.Controls.Add(this.buttonSqrtx);
            this.Controls.Add(this.buttonAtan2);
            this.Controls.Add(this.buttonExp);
            this.Controls.Add(this.buttonAbc);
            this.Controls.Add(this.buttonInverse);
            this.Controls.Add(this.buttonCtg);
            this.Controls.Add(this.buttonSqrxy);
            this.Controls.Add(this.buttonLogTwoArg);
            this.Controls.Add(this.buttonTan);
            this.Controls.Add(this.buttonSqrQube);
            this.Controls.Add(this.buttonSqr);
            this.Controls.Add(this.buttonLog);
            this.Controls.Add(this.buttonLn);
            this.Controls.Add(this.buttonSin);
            this.Controls.Add(this.buttonCos);
            this.Controls.Add(this.buttonSqrt);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.textBoxInput2);
            this.Controls.Add(this.textBoxInput1);
            this.Controls.Add(this.labelOutputSimbol);
            this.Controls.Add(this.buttonMultiplication);
            this.Controls.Add(this.buttonDivision);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.Click);
            this.Controls.Add(this.buttonPlus);
            this.Name = "FormCalculator";
            this.Text = "v";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonDivision;
        private System.Windows.Forms.Button buttonMultiplication;
        private System.Windows.Forms.Label labelOutputSimbol;
        private System.Windows.Forms.TextBox textBoxInput1;
        private System.Windows.Forms.TextBox textBoxInput2;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Button buttonSqrt;
        private System.Windows.Forms.Button buttonCos;
        private System.Windows.Forms.Button buttonSin;
        private System.Windows.Forms.Button buttonLn;
        private System.Windows.Forms.Button buttonTan;
        private System.Windows.Forms.Button buttonSqrQube;
        private System.Windows.Forms.Button buttonSqr;
        private System.Windows.Forms.Button buttonLog;
        private System.Windows.Forms.Button buttonInverse;
        private System.Windows.Forms.Button buttonCtg;
        private System.Windows.Forms.Button buttonSqrxy;
        private System.Windows.Forms.Button buttonLogTwoArg;
        private System.Windows.Forms.Button buttonSqrtx;
        private System.Windows.Forms.Button buttonAtan2;
        private System.Windows.Forms.Button buttonExp;
        private System.Windows.Forms.Button buttonAbc;
        private System.Windows.Forms.TextBox Mass;
        private System.Windows.Forms.Button Click;
    }
}

