using System;

namespace BicycleApp_Lab5
{
    partial class fBicycle
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
            this.tbYear = new System.Windows.Forms.TextBox();
            this.tbType = new System.Windows.Forms.TextBox();
            this.tbWeight = new System.Windows.Forms.TextBox();
            this.tbFrameMaterial = new System.Windows.Forms.TextBox();
            this.tbGearsCount = new System.Windows.Forms.TextBox();
            this.tbMileage = new System.Windows.Forms.TextBox();
            this.tbBrand = new System.Windows.Forms.TextBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.tbDistance = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(278, 101);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(112, 20);
            this.tbYear.TabIndex = 0;
            // 
            // tbType
            // 
            this.tbType.Location = new System.Drawing.Point(278, 136);
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(112, 20);
            this.tbType.TabIndex = 1;
            // 
            // tbWeight
            // 
            this.tbWeight.Location = new System.Drawing.Point(278, 178);
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.Size = new System.Drawing.Size(112, 20);
            this.tbWeight.TabIndex = 2;
            // 
            // tbFrameMaterial
            // 
            this.tbFrameMaterial.Location = new System.Drawing.Point(278, 219);
            this.tbFrameMaterial.Name = "tbFrameMaterial";
            this.tbFrameMaterial.Size = new System.Drawing.Size(112, 20);
            this.tbFrameMaterial.TabIndex = 3;
            // 
            // tbGearsCount
            // 
            this.tbGearsCount.Location = new System.Drawing.Point(278, 262);
            this.tbGearsCount.Name = "tbGearsCount";
            this.tbGearsCount.Size = new System.Drawing.Size(112, 20);
            this.tbGearsCount.TabIndex = 4;
            // 
            // tbMileage
            // 
            this.tbMileage.Location = new System.Drawing.Point(278, 302);
            this.tbMileage.Name = "tbMileage";
            this.tbMileage.Size = new System.Drawing.Size(112, 20);
            this.tbMileage.TabIndex = 5;
            // 
            // tbBrand
            // 
            this.tbBrand.Location = new System.Drawing.Point(278, 26);
            this.tbBrand.Name = "tbBrand";
            this.tbBrand.Size = new System.Drawing.Size(112, 20);
            this.tbBrand.TabIndex = 6;
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(278, 61);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(112, 20);
            this.tbModel.TabIndex = 7;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(684, 31);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "Ок";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(684, 406);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Скасувати";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Марка велосипеда";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Модель велосипеда";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Рік випуску";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Тип велосипеда";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Вага велосипеда";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Матеріал рами";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Кількість передач";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 309);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Пробіг велосипеда";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbTime);
            this.groupBox1.Controls.Add(this.tbDistance);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbModel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbYear);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbBrand);
            this.groupBox1.Controls.Add(this.tbType);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbMileage);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbGearsCount);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbWeight);
            this.groupBox1.Controls.Add(this.tbFrameMaterial);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(477, 426);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данні про велосипед";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tbTime
            // 
            this.tbTime.Location = new System.Drawing.Point(278, 380);
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(100, 20);
            this.tbTime.TabIndex = 21;
            // 
            // tbDistance
            // 
            this.tbDistance.Location = new System.Drawing.Point(278, 343);
            this.tbDistance.Name = "tbDistance";
            this.tbDistance.Size = new System.Drawing.Size(100, 20);
            this.tbDistance.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 387);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "час";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 350);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "відстань";
            // 
            // fBicycle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.MaximizeBox = false;
            this.Name = "fBicycle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список велосипедів";
            this.Load += new System.EventHandler(this.fBicycle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void btnOk_Click_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void fBicycle_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.TextBox tbType;
        private System.Windows.Forms.TextBox tbWeight;
        private System.Windows.Forms.TextBox tbFrameMaterial;
        private System.Windows.Forms.TextBox tbGearsCount;
        private System.Windows.Forms.TextBox tbMileage;
        private System.Windows.Forms.TextBox tbBrand;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.TextBox tbDistance;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}