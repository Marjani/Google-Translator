namespace RavSoft.GoogleTranslator
{
    partial class GoogleTranslatorFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoogleTranslatorFrm));
            this.label1 = new System.Windows.Forms.Label();
            this._comboFrom = new System.Windows.Forms.ComboBox();
            this._comboTo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this._editSourceText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._editTarget = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this._editReverseTranslation = new System.Windows.Forms.TextBox();
            this._btnTranslate = new System.Windows.Forms.Button();
            this._lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source language:";
            // 
            // _comboFrom
            // 
            this._comboFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboFrom.FormattingEnabled = true;
            this._comboFrom.Location = new System.Drawing.Point(8, 24);
            this._comboFrom.MaxDropDownItems = 20;
            this._comboFrom.Name = "_comboFrom";
            this._comboFrom.Size = new System.Drawing.Size(156, 21);
            this._comboFrom.Sorted = true;
            this._comboFrom.TabIndex = 1;
            // 
            // _comboTo
            // 
            this._comboTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboTo.FormattingEnabled = true;
            this._comboTo.Location = new System.Drawing.Point(184, 24);
            this._comboTo.MaxDropDownItems = 20;
            this._comboTo.Name = "_comboTo";
            this._comboTo.Size = new System.Drawing.Size(156, 21);
            this._comboTo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Target language:";
            // 
            // _editSourceText
            // 
            this._editSourceText.Location = new System.Drawing.Point(8, 68);
            this._editSourceText.Multiline = true;
            this._editSourceText.Name = "_editSourceText";
            this._editSourceText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this._editSourceText.Size = new System.Drawing.Size(332, 60);
            this._editSourceText.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Source text:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(313, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Target text (non-Western characters may not display correctly)";
            // 
            // _editTarget
            // 
            this._editTarget.Location = new System.Drawing.Point(8, 148);
            this._editTarget.Multiline = true;
            this._editTarget.Name = "_editTarget";
            this._editTarget.ReadOnly = true;
            this._editTarget.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this._editTarget.Size = new System.Drawing.Size(332, 60);
            this._editTarget.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Reverse translation:";
            // 
            // _editReverseTranslation
            // 
            this._editReverseTranslation.Location = new System.Drawing.Point(8, 228);
            this._editReverseTranslation.Multiline = true;
            this._editReverseTranslation.Name = "_editReverseTranslation";
            this._editReverseTranslation.ReadOnly = true;
            this._editReverseTranslation.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this._editReverseTranslation.Size = new System.Drawing.Size(332, 60);
            this._editReverseTranslation.TabIndex = 9;
            // 
            // _btnTranslate
            // 
            this._btnTranslate.Location = new System.Drawing.Point(264, 296);
            this._btnTranslate.Name = "_btnTranslate";
            this._btnTranslate.Size = new System.Drawing.Size(75, 23);
            this._btnTranslate.TabIndex = 10;
            this._btnTranslate.Text = "Translate";
            this._btnTranslate.UseVisualStyleBackColor = true;
            this._btnTranslate.Click += new System.EventHandler(this._btnTranslate_Click);
            // 
            // _lblStatus
            // 
            this._lblStatus.AutoSize = true;
            this._lblStatus.Location = new System.Drawing.Point(8, 304);
            this._lblStatus.Name = "_lblStatus";
            this._lblStatus.Size = new System.Drawing.Size(10, 13);
            this._lblStatus.TabIndex = 11;
            this._lblStatus.Text = " ";
            // 
            // GoogleTranslatorFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 327);
            this.Controls.Add(this._lblStatus);
            this.Controls.Add(this._btnTranslate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._editReverseTranslation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._editTarget);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._editSourceText);
            this.Controls.Add(this._comboTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._comboFrom);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GoogleTranslatorFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marjani.Net | Google Translator Demo";
            this.Load += new System.EventHandler(this.GoogleTranslatorFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox _comboFrom;
        private System.Windows.Forms.ComboBox _comboTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _editSourceText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _editTarget;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox _editReverseTranslation;
        private System.Windows.Forms.Button _btnTranslate;
        private System.Windows.Forms.Label _lblStatus;
    }
}