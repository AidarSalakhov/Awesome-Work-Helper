namespace Awesome_Work_Helper
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonNormalizePhones = new System.Windows.Forms.Button();
            this.labelNormalizePhones = new System.Windows.Forms.Label();
            this.groupBoxDescription = new System.Windows.Forms.GroupBox();
            this.groupBoxActions = new System.Windows.Forms.GroupBox();
            this.groupBoxDescription.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNormalizePhones
            // 
            this.buttonNormalizePhones.BackColor = System.Drawing.Color.Gold;
            this.buttonNormalizePhones.Location = new System.Drawing.Point(21, 35);
            this.buttonNormalizePhones.Name = "buttonNormalizePhones";
            this.buttonNormalizePhones.Size = new System.Drawing.Size(190, 42);
            this.buttonNormalizePhones.TabIndex = 0;
            this.buttonNormalizePhones.Text = "Нормализация телефонов";
            this.buttonNormalizePhones.UseVisualStyleBackColor = false;
            // 
            // labelNormalizePhones
            // 
            this.labelNormalizePhones.AutoSize = true;
            this.labelNormalizePhones.Location = new System.Drawing.Point(6, 32);
            this.labelNormalizePhones.Name = "labelNormalizePhones";
            this.labelNormalizePhones.Size = new System.Drawing.Size(498, 15);
            this.labelNormalizePhones.TabIndex = 1;
            this.labelNormalizePhones.Text = "Очистить CSV файл от букв и символов, оставить только корректные номера телефонов" +
    "";
            // 
            // groupBoxDescription
            // 
            this.groupBoxDescription.Controls.Add(this.labelNormalizePhones);
            this.groupBoxDescription.Location = new System.Drawing.Point(217, 12);
            this.groupBoxDescription.Name = "groupBoxDescription";
            this.groupBoxDescription.Size = new System.Drawing.Size(515, 547);
            this.groupBoxDescription.TabIndex = 2;
            this.groupBoxDescription.TabStop = false;
            this.groupBoxDescription.Text = "Описание действия";
            // 
            // groupBoxActions
            // 
            this.groupBoxActions.Location = new System.Drawing.Point(12, 12);
            this.groupBoxActions.Name = "groupBoxActions";
            this.groupBoxActions.Size = new System.Drawing.Size(205, 547);
            this.groupBoxActions.TabIndex = 3;
            this.groupBoxActions.TabStop = false;
            this.groupBoxActions.Text = "Действия";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 571);
            this.Controls.Add(this.buttonNormalizePhones);
            this.Controls.Add(this.groupBoxDescription);
            this.Controls.Add(this.groupBoxActions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Awesome Work Helper";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBoxDescription.ResumeLayout(false);
            this.groupBoxDescription.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonNormalizePhones;
        private Label labelNormalizePhones;
        private GroupBox groupBoxDescription;
        private GroupBox groupBoxActions;
    }
}