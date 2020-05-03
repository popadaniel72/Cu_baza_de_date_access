namespace Cu_baza_de_date_Access
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.intrebare = new System.Windows.Forms.Label();
            this.r1 = new System.Windows.Forms.RadioButton();
            this.r2 = new System.Windows.Forms.RadioButton();
            this.r3 = new System.Windows.Forms.RadioButton();
            this.r4 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.poza = new System.Windows.Forms.PictureBox();
            this.intrebariTableAdapter1 = new Cu_baza_de_date_Access.quizDataSetTableAdapters.intrebariTableAdapter();
            this.quizDataSet1 = new Cu_baza_de_date_Access.quizDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.poza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // intrebare
            // 
            this.intrebare.AutoSize = true;
            this.intrebare.Location = new System.Drawing.Point(22, 34);
            this.intrebare.Name = "intrebare";
            this.intrebare.Size = new System.Drawing.Size(35, 13);
            this.intrebare.TabIndex = 0;
            this.intrebare.Text = "label1";
            this.intrebare.Click += new System.EventHandler(this.intrebare_Click);
            // 
            // r1
            // 
            this.r1.AutoSize = true;
            this.r1.Location = new System.Drawing.Point(25, 76);
            this.r1.Name = "r1";
            this.r1.Size = new System.Drawing.Size(85, 17);
            this.r1.TabIndex = 1;
            this.r1.TabStop = true;
            this.r1.Text = "radioButton1";
            this.r1.UseVisualStyleBackColor = true;
            // 
            // r2
            // 
            this.r2.AutoSize = true;
            this.r2.Location = new System.Drawing.Point(25, 116);
            this.r2.Name = "r2";
            this.r2.Size = new System.Drawing.Size(85, 17);
            this.r2.TabIndex = 2;
            this.r2.TabStop = true;
            this.r2.Text = "radioButton1";
            this.r2.UseVisualStyleBackColor = true;
            // 
            // r3
            // 
            this.r3.AutoSize = true;
            this.r3.Location = new System.Drawing.Point(25, 161);
            this.r3.Name = "r3";
            this.r3.Size = new System.Drawing.Size(85, 17);
            this.r3.TabIndex = 3;
            this.r3.TabStop = true;
            this.r3.Text = "radioButton1";
            this.r3.UseVisualStyleBackColor = true;
            // 
            // r4
            // 
            this.r4.AutoSize = true;
            this.r4.Location = new System.Drawing.Point(25, 208);
            this.r4.Name = "r4";
            this.r4.Size = new System.Drawing.Size(85, 17);
            this.r4.TabIndex = 4;
            this.r4.TabStop = true;
            this.r4.Text = "radioButton1";
            this.r4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "anterior";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(25, 326);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "urmator";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // poza
            // 
            this.poza.Location = new System.Drawing.Point(285, 76);
            this.poza.Name = "poza";
            this.poza.Size = new System.Drawing.Size(393, 273);
            this.poza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.poza.TabIndex = 7;
            this.poza.TabStop = false;
            // 
            // intrebariTableAdapter1
            // 
            this.intrebariTableAdapter1.ClearBeforeFill = true;
            // 
            // quizDataSet1
            // 
            this.quizDataSet1.DataSetName = "quizDataSet";
            this.quizDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 422);
            this.Controls.Add(this.poza);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.r4);
            this.Controls.Add(this.r3);
            this.Controls.Add(this.r2);
            this.Controls.Add(this.r1);
            this.Controls.Add(this.intrebare);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cu ACCESS";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.poza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label intrebare;
        private System.Windows.Forms.RadioButton r1;
        private System.Windows.Forms.RadioButton r2;
        private System.Windows.Forms.RadioButton r3;
        private System.Windows.Forms.RadioButton r4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox poza;
        private quizDataSetTableAdapters.intrebariTableAdapter intrebariTableAdapter1;
        private quizDataSet quizDataSet1;
    }
}

