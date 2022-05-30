using System.Security.Cryptography;
using System.Text;


namespace teeest
{
    public partial class Form1 : Form
    {

        public string[] parodyti;
        public string[] projektai;
        public string[] serv;
        public string servas;
        public string[] veiks;
        public string SRVID;
        public string atlikti;
        public string tokenas;
        public string hash;


        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string Email = email.Text;
            string Pass = pass.Text;

            using (SHA1 sha1Hash = SHA1.Create())
            {
                byte[] sourceBytes = Encoding.UTF8.GetBytes(Pass);
                byte[] hashBytes = sha1Hash.ComputeHash(sourceBytes);
                hash = BitConverter.ToString(hashBytes).Replace("-", String.Empty).ToLower();
            }

            Login login = new Login();
            string pris = login.Loginas(Email, hash);
            tokenas = pris;

            Prisijungimas logon = new Prisijungimas();
            parodyti = logon.Prisijungti(tokenas);

            var EL = parodyti.Count();
            int i = 1;
            while (i < EL)
            {
                Teams.Items.Add(parodyti[i]);
                i += 2;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (Teams.SelectedItem == null)
            {
                MessageBox.Show("Please select team");
                return;
            }
            else if (Teams.SelectedItem != null)
            {
                List<string> listStrings = new List<string>();
                listStrings.AddRange(parodyti);
                int index = listStrings.IndexOf(Teams.Text);
                index -= 1;

                string TID = listStrings[index];
                // string Teamidas = parodyti[0].ToString();
                Projects proj = new Projects();
                projektai = proj.Projekt(tokenas, TID);

                var Elementai = projektai.Count();
                int i = 1;
                while (i < Elementai)
                {
                    pasirinkimas.Items.Add(projektai[i]);

                    i += 2;
                }
                TeamID.Text = "Team Id: " + TID.ToString().Trim();
                Komanda.Text = "Team Name: " + Teams.Text.Trim();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (pasirinkimas.SelectedItem == null)
            {
                MessageBox.Show("Please select project");
                return;
            }
            else if (pasirinkimas.SelectedItem != null)
            {
                //testas.Text = pasirinkimas.Text;

                List<string> listStrings = new List<string>();
                listStrings.AddRange(projektai);
                int index = listStrings.IndexOf(pasirinkimas.Text);
                index -= 1;

                string PrjID = listStrings[index];
                PrjServers srv = new PrjServers();
                serv = srv.PrServers(tokenas, PrjID);

                var Elementai = serv.Count();
                int i = 1;
                while (i < Elementai)
                {
                    Serv.Items.Add(serv[i]);

                    i += 2;
                }

                foreach (string cc in serv)
                {
                    testas.Text += cc + Environment.NewLine;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Serv.SelectedItem == null)
            {
                MessageBox.Show("Pease select server");
                return;
            }
            else if (Serv.SelectedItem != null)
            {
                Server server = new Server();
                List<string> listStrings = new List<string>();
                listStrings.AddRange(serv);
                int index = listStrings.IndexOf(Serv.Text);
                index -= 1;
                SRVID = listStrings[index];

                servas = server.Servas(tokenas, SRVID);
                testas.Text = servas;

                Actions action = new Actions();
                veiks = action.Action(tokenas, SRVID);
                // Veiksmai.Text = veiks;
                foreach (string a in veiks)
                {
                    veiksm.Items.Add(a);

                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (veiksm.SelectedItem == null)
            {
                MessageBox.Show("Please select action");
                return;
            }
            else if (veiksm.SelectedItem != null)
            {
                string SAct = veiksm.Text;
                Perform perform = new Perform();
                atlikti = perform.Perf(tokenas, SRVID, SAct);
            }
        }

    }




}
