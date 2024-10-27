using _04___Binary_Files.DAO;

namespace _04___Binary_Files
{
    public partial class Form1 : Form
    {

        private IDAOFactory factory;
        private IDAO dao;
        private bool isSeedFixed = false;
        public Form1()
        {
            InitializeComponent();
            LoadBinFilesToTreeView();
            factory = new IDAOFactory();
            btnTest.Enabled = false;
            btnWrite.Enabled = false;
            btnRead.Enabled = false;
        }

        private void btnSeed_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbSeed.Text.Length != 4)
                    throw new Exception();

                else
                {
                    dao = factory.DAOFactory(tbSeed.Text, true);
                    lblFixSeedFet.Text = "Fix Seed completat";
                    isSeedFixed = true;
                    btnTest.Enabled = true;
                    btnRead.Enabled = true;
                    LoadBinFilesToTreeView();
                }

            }
            catch (FormatException ex)
            {
                MessageBox.Show("Input mal formatat", "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show("La seed te que ser de exactament 4 nums", "Error");
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            try
            {
                string nom = tbNom.Text;
                string nif = tbNif.Text;
                if (nif.Length != 9 || nom == null || nif == null || tbSeed == null)
                {
                    throw new Exception();
                }
                if (dao.IsFeasible(nom, nif))
                {
                    lblTest.Text = "OK";
                    btnWrite.Enabled = true;
                }
                else
                    lblTest.Text = "NOT OK";
            }
            catch (FormatException)
            {
                MessageBox.Show("Input mal formatat", "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nif mal formatat o parametres buits", "Error");

            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                string nom = tbNom.Text;
                string nif = tbNif.Text;
                if (nif.Length != 9 || nom == null || nif == null || tbSeed == null)
                {
                    throw new Exception();
                }
                dao.WriteData(nom, nif);
                dao.Dispose();
                dao = factory.DAOFactory(tbSeed.Text, false);
                lblWrite.Text = "OK";
                LoadBinFilesToTreeView();
                dao.Dispose();

            }
            catch (FormatException)
            {
                MessageBox.Show("Input mal formatat", "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nif mal formatat o parametres buits", "Error");

            }
        }

        private void btnReadFixSeed_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtReadSeed.Text.Length != 4)
                    throw new Exception();

                else
                {
                    dao = factory.DAOFactory(txtReadSeed.Text, false);
                    lblReadFixSeed.Text = "OK";
                    isSeedFixed = true;
                    btnRead.Enabled = true;
                }

            }
            catch (FormatException ex)
            {
                MessageBox.Show("Input mal formatat", "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show("La seed te que ser de exactament 4 nums", "Error");
            }

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                string nom = txtReadNom.Text;
                string nif = txtReadNif.Text;
                if (nom != "" || nif != "")
                {
                    throw new Exception();
                }
                else
                {
                    txtReadNom.Text = dao.ReadName();
                    txtReadNif.Text = dao.ReadNIF();
                    lblRead.Text = "OK";

                    dao.Dispose();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Input mal formatat", "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show("PARAMETRES TENEN QUE ESTAR BUITS", "Error");

            }
        }
        private void LoadBinFilesToTreeView()
        {
            tvFitxers.Nodes.Clear();

            string folderPath = AppDomain.CurrentDomain.BaseDirectory;

            string[] binFiles = Directory.GetFiles(folderPath, "*.bin");

            foreach (string filePath in binFiles)
            {
                string fileName = Path.GetFileName(filePath);
                TreeNode node = new TreeNode(fileName)
                {
                    Tag = filePath
                };

                tvFitxers.Nodes.Add(node);
            }
        }
        private void tvFitxers_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node != null)
            {
                string filePath = e.Node.Tag.ToString();

                string seed = Path.GetFileNameWithoutExtension(filePath);

                tbSeed.Text = seed;
                txtReadSeed.Text = seed;
                dao = factory.DAOFactory(txtReadSeed.Text, false);
                lblReadFixSeed.Text = "OK";
                isSeedFixed = true;
                btnRead.Enabled = true;
                txtReadNom.Text = dao.ReadName();
                txtReadNif.Text = dao.ReadNIF();
                lblRead.Text = "OK";

                dao.Dispose();
            }
        }

        private void btnCambiarSeed_Click(object sender, EventArgs e)
        {
            isSeedFixed = false;
            if (dao!=null)
            {
                dao.Dispose();
            }
            tbNif.Text = "";
            tbNom.Text = "";
            tbSeed.Text = "";
        }
    }
}
