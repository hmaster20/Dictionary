namespace Dictionary
{
    partial class Edit
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
            this.btOk = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.tbWordEn = new System.Windows.Forms.TextBox();
            this.tbWordRu = new System.Windows.Forms.TextBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.lEn = new System.Windows.Forms.Label();
            this.lRu = new System.Windows.Forms.Label();
            this.lType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btOk
            // 
            this.btOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btOk.Location = new System.Drawing.Point(49, 212);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 23);
            this.btOk.TabIndex = 3;
            this.btOk.Text = "Ok";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(187, 212);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 4;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // tbWordEn
            // 
            this.tbWordEn.Location = new System.Drawing.Point(97, 36);
            this.tbWordEn.Name = "tbWordEn";
            this.tbWordEn.Size = new System.Drawing.Size(182, 20);
            this.tbWordEn.TabIndex = 0;
            // 
            // tbWordRu
            // 
            this.tbWordRu.Location = new System.Drawing.Point(97, 75);
            this.tbWordRu.Name = "tbWordRu";
            this.tbWordRu.Size = new System.Drawing.Size(182, 20);
            this.tbWordRu.TabIndex = 1;
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(97, 116);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(182, 21);
            this.cbType.TabIndex = 2;
            // 
            // lEn
            // 
            this.lEn.AutoSize = true;
            this.lEn.Location = new System.Drawing.Point(29, 45);
            this.lEn.Name = "lEn";
            this.lEn.Size = new System.Drawing.Size(38, 13);
            this.lEn.TabIndex = 3;
            this.lEn.Text = "Слово";
            // 
            // lRu
            // 
            this.lRu.AutoSize = true;
            this.lRu.Location = new System.Drawing.Point(29, 78);
            this.lRu.Name = "lRu";
            this.lRu.Size = new System.Drawing.Size(51, 13);
            this.lRu.TabIndex = 3;
            this.lRu.Text = "Перевод";
            // 
            // lType
            // 
            this.lType.AutoSize = true;
            this.lType.Location = new System.Drawing.Point(29, 119);
            this.lType.Name = "lType";
            this.lType.Size = new System.Drawing.Size(26, 13);
            this.lType.TabIndex = 3;
            this.lType.Text = "Тип";
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 261);
            this.Controls.Add(this.lType);
            this.Controls.Add(this.lRu);
            this.Controls.Add(this.lEn);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.tbWordRu);
            this.Controls.Add(this.tbWordEn);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Edit";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Edit_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.TextBox tbWordEn;
        private System.Windows.Forms.TextBox tbWordRu;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label lEn;
        private System.Windows.Forms.Label lRu;
        private System.Windows.Forms.Label lType;
    }
}