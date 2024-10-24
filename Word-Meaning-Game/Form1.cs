using System.Data.OleDb;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Word_Meaning_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int skor = 0;
        int s�re = 90;
        string kelime, answer;
        Random rnd = new Random();
        OleDbConnection baglant� = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\WIN-10\OneDrive\Masa�st�\dbSozluk\dbSozluk.accdb");
        private void Form1_Load(object sender, EventArgs e)
        {
            lblAnswer.Visible = false;
            lblS�re.Text = s�re.ToString();
            soru();
            timer1.Start();
            txtTurkce.Focus();
            Yanl�sCevap();
        }
        void soru()
        {
            rdGoster.Checked = false;
            Yanl�sCevap();
            int ID = rnd.Next(1, 2490);
            baglant�.Open();
            OleDbCommand komut = new OleDbCommand("Select * From sozluk where id=@p1", baglant�);
            komut.Parameters.AddWithValue("@p1", ID);
            OleDbDataReader dataReader = komut.ExecuteReader();
            while (dataReader.Read())
            {
                txtEnglish.Text = dataReader[1].ToString();
                lblAnswer.Text = dataReader[2].ToString();
            }
            baglant�.Close();
        }

        private void txtTurkce_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtTurkce.Text.ToLower() == lblAnswer.Text.ToLower())
                {
                    skor++;
                    lblSkor.Text = skor.ToString();
                    soru();
                }
                else
                {
                    skor--;
                    lblSkor.Text = skor.ToString();
                    soru();
                    DogruCevap();
                }
                txtTurkce.Clear();
            }
        }
        void DogruCevap()
        {
            lblMean.Visible = true;
            lblMean.Text = txtEnglish.Text + ": " + lblAnswer.Text;
        }
        void Yanl�sCevap()
        {
            lblMean.Visible = false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            s�re--;
            lblS�re.Text = s�re.ToString();
            if (s�re == 0)
            {
                txtEnglish.Enabled = false;
                txtTurkce.Enabled = false;
                timer1.Stop();
            }
        }

        private void btnPas_Click(object sender, EventArgs e)
        {
            soru();
        }

        private void rdGoster_CheckedChanged(object sender, EventArgs e)
        {
            DogruCevap();
        }

        private void rdGizle_CheckedChanged(object sender, EventArgs e)
        {
            Yanl�sCevap();
        }
    }
}
