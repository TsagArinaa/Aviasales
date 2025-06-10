namespace Aviasales
{
    public partial class FormAviasales : Form
    {
        string filePath = "ListFligth.txt";
        List<string> left = new List<string>();
        List<string> right = new List<string>();

        public FormAviasales()
        {
            InitializeComponent();
            LoadLeft();
        }

        void LoadLeft()
        {
            LoadFromFile();
            foreach (string item in left)
                listBoxFligth.Items.Add(item);
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
                    left.Add(string.Join(" ", line.Split('|')));
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBoxFligth_DoubleClick(object sender, EventArgs e)
        {
            right.Clear();
            right.Add(listBoxFligth.SelectedItem?.ToString() ?? "");
            LoadRight();
        }
    }
}
