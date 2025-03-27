using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Artefacts
{
    public partial class ArtefactDialog : Form
    {
        public string ArtifactName { get; set; }
        public int Value { get; set; }
        public double Age { get; set; }
        public ArtefactDialog()
        {
            InitializeComponent();
        }
        private void ArtefactDialog_Load(object sender, EventArgs e)
        {           
            TxtAge.Text = Age.ToString();
            TxtValue.Text = Value.ToString();
            TxtName.Text = ArtifactName;
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Name = TxtName.Text;
            Age = double.Parse(TxtAge.Text);
            Value = int.Parse(TxtValue.Text);
            Close();
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
