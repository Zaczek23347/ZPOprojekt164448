namespace Zabiegi_SalonFryzjerski
{
    partial class FormWizyty
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
            this.comboBoxZabieg = new System.Windows.Forms.ComboBox();
            this.textBoxImie = new System.Windows.Forms.TextBox();
            this.dateTimePickerData = new System.Windows.Forms.DateTimePicker();
            this.buttonZapiszWizyte = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxZabieg
            // 
            this.comboBoxZabieg.FormattingEnabled = true;
            this.comboBoxZabieg.Location = new System.Drawing.Point(288, 100);
            this.comboBoxZabieg.Name = "comboBoxZabieg";
            this.comboBoxZabieg.Size = new System.Drawing.Size(207, 21);
            this.comboBoxZabieg.TabIndex = 0;
            // 
            // textBoxImie
            // 
            this.textBoxImie.Location = new System.Drawing.Point(288, 171);
            this.textBoxImie.Name = "textBoxImie";
            this.textBoxImie.Size = new System.Drawing.Size(207, 20);
            this.textBoxImie.TabIndex = 1;
            // 
            // dateTimePickerData
            // 
            this.dateTimePickerData.Location = new System.Drawing.Point(288, 232);
            this.dateTimePickerData.Name = "dateTimePickerData";
            this.dateTimePickerData.Size = new System.Drawing.Size(207, 20);
            this.dateTimePickerData.TabIndex = 2;
            // 
            // buttonZapiszWizyte
            // 
            this.buttonZapiszWizyte.Location = new System.Drawing.Point(318, 281);
            this.buttonZapiszWizyte.Name = "buttonZapiszWizyte";
            this.buttonZapiszWizyte.Size = new System.Drawing.Size(133, 23);
            this.buttonZapiszWizyte.TabIndex = 3;
            this.buttonZapiszWizyte.Text = "Zapisz Wizytę";
            this.buttonZapiszWizyte.UseVisualStyleBackColor = true;
            this.buttonZapiszWizyte.Click += new System.EventHandler(this.buttonZapiszWizyte_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(371, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Zabieg";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Imie klienta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(371, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "data";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.label4.Location = new System.Drawing.Point(296, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 39);
            this.label4.TabIndex = 7;
            this.label4.Text = "Zapis wizyt";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(690, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Zabiegi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormWizyty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonZapiszWizyte);
            this.Controls.Add(this.dateTimePickerData);
            this.Controls.Add(this.textBoxImie);
            this.Controls.Add(this.comboBoxZabieg);
            this.Name = "FormWizyty";
            this.Text = "FormWizyty";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxZabieg;
        private System.Windows.Forms.TextBox textBoxImie;
        private System.Windows.Forms.DateTimePicker dateTimePickerData;
        private System.Windows.Forms.Button buttonZapiszWizyte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}