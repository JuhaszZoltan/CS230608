namespace UtasszallitokGUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            btnSzamol.Click += OnBtnSzamolClick;
        }

        private void OnBtnSzamolClick(object? sender, EventArgs e)
        {

            try
            {
                float qc = float.Parse(txtTorloNyomas.Text.Replace('.', ','));
                float p0 = float.Parse(txtStatikusNyomas.Text.Replace('.', ','));
                double ma = Math.Sqrt(5 * (Math.Pow(qc / p0 + 1, 2.0 / 7.0) - 1));
                if (ma < 1)
                {
                    lsbEredmenyek.Items.Add($"qc={qc} p0={p0} Ma={ma}");
                }
            }
            catch
            {
                MessageBox.Show("Nem megfelelõ a számok formátuma");
            }
        }
    }
}