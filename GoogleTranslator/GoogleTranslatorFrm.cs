// Copyright (c) 2015 AmirHossein Marjani
// License: Code Project Open License
// Author: amirhossein@marjani.net
// http://marjani.net/blog
// http://www.codeproject.com/info/cpol10.aspx

using Marjani.Net.Utility;
using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;


namespace RavSoft.GoogleTranslator
{
    /// <summary>
    /// A sample application to demonstrate the <see cref="Translator"/> class.
    /// </summary>
    public partial class GoogleTranslatorFrm : Form
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleTranslatorFrm"/> class.
        /// </summary>
        public GoogleTranslatorFrm()
        {
            InitializeComponent();
        }

        #endregion

        #region Form event handlers

        /// <summary>
        /// Handles the Load event of the GoogleTranslatorFrm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void GoogleTranslatorFrm_Load
            (object sender,
             EventArgs e)
        {
            this._comboFrom.Items.AddRange(Translator.Languages.ToArray());
            this._comboTo.Items.AddRange(Translator.Languages.ToArray());
            this._comboFrom.SelectedItem = "English";
            this._comboTo.SelectedItem = "Persian";
        }

        #endregion

        #region Button handlers

        /// <summary>
        /// Handles the Click event of the _btnTranslate control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void _btnTranslate_Click
            (object sender,
             EventArgs e)
        {
            // Initialize the translator
            Marjani.Net.Utility.Translator t = new Marjani.Net.Utility.Translator();
            t.SourceLanguage = (string)this._comboFrom.SelectedItem;
            t.TargetLanguage = (string)this._comboTo.SelectedItem;
            t.SourceText = this._editSourceText.Text;

            this._editTarget.Text = string.Empty;
            this._editTarget.Update();
            this._editReverseTranslation.Text = string.Empty;
            this._editReverseTranslation.Update();

            // Translate the text
            try
            {
                // Forward translation
                this.Cursor = Cursors.WaitCursor;
                this._lblStatus.Text = "Translating...";
                this._lblStatus.Update();
                t.Translate();
                this._editTarget.Text = t.Translation;
                this._editTarget.Update();

                // Reverse translation
                this._lblStatus.Text = "Reverse translating...";
                this._lblStatus.Update();
                Thread.Sleep(500); // let Google breathe
                t.SourceLanguage = (string)this._comboTo.SelectedItem;
                t.TargetLanguage = (string)this._comboFrom.SelectedItem;
                t.SourceText = this._editTarget.Text;
                t.Translate();
                this._editReverseTranslation.Text = t.Translation;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                this._lblStatus.Text = string.Empty;
                this.Cursor = Cursors.Default;
            }
        }

        #endregion
    }
}
