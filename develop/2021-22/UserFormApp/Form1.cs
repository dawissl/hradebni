using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> seznam = new List<string>();


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            ListBoxUsers.Items.Add(TxtName.Text);
           // ListBoxUsers.Items.Add(new Person(TxtName.Text, TxtSurname.Text));
        
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }

    public class Person
    {
        private string name;
        private string surname;
        private string mail;

        public Person(string n, string s)
        {
            name = n;
            surname = s;
            mail = n + "." + s + "@hradebni.cz";
        }

       public override string ToString()
        {
            return mail;
        }
    }
}
