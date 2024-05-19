using MySqlConnector;

namespace RealESTATESGUI
{
    public partial class MainFrame : Form
    {
        //Felvesz�nk egy list�t a lek�rt adatok t�rol�s�ra.
        private List<Seller> sellers = new List<Seller>();
        public MainFrame()
        {
            InitializeComponent();
            LoadSellers(); //Itt kell meghivni a met�dust.
        }
        private void LoadSellers() //L�trehozod a met�dust.
        {
            //Ez az adatb�zis kapcsol�d�s v�ltoz�ja.
            string connectionString = "Server=localhost;Port=3306;" +
                "Database=ingatlan;User=root;Password=;";
            //Ez pedig a lek�rdez�s�nk.
            //string query = "SELECT name FROM sellers";
            //Mdositjuk erre.
            string query = "SELECT id, name, phone FROM sellers";
            //Itt vessz�k haszn�latba a MySql Connectort.
            using (var connection = new MySqlConnection(connectionString))
            {   //Kiv�tel kezel�s.
                try
                {   //Adatb�zis kapcsolat megnyit�sa.
                    connection.Open();
                    using (var command = new MySqlCommand(query, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {   //Amig az olvas� (Olvas) met�dus fut addig 
                            //hozz� rendel egy-egy rekordot a listBox elemhez.
                            while (reader.Read())
                            {   //M�dositjuk ezt!
                                //listBox1.Items.Add(reader.GetString("name"));
                                //L�trehozunk egy p�ld�nyt �s hozz�rendelj�k a list�nkhoz.
                                var seller = new Seller(
                                    reader.GetInt32("id"),
                                    reader.GetString("name"),
                                    reader.GetString("phone")
                                );
                                sellers.Add(seller);
                                listBox1.Items.Add(seller);
                            }
                        }
                    }
                }
                catch (MySqlException ex)
                {   //Ha valami nem stimmel.
                    MessageBox.Show("Hiba t�rt�nt az adatb�zishoz val� kapcsol�d�s sor�n: "
                        + ex.Message);
                }
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {   //M�dositjuk ezt is!
                //sellerNameTextLabel.Text = listBox1.SelectedItem.ToString();
                var selectedSeller = (Seller)listBox1.SelectedItem;
                sellerNameTextLabel.Text = selectedSeller.SellerName;
                sellerPhoneTextLabel.Text = selectedSeller.SellerPhone;
            }
        }

        private void LoadAdsButton_Click(object sender, EventArgs e)
        {   //Itt �lltjuk be, hogy a label �rt�ke a megsz�ml�lt �rt�k legyen.
            if (listBox1.SelectedItem != null)
            {   //Meghivjuk az el?bb l�trehozott met�dust.
                var selectedSeller = (Seller)listBox1.SelectedItem;
                int adsCount = GetAdsCountBySeller(selectedSeller.SellerId);
                adsCountLabel.Text = adsCount.ToString();
            }
        }
        private int GetAdsCountBySeller(int sellerId)
        {   //Itt l�trehozzuk a met�dust a megsz�ml�l�shoz.
            int adsCount = 0;
            //Adatb�zis kapcsol�d�s adatai.
            string connectionString = "Server=localhost;Port=3306;Database=ingatlan;" + 
                "User=root;Password=;";
            //A lek�rdez�s�nk.
            string query = "SELECT COUNT(*) FROM realestates WHERE sellerId = @SellerId";
            //Itt vessz�k haszn�latba a MySql Connectort.
            using (var connection = new MySqlConnection(connectionString))
            {   //KKiv�tel kezel�s.
                try
                {   //Adatb�zis kapcsolat megnyit�sa.
                    connection.Open();
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SellerId", sellerId);
                        adsCount = Convert.ToInt32(command.ExecuteScalar());
                    }
                }
                catch (MySqlException ex) //Ha valami nem stimmel.
                {
                    MessageBox.Show("Hiba t�rt�nt az adatb�zishoz val� kapcsol�d�s sor�n: "
                        + ex.Message);
                }
            }

            return adsCount;
        }
    }
}