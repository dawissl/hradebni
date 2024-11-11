namespace _02_Knihovna
{
    public partial class Form1 : Form
    {
        private List<Book> books = new List<Book>();

        public Form1()
        {
            InitializeComponent();
            InitBooks();
        }

        private void InitBooks()
        {
            foreach (Book b in Book.GenerateSampleBooks())
            {
                ListLibrary.Items.Add(b);
                books.Add(b);
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            // Filtrujeme knihy p��mo pomoc� LINQ a pouze jednou pro v�echny podm�nky
            var query = books.AsEnumerable();

            if (ChAuthor.Checked && !string.IsNullOrWhiteSpace(TxtAuthor.Text))
            {
                query = query.Where(b => b.Author == TxtAuthor.Text);
            }

            if (ChTitle.Checked && !string.IsNullOrWhiteSpace(TxtTitle.Text))
            {
                query = query.Where(b => b.Title == TxtTitle.Text);
            }

            if (ChPublisher.Checked && !string.IsNullOrWhiteSpace(TxtPublisher.Text))
            {
                query = query.Where(b => b.Publisher == TxtPublisher.Text);
            }

            if (ChSort.Checked)
            {
                query = query.OrderBy(b => b.ISBN);
            }

            if (NumCount.Value > 0)
            {
                query = query.Take((int)NumCount.Value);
            }

            var booksFiltered = query.ToList();

            // Vy�i�t�n� seznamu ListSelected a p�id�n� v�sledk�
            ClearList();
            if (booksFiltered.Any())
            {
                foreach (Book b in booksFiltered)
                {
                    ListSelected.Items.Add(b);
                }
            }
            else
            {
                MessageBox.Show("Zadan�mu filtru vyhled�v�n� neodpov�d� ��dn� kniha");
            }
        }

        private void ClearList()
        {
            ListSelected.Items.Clear(); // Sta�� zavolat pouze Clear
        }
    }
}
