namespace TimetableComparator
{
    partial class FormMain
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
            this.tb_timetable1 = new System.Windows.Forms.TextBox();
            this.bt_chooseFile1 = new System.Windows.Forms.Button();
            this.nud_subgroup1 = new System.Windows.Forms.NumericUpDown();
            this.nud_subgroup2 = new System.Windows.Forms.NumericUpDown();
            this.bt_chooseFile2 = new System.Windows.Forms.Button();
            this.tb_timetable2 = new System.Windows.Forms.TextBox();
            this.nud_numberWeek = new System.Windows.Forms.NumericUpDown();
            this.bt_compare = new System.Windows.Forms.Button();
            this.rtb_result = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.nud_subgroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_subgroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_numberWeek)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_timetable1
            // 
            this.tb_timetable1.Location = new System.Drawing.Point(18, 13);
            this.tb_timetable1.Name = "tb_timetable1";
            this.tb_timetable1.Size = new System.Drawing.Size(136, 20);
            this.tb_timetable1.TabIndex = 0;
            // 
            // bt_chooseFile1
            // 
            this.bt_chooseFile1.Location = new System.Drawing.Point(160, 14);
            this.bt_chooseFile1.Name = "bt_chooseFile1";
            this.bt_chooseFile1.Size = new System.Drawing.Size(40, 20);
            this.bt_chooseFile1.TabIndex = 1;
            this.bt_chooseFile1.Text = "...";
            this.bt_chooseFile1.UseVisualStyleBackColor = true;
            this.bt_chooseFile1.Click += new System.EventHandler(this.bt_chooseFile1_Click);
            // 
            // nud_subgroup1
            // 
            this.nud_subgroup1.Location = new System.Drawing.Point(230, 12);
            this.nud_subgroup1.Name = "nud_subgroup1";
            this.nud_subgroup1.Size = new System.Drawing.Size(34, 20);
            this.nud_subgroup1.TabIndex = 2;
            // 
            // nud_subgroup2
            // 
            this.nud_subgroup2.Location = new System.Drawing.Point(230, 60);
            this.nud_subgroup2.Name = "nud_subgroup2";
            this.nud_subgroup2.Size = new System.Drawing.Size(34, 20);
            this.nud_subgroup2.TabIndex = 5;
            // 
            // bt_chooseFile2
            // 
            this.bt_chooseFile2.Location = new System.Drawing.Point(160, 62);
            this.bt_chooseFile2.Name = "bt_chooseFile2";
            this.bt_chooseFile2.Size = new System.Drawing.Size(40, 20);
            this.bt_chooseFile2.TabIndex = 4;
            this.bt_chooseFile2.Text = "...";
            this.bt_chooseFile2.UseVisualStyleBackColor = true;
            this.bt_chooseFile2.Click += new System.EventHandler(this.bt_chooseFile2_Click);
            // 
            // tb_timetable2
            // 
            this.tb_timetable2.Location = new System.Drawing.Point(18, 61);
            this.tb_timetable2.Name = "tb_timetable2";
            this.tb_timetable2.Size = new System.Drawing.Size(136, 20);
            this.tb_timetable2.TabIndex = 3;
            // 
            // nud_numberWeek
            // 
            this.nud_numberWeek.Location = new System.Drawing.Point(296, 32);
            this.nud_numberWeek.Name = "nud_numberWeek";
            this.nud_numberWeek.Size = new System.Drawing.Size(45, 20);
            this.nud_numberWeek.TabIndex = 6;
            // 
            // bt_compare
            // 
            this.bt_compare.Location = new System.Drawing.Point(117, 111);
            this.bt_compare.Name = "bt_compare";
            this.bt_compare.Size = new System.Drawing.Size(133, 29);
            this.bt_compare.TabIndex = 7;
            this.bt_compare.Text = "button3";
            this.bt_compare.UseVisualStyleBackColor = true;
            // 
            // rtb_result
            // 
            this.rtb_result.Location = new System.Drawing.Point(10, 155);
            this.rtb_result.Name = "rtb_result";
            this.rtb_result.Size = new System.Drawing.Size(351, 112);
            this.rtb_result.TabIndex = 8;
            this.rtb_result.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 277);
            this.Controls.Add(this.rtb_result);
            this.Controls.Add(this.bt_compare);
            this.Controls.Add(this.nud_numberWeek);
            this.Controls.Add(this.nud_subgroup2);
            this.Controls.Add(this.bt_chooseFile2);
            this.Controls.Add(this.tb_timetable2);
            this.Controls.Add(this.nud_subgroup1);
            this.Controls.Add(this.bt_chooseFile1);
            this.Controls.Add(this.tb_timetable1);
            this.Name = "FormMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nud_subgroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_subgroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_numberWeek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_timetable1;
        private System.Windows.Forms.Button bt_chooseFile1;
        private System.Windows.Forms.NumericUpDown nud_subgroup1;
        private System.Windows.Forms.NumericUpDown nud_subgroup2;
        private System.Windows.Forms.Button bt_chooseFile2;
        private System.Windows.Forms.TextBox tb_timetable2;
        private System.Windows.Forms.NumericUpDown nud_numberWeek;
        private System.Windows.Forms.Button bt_compare;
        private System.Windows.Forms.RichTextBox rtb_result;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

