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
            this.buttonGetPhones = new System.Windows.Forms.Button();
            this.labelNormalizePhones = new System.Windows.Forms.Label();
            this.groupBoxDescription = new System.Windows.Forms.GroupBox();
            this.groupBoxActions = new System.Windows.Forms.GroupBox();
            this.buttonGetEmail = new System.Windows.Forms.Button();
            this.labelGetEmail = new System.Windows.Forms.Label();
            this.groupBoxDescription.SuspendLayout();
            this.groupBoxActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGetPhones
            // 
            this.buttonGetPhones.BackColor = System.Drawing.Color.Gold;
            this.buttonGetPhones.Location = new System.Drawing.Point(21, 35);
            this.buttonGetPhones.Name = "buttonGetPhones";
            this.buttonGetPhones.Size = new System.Drawing.Size(190, 42);
            this.buttonGetPhones.TabIndex = 0;
            this.buttonGetPhones.Text = "Получить все телефоны из CSV";
            this.buttonGetPhones.UseVisualStyleBackColor = false;
            // 
            // labelNormalizePhones
            // 
            this.labelNormalizePhones.AutoSize = true;
            this.labelNormalizePhones.Location = new System.Drawing.Point(6, 32);
            this.labelNormalizePhones.Name = "labelNormalizePhones";
            this.labelNormalizePhones.Size = new System.Drawing.Size(474, 15);
            this.labelNormalizePhones.TabIndex = 1;
            this.labelNormalizePhones.Text = "Очистить файл от букв и символов, оставить только корректные номера телефонов";
            // 
            // groupBoxDescription
            // 
            this.groupBoxDescription.Controls.Add(this.labelGetEmail);
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
            this.groupBoxActions.Controls.Add(this.buttonGetEmail);
            this.groupBoxActions.Location = new System.Drawing.Point(12, 12);
            this.groupBoxActions.Name = "groupBoxActions";
            this.groupBoxActions.Size = new System.Drawing.Size(205, 547);
            this.groupBoxActions.TabIndex = 3;
            this.groupBoxActions.TabStop = false;
            this.groupBoxActions.Text = "Действия";
            // 
            // buttonGetEmail
            // 
            this.buttonGetEmail.BackColor = System.Drawing.Color.Gold;
            this.buttonGetEmail.Location = new System.Drawing.Point(9, 71);
            this.buttonGetEmail.Name = "buttonGetEmail";
            this.buttonGetEmail.Size = new System.Drawing.Size(190, 42);
            this.buttonGetEmail.TabIndex = 4;
            this.buttonGetEmail.Text = "Получить все e-mail из CSV";
            this.buttonGetEmail.UseVisualStyleBackColor = false;
            // 
            // labelGetEmail
            // 
            this.labelGetEmail.AutoSize = true;
            this.labelGetEmail.Location = new System.Drawing.Point(6, 85);
            this.labelGetEmail.Name = "labelGetEmail";
            this.labelGetEmail.Size = new System.Drawing.Size(324, 15);
            this.labelGetEmail.TabIndex = 2;
            this.labelGetEmail.Text = "Очистить файл от всех данных, кроме корректных e-mail\r\n";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 571);
            this.Controls.Add(this.buttonGetPhones);
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
            this.groupBoxActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonGetPhones;
        private Label labelNormalizePhones;
        private GroupBox groupBoxDescription;
        private GroupBox groupBoxActions;
        private Button buttonGetEmail;
        private Label labelGetEmail;
    }
}