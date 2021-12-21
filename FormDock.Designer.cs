
namespace WinFormsLaba1
{
    partial class FormDock
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
            this.pictureBoxDock = new System.Windows.Forms.PictureBox();
            this.buttonSetBoat = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonTakeBoat = new System.Windows.Forms.Button();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNewLevelName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBoxDocks = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.buttonSort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDock)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxDock
            // 
            this.pictureBoxDock.Location = new System.Drawing.Point(0, 26);
            this.pictureBoxDock.Name = "pictureBoxDock";
            this.pictureBoxDock.Size = new System.Drawing.Size(656, 424);
            this.pictureBoxDock.TabIndex = 0;
            this.pictureBoxDock.TabStop = false;
            // 
            // buttonSetBoat
            // 
            this.buttonSetBoat.Location = new System.Drawing.Point(673, 282);
            this.buttonSetBoat.Name = "buttonSetBoat";
            this.buttonSetBoat.Size = new System.Drawing.Size(115, 34);
            this.buttonSetBoat.TabIndex = 2;
            this.buttonSetBoat.Text = "Добавить лодку";
            this.buttonSetBoat.UseVisualStyleBackColor = true;
            this.buttonSetBoat.Click += new System.EventHandler(this.buttonSetBoat_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonTakeBoat);
            this.groupBox2.Controls.Add(this.maskedTextBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(673, 322);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(115, 77);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Забрать судно";
            // 
            // buttonTakeBoat
            // 
            this.buttonTakeBoat.Location = new System.Drawing.Point(11, 47);
            this.buttonTakeBoat.Name = "buttonTakeBoat";
            this.buttonTakeBoat.Size = new System.Drawing.Size(98, 23);
            this.buttonTakeBoat.TabIndex = 2;
            this.buttonTakeBoat.Text = "Забрать";
            this.buttonTakeBoat.UseVisualStyleBackColor = true;
            this.buttonTakeBoat.Click += new System.EventHandler(this.buttonTakeBoat_Click);
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(73, 20);
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(36, 20);
            this.maskedTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Пристань:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(709, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Гавани";
            // 
            // textBoxNewLevelName
            // 
            this.textBoxNewLevelName.Location = new System.Drawing.Point(673, 26);
            this.textBoxNewLevelName.Name = "textBoxNewLevelName";
            this.textBoxNewLevelName.Size = new System.Drawing.Size(115, 20);
            this.textBoxNewLevelName.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(673, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Добавить гавань";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonAddDock_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(673, 184);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Удалить гавань";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonDelDock_Click);
            // 
            // listBoxDocks
            // 
            this.listBoxDocks.FormattingEnabled = true;
            this.listBoxDocks.Location = new System.Drawing.Point(673, 83);
            this.listBoxDocks.Name = "listBoxDocks";
            this.listBoxDocks.Size = new System.Drawing.Size(115, 95);
            this.listBoxDocks.TabIndex = 8;
            this.listBoxDocks.SelectedIndexChanged += new System.EventHandler(this.listBoxDocks_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "txt file | *.txt";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "txt file | *.txt";
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(673, 213);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(115, 23);
            this.buttonSort.TabIndex = 10;
            this.buttonSort.Text = "Сортировать";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // FormDock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.listBoxDocks);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxNewLevelName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonSetBoat);
            this.Controls.Add(this.pictureBoxDock);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormDock";
            this.Text = "Гавань";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDock)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDock;
        private System.Windows.Forms.Button buttonSetBoat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonTakeBoat;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNewLevelName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBoxDocks;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button buttonSort;
    }
}