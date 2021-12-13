
namespace WinFormsLaba1
{
    partial class FormBoatConfig
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelShip = new System.Windows.Forms.Label();
            this.labelBoat = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownRotors = new System.Windows.Forms.NumericUpDown();
            this.checkBoxRotors = new System.Windows.Forms.CheckBox();
            this.checkBoxWindow = new System.Windows.Forms.CheckBox();
            this.checkBoxLines = new System.Windows.Forms.CheckBox();
            this.numericUpDownWeigth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSpeed = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxBoat = new System.Windows.Forms.PictureBox();
            this.panelBoat = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.colorPanel5 = new System.Windows.Forms.Panel();
            this.colorPanel4 = new System.Windows.Forms.Panel();
            this.colorPanel6 = new System.Windows.Forms.Panel();
            this.colorPanel3 = new System.Windows.Forms.Panel();
            this.colorPanel7 = new System.Windows.Forms.Panel();
            this.colorPanel8 = new System.Windows.Forms.Panel();
            this.colorPanel2 = new System.Windows.Forms.Panel();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.labelBaseColor = new System.Windows.Forms.Label();
            this.colorPanel1 = new System.Windows.Forms.Panel();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRotors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeigth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBoat)).BeginInit();
            this.panelBoat.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelShip);
            this.groupBox1.Controls.Add(this.labelBoat);
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(115, 99);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип лодки";
            // 
            // labelShip
            // 
            this.labelShip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelShip.Location = new System.Drawing.Point(6, 59);
            this.labelShip.Name = "labelShip";
            this.labelShip.Size = new System.Drawing.Size(103, 34);
            this.labelShip.TabIndex = 1;
            this.labelShip.Text = "Катер";
            this.labelShip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelShip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelShip_MouseDown);
            // 
            // labelBoat
            // 
            this.labelBoat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBoat.Location = new System.Drawing.Point(6, 16);
            this.labelBoat.Name = "labelBoat";
            this.labelBoat.Size = new System.Drawing.Size(103, 34);
            this.labelBoat.TabIndex = 0;
            this.labelBoat.Text = "Обычная лодка";
            this.labelBoat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBoat.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelBoat_MouseDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.numericUpDownRotors);
            this.groupBox2.Controls.Add(this.checkBoxRotors);
            this.groupBox2.Controls.Add(this.checkBoxWindow);
            this.groupBox2.Controls.Add(this.checkBoxLines);
            this.groupBox2.Controls.Add(this.numericUpDownWeigth);
            this.groupBox2.Controls.Add(this.numericUpDownSpeed);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(10, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 103);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Параметры";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(137, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Количество моторов:";
            // 
            // numericUpDownRotors
            // 
            this.numericUpDownRotors.Location = new System.Drawing.Point(254, 75);
            this.numericUpDownRotors.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownRotors.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRotors.Name = "numericUpDownRotors";
            this.numericUpDownRotors.Size = new System.Drawing.Size(53, 20);
            this.numericUpDownRotors.TabIndex = 7;
            this.numericUpDownRotors.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // checkBoxRotors
            // 
            this.checkBoxRotors.AutoSize = true;
            this.checkBoxRotors.Location = new System.Drawing.Point(140, 55);
            this.checkBoxRotors.Name = "checkBoxRotors";
            this.checkBoxRotors.Size = new System.Drawing.Size(66, 17);
            this.checkBoxRotors.TabIndex = 6;
            this.checkBoxRotors.Text = "Моторы";
            this.checkBoxRotors.UseVisualStyleBackColor = true;
            // 
            // checkBoxWindow
            // 
            this.checkBoxWindow.AutoSize = true;
            this.checkBoxWindow.Location = new System.Drawing.Point(140, 36);
            this.checkBoxWindow.Name = "checkBoxWindow";
            this.checkBoxWindow.Size = new System.Drawing.Size(62, 17);
            this.checkBoxWindow.TabIndex = 5;
            this.checkBoxWindow.Text = "Стекло";
            this.checkBoxWindow.UseVisualStyleBackColor = true;
            // 
            // checkBoxLines
            // 
            this.checkBoxLines.AutoSize = true;
            this.checkBoxLines.Location = new System.Drawing.Point(140, 15);
            this.checkBoxLines.Name = "checkBoxLines";
            this.checkBoxLines.Size = new System.Drawing.Size(70, 17);
            this.checkBoxLines.TabIndex = 4;
            this.checkBoxLines.Text = "Полоски";
            this.checkBoxLines.UseVisualStyleBackColor = true;
            // 
            // numericUpDownWeigth
            // 
            this.numericUpDownWeigth.Location = new System.Drawing.Point(62, 75);
            this.numericUpDownWeigth.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownWeigth.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownWeigth.Name = "numericUpDownWeigth";
            this.numericUpDownWeigth.Size = new System.Drawing.Size(53, 20);
            this.numericUpDownWeigth.TabIndex = 3;
            this.numericUpDownWeigth.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDownSpeed
            // 
            this.numericUpDownSpeed.Location = new System.Drawing.Point(62, 36);
            this.numericUpDownSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownSpeed.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownSpeed.Name = "numericUpDownSpeed";
            this.numericUpDownSpeed.Size = new System.Drawing.Size(53, 20);
            this.numericUpDownSpeed.TabIndex = 2;
            this.numericUpDownSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Вес лодки:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Макс. скорость:";
            // 
            // pictureBoxBoat
            // 
            this.pictureBoxBoat.Location = new System.Drawing.Point(3, 16);
            this.pictureBoxBoat.Name = "pictureBoxBoat";
            this.pictureBoxBoat.Size = new System.Drawing.Size(186, 80);
            this.pictureBoxBoat.TabIndex = 2;
            this.pictureBoxBoat.TabStop = false;
            // 
            // panelBoat
            // 
            this.panelBoat.AllowDrop = true;
            this.panelBoat.Controls.Add(this.pictureBoxBoat);
            this.panelBoat.Location = new System.Drawing.Point(132, 12);
            this.panelBoat.Name = "panelBoat";
            this.panelBoat.Size = new System.Drawing.Size(192, 99);
            this.panelBoat.TabIndex = 3;
            this.panelBoat.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelBoat_DragDrop);
            this.panelBoat.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelBoat_DragEnter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.colorPanel5);
            this.groupBox3.Controls.Add(this.colorPanel4);
            this.groupBox3.Controls.Add(this.colorPanel6);
            this.groupBox3.Controls.Add(this.colorPanel3);
            this.groupBox3.Controls.Add(this.colorPanel7);
            this.groupBox3.Controls.Add(this.colorPanel8);
            this.groupBox3.Controls.Add(this.colorPanel2);
            this.groupBox3.Controls.Add(this.labelDopColor);
            this.groupBox3.Controls.Add(this.labelBaseColor);
            this.groupBox3.Controls.Add(this.colorPanel1);
            this.groupBox3.Location = new System.Drawing.Point(328, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(197, 153);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Цвета";
            // 
            // colorPanel5
            // 
            this.colorPanel5.BackColor = System.Drawing.Color.Blue;
            this.colorPanel5.Location = new System.Drawing.Point(149, 105);
            this.colorPanel5.Name = "colorPanel5";
            this.colorPanel5.Size = new System.Drawing.Size(41, 40);
            this.colorPanel5.TabIndex = 3;
            // 
            // colorPanel4
            // 
            this.colorPanel4.BackColor = System.Drawing.Color.White;
            this.colorPanel4.Location = new System.Drawing.Point(149, 59);
            this.colorPanel4.Name = "colorPanel4";
            this.colorPanel4.Size = new System.Drawing.Size(41, 40);
            this.colorPanel4.TabIndex = 1;
            // 
            // colorPanel6
            // 
            this.colorPanel6.BackColor = System.Drawing.Color.Green;
            this.colorPanel6.Location = new System.Drawing.Point(101, 105);
            this.colorPanel6.Name = "colorPanel6";
            this.colorPanel6.Size = new System.Drawing.Size(41, 40);
            this.colorPanel6.TabIndex = 4;
            // 
            // colorPanel3
            // 
            this.colorPanel3.BackColor = System.Drawing.Color.Black;
            this.colorPanel3.Location = new System.Drawing.Point(101, 59);
            this.colorPanel3.Name = "colorPanel3";
            this.colorPanel3.Size = new System.Drawing.Size(41, 40);
            this.colorPanel3.TabIndex = 1;
            // 
            // colorPanel7
            // 
            this.colorPanel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.colorPanel7.Location = new System.Drawing.Point(54, 105);
            this.colorPanel7.Name = "colorPanel7";
            this.colorPanel7.Size = new System.Drawing.Size(41, 40);
            this.colorPanel7.TabIndex = 5;
            // 
            // colorPanel8
            // 
            this.colorPanel8.BackColor = System.Drawing.Color.Gray;
            this.colorPanel8.Location = new System.Drawing.Point(6, 105);
            this.colorPanel8.Name = "colorPanel8";
            this.colorPanel8.Size = new System.Drawing.Size(41, 40);
            this.colorPanel8.TabIndex = 2;
            // 
            // colorPanel2
            // 
            this.colorPanel2.BackColor = System.Drawing.Color.Yellow;
            this.colorPanel2.Location = new System.Drawing.Point(54, 59);
            this.colorPanel2.Name = "colorPanel2";
            this.colorPanel2.Size = new System.Drawing.Size(41, 40);
            this.colorPanel2.TabIndex = 1;
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(101, 16);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(89, 34);
            this.labelDopColor.TabIndex = 3;
            this.labelDopColor.Text = "Доп. цвет";
            this.labelDopColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // labelBaseColor
            // 
            this.labelBaseColor.AllowDrop = true;
            this.labelBaseColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBaseColor.Location = new System.Drawing.Point(6, 16);
            this.labelBaseColor.Name = "labelBaseColor";
            this.labelBaseColor.Size = new System.Drawing.Size(89, 34);
            this.labelBaseColor.TabIndex = 2;
            this.labelBaseColor.Text = "Основной цвет";
            this.labelBaseColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBaseColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
            this.labelBaseColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // colorPanel1
            // 
            this.colorPanel1.BackColor = System.Drawing.Color.Red;
            this.colorPanel1.Location = new System.Drawing.Point(6, 59);
            this.colorPanel1.Name = "colorPanel1";
            this.colorPanel1.Size = new System.Drawing.Size(41, 40);
            this.colorPanel1.TabIndex = 0;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(429, 168);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(96, 23);
            this.buttonOk.TabIndex = 5;
            this.buttonOk.Text = "Добавить";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(429, 197);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(96, 23);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormBoatConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 225);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panelBoat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormBoatConfig";
            this.Text = "Выбор лодки";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRotors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeigth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBoat)).EndInit();
            this.panelBoat.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelShip;
        private System.Windows.Forms.Label labelBoat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numericUpDownSpeed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxLines;
        private System.Windows.Forms.NumericUpDown numericUpDownWeigth;
        private System.Windows.Forms.CheckBox checkBoxRotors;
        private System.Windows.Forms.CheckBox checkBoxWindow;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownRotors;
        private System.Windows.Forms.PictureBox pictureBoxBoat;
        private System.Windows.Forms.Panel panelBoat;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel colorPanel5;
        private System.Windows.Forms.Panel colorPanel4;
        private System.Windows.Forms.Panel colorPanel6;
        private System.Windows.Forms.Panel colorPanel3;
        private System.Windows.Forms.Panel colorPanel7;
        private System.Windows.Forms.Panel colorPanel8;
        private System.Windows.Forms.Panel colorPanel2;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.Label labelBaseColor;
        private System.Windows.Forms.Panel colorPanel1;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
    }
}