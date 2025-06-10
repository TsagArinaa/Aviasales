namespace Aviasales
{
    public partial class FormAviasales : Form
    {
        string filePath = "ListFligth.txt";
        List<Fligth> left = new List<Fligth>();
        List<string> right = new List<string>();

        public FormAviasales()
        {
            InitializeComponent();
            LoadLeft();
        }

        void LoadLeft()
        {
            LoadFromFile();
            foreach (Fligth item in left)
                listBoxFligth.Items.Add(item.ToString());
        }

        void LoadRight()
        {

            foreach (string item in right)
                listBoxSelected.Items.Add(item);

        }

        void LoadFromFile()
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] data = line.Split('|');
                    Fligth fligth = new(data[0], data[1], data[2]);

                    left.Add(fligth);
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBoxFligth_DoubleClick(object sender, EventArgs e)
        {

            FormData form = new();
            form.ShowDialog();
            MessageBox.Show(form.Name);

            right.Clear();
            right.Add(listBoxFligth.SelectedItem?.ToString() + form.Name ?? "");

            LoadRight();
            
        }
    }
}
