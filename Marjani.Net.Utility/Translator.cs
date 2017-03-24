// Copyright (c) 2015 AmirHossein Marjani
// License: Code Project Open License
// Author: amirhossein@marjani.net
// http://marjani.net/blog
// http://www.codeproject.com/info/cpol10.aspx

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

namespace Marjani.Net.Utility
{
    /// <summary>
    /// Translates text using Google's online language tools.
    /// </summary>
    public class Translator
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="Translator"/> class.
        /// </summary>
        public Translator()
        {
            SourceLanguage = "English";
            TargetLanguage = "Italian";
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the source "
        /// </summary>
        /// <value>The source "</value>
        public string SourceLanguage
        {
            get;
            set;
        }

        public string GoogleApiKey
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the target "
        /// </summary>
        /// <value>The target "</value>
        public string TargetLanguage
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the source text.
        /// </summary>
        /// <value>The source text.</value>
        public string SourceText
        {
            get;
            set;
        }

        /// <summary>
        /// Gets the translation.
        /// </summary>
        /// <value>The translated text.</value>
        public string Translation
        {
            get;
            private set;
        }

        ///// <summary>
        ///// Gets the reverse translation.
        ///// </summary>
        ///// <value>The reverse translated text.</value>
        //public string ReverseTranslation
        //{
        //    get;
        //    private set;
        //}

        /// <summary>
        /// Gets the supported languages.
        /// </summary>
        public static IEnumerable<string> Languages
        {
            get
            {
                Translator.EnsureInitialized();
                return Translator._languageModeMap.Keys.OrderBy(p => p);
            }
        }

        #endregion

        #region Public methods

        /// <summary>
        /// Attempts to translate the text.
        /// </summary>
        public void Translate()
        {
            // Validate source and target languages
            if (string.IsNullOrEmpty(SourceLanguage) ||
                string.IsNullOrEmpty(TargetLanguage) ||
                SourceLanguage.Trim().Equals(TargetLanguage.Trim()))
            {
                throw new Exception("An invalid source or target language was specified.");
            }

            // Delegate to base class
            FetchResource();
        }

        private void FetchResource()
        {
            try
            {
                var url = getFetchUrl() + getPostData();

                var request = (HttpWebRequest) WebRequest.Create(url);

                var resp = request.GetResponse();
                using (var stream = resp.GetResponseStream())
                {
                    using (var sr = new StreamReader(stream))
                    {
                        Content = sr.ReadToEnd();
                        sr.Close();
                    }
                }
                parseContent();
            }
            catch{}
        }

        #endregion

        #region WebResourceProvider implementation

        /// <summary>
        /// Returns the url to be fetched.
        /// </summary>
        /// <returns>The url to be fetched.</returns>
        protected string getFetchUrl()
        {
            return "https://translation.googleapis.com/language/translate/v2";
        }

        /// <summary>
        /// Retrieves the POST data (if any) to be sent to the url to be fetched.
        /// The data is returned as a string of the form "arg=val[&arg=val]...".
        /// </summary>
        /// <returns>A string containing the POST data or null if none.</returns>
        protected string getPostData()
        {
            // Set translation mode
            string strPostData = string.Format("?key={0}&source={1}&target={2}",
                     GoogleApiKey ,                           
                            LanguageEnumToIdentifier(SourceLanguage),
                                                 LanguageEnumToIdentifier(TargetLanguage));

            // Set text to be translated
            strPostData += "&q=" + HttpUtility.UrlEncode(SourceText);
            return strPostData;
        }

        /// <summary>
        /// Parses the fetched content.
        /// </summary>
        protected void parseContent()
        {
            if (string.IsNullOrWhiteSpace(this.Content))
            {
                this.Translation = "An error has occurred!";
                return;
            }
            var translate = this.Content.Split('"')[1].Trim();
            this.Translation = translate;
        }

        #endregion

        #region Private methods

        /// <summary>
        /// Converts a language to its identifier.
        /// </summary>
        /// <param name="language">The language."</param>
        /// <returns>The identifier or <see cref="string.Empty"/> if none.</returns>
        private static string LanguageEnumToIdentifier
            (string language)
        {
            string mode = string.Empty;
            EnsureInitialized();
            _languageModeMap.TryGetValue(language, out mode);
            return mode;
        }

        /// <summary>
        /// Ensures the translator has been initialized.
        /// </summary>
        private static void EnsureInitialized()
        {
            if (_languageModeMap == null)
            {
                Translator._languageModeMap = new Dictionary<string, string>();
                Translator._languageModeMap.Add("Afrikaans", "af");
                Translator._languageModeMap.Add("Albanian", "sq");
                Translator._languageModeMap.Add("Arabic", "ar");
                Translator._languageModeMap.Add("Armenian", "hy");
                Translator._languageModeMap.Add("Azerbaijani", "az");
                Translator._languageModeMap.Add("Basque", "eu");
                Translator._languageModeMap.Add("Belarusian", "be");
                Translator._languageModeMap.Add("Bengali", "bn");
                Translator._languageModeMap.Add("Bulgarian", "bg");
                Translator._languageModeMap.Add("Catalan", "ca");
                Translator._languageModeMap.Add("Chinese", "zh-CN");
                Translator._languageModeMap.Add("Croatian", "hr");
                Translator._languageModeMap.Add("Czech", "cs");
                Translator._languageModeMap.Add("Danish", "da");
                Translator._languageModeMap.Add("Dutch", "nl");
                Translator._languageModeMap.Add("English", "en");
                Translator._languageModeMap.Add("Esperanto", "eo");
                Translator._languageModeMap.Add("Estonian", "et");
                Translator._languageModeMap.Add("Filipino", "tl");
                Translator._languageModeMap.Add("Finnish", "fi");
                Translator._languageModeMap.Add("French", "fr");
                Translator._languageModeMap.Add("Galician", "gl");
                Translator._languageModeMap.Add("German", "de");
                Translator._languageModeMap.Add("Georgian", "ka");
                Translator._languageModeMap.Add("Greek", "el");
                Translator._languageModeMap.Add("Haitian Creole", "ht");
                Translator._languageModeMap.Add("Hebrew", "iw");
                Translator._languageModeMap.Add("Hindi", "hi");
                Translator._languageModeMap.Add("Hungarian", "hu");
                Translator._languageModeMap.Add("Icelandic", "is");
                Translator._languageModeMap.Add("Indonesian", "id");
                Translator._languageModeMap.Add("Irish", "ga");
                Translator._languageModeMap.Add("Italian", "it");
                Translator._languageModeMap.Add("Japanese", "ja");
                Translator._languageModeMap.Add("Korean", "ko");
                Translator._languageModeMap.Add("Lao", "lo");
                Translator._languageModeMap.Add("Latin", "la");
                Translator._languageModeMap.Add("Latvian", "lv");
                Translator._languageModeMap.Add("Lithuanian", "lt");
                Translator._languageModeMap.Add("Macedonian", "mk");
                Translator._languageModeMap.Add("Malay", "ms");
                Translator._languageModeMap.Add("Maltese", "mt");
                Translator._languageModeMap.Add("Norwegian", "no");
                Translator._languageModeMap.Add("Persian", "fa");
                Translator._languageModeMap.Add("Polish", "pl");
                Translator._languageModeMap.Add("Portuguese", "pt");
                Translator._languageModeMap.Add("Romanian", "ro");
                Translator._languageModeMap.Add("Russian", "ru");
                Translator._languageModeMap.Add("Serbian", "sr");
                Translator._languageModeMap.Add("Slovak", "sk");
                Translator._languageModeMap.Add("Slovenian", "sl");
                Translator._languageModeMap.Add("Spanish", "es");
                Translator._languageModeMap.Add("Swahili", "sw");
                Translator._languageModeMap.Add("Swedish", "sv");
                Translator._languageModeMap.Add("Tamil", "ta");
                Translator._languageModeMap.Add("Telugu", "te");
                Translator._languageModeMap.Add("Thai", "th");
                Translator._languageModeMap.Add("Turkish", "tr");
                Translator._languageModeMap.Add("Ukrainian", "uk");
                Translator._languageModeMap.Add("Urdu", "ur");
                Translator._languageModeMap.Add("Vietnamese", "vi");
                Translator._languageModeMap.Add("Welsh", "cy");
                Translator._languageModeMap.Add("Yiddish", "yi");
            }
        }

        #endregion

        #region Fields

        /// <summary>
        /// The language to translation mode map.
        /// </summary>
        private static Dictionary<string, string> _languageModeMap;

        #endregion

        public string Content { get; set; }
    }
}
