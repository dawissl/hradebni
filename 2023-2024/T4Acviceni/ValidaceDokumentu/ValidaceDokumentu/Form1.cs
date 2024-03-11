namespace ValidaceDokumentu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnValidate_Click(object sender, EventArgs e)
        {
            if (FolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                if (!Directory.Exists(FolderBrowserDialog.SelectedPath))
                {
                    MessageBox.Show("Zadaná cesta k adresáøi neexistuje");
                    return;
                }
                // vyètení všech souborù txt
                string[] docs = Directory.GetFiles(FolderBrowserDialog.SelectedPath, "*.txt");
                string files = "";
                foreach (string doc in docs)
                {
                    string[] splitted = doc.Split('\\');
                    files += $"{splitted[splitted.Length - 1].Replace(".txt","")} {ValidateDoc(doc)} {Environment.NewLine}";
                }
                LblFiles.Text = files;

            }
        }

        /// <summary>
        /// Validate document passed as a path
        /// </summary>
        /// <param name="doc">path to file</param>
        /// <returns> + if file is valid else X </returns>
        private string ValidateDoc(string doc)
        {
            using (StreamReader sr = new StreamReader(doc))
            {
                string[] content = sr.ReadToEnd().Split(Environment.NewLine);
                // jednoduchá kontrola poètu øádkù
                if (content.Length < 3 || content.Length > 4)
                {
                    sr.Close();
                    return "X";
                }
                if (content[2].Length != 10)
                {
                    sr.Close();
                    return "X";
                }
                else
                {
                    double suma = 0;
                    for (int i = 10; i > 0;i--)
                    {
                        if (!Char.IsDigit(content[2][10-i]))
                        {
                            sr.Close();
                            return "X";
                        }
                        else
                        {
                            suma += char.GetNumericValue(content[2][10 - i])*i;
                        }
                    }
                    if (suma%11 != 0)
                    {
                        sr.Close();
                        return "X";
                    }

                }


                sr.Close();
            }
            return "+";
        }
    }
}