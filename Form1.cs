using MySqlConnector;

namespace RealESTATESGUI
{
    public partial class MainFrame : Form
    {
        //Felveszünk egy listát a lekért adatok tárolására.
        private List<Seller> sellers = new List<Seller>();
        public MainFrame()
        {
            InitializeComponent();
            LoadSellers(); //Itt kell meghivni a metódust.
        }
        private void LoadSellers() //Létrehozod a metódust.
        {
            //Ez az adatbázis kapcsolódás változója.
            string connectionString = "Server=localhost;Port=3306;" +
                "Database=ingatlan;User=root;Password=;";
            //Ez pedig a lekérdezésünk.
            //string query = "SELECT name FROM sellers";
            //Mdositjuk erre.
            string query = "SELECT id, name, phone FROM sellers";
            //Itt vesszük használatba a MySql Connectort.
            using (var connection = new MySqlConnection(connectionString))
            {   //Kivétel kezelés.
                try
                {   //Adatbázis kapcsolat megnyitása.
                    connection.Open();
                    using (var command = new MySqlCommand(query, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {   //Amig az olvasó (Olvas) metódus fut addig 
                            //hozzá rendel egy-egy rekordot a listBox elemhez.
                            while (reader.Read())
                            {   //Módositjuk ezt!
                                //listBox1.Items.Add(reader.GetString("name"));
                                //Létrehozunk egy példányt és hozzárendeljük a listánkhoz.
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
                    MessageBox.Show("Hiba történt az adatbázishoz való kapcsolódás során: "
                        + ex.Message);
                }
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {   //Módositjuk ezt is!
                //sellerNameTextLabel.Text = listBox1.SelectedItem.ToString();
                var selectedSeller = (Seller)listBox1.SelectedItem;
                sellerNameTextLabel.Text = selectedSeller.SellerName;
                sellerPhoneTextLabel.Text = selectedSeller.SellerPhone;
            }
        }

        private void LoadAdsButton_Click(object sender, EventArgs e)
        {   //Itt álltjuk be, hogy a label értéke a megszámlált érték legyen.
            if (listBox1.SelectedItem != null)
            {   //Meghivjuk az el?bb létrehozott metódust.
                var selectedSeller = (Seller)listBox1.SelectedItem;
                int adsCount = GetAdsCountBySeller(selectedSeller.SellerId);
                adsCountLabel.Text = adsCount.ToString();
            }
        }
        private int GetAdsCountBySeller(int sellerId)
        {   //Itt létrehozzuk a metódust a megszámláláshoz.
            int adsCount = 0;
            //Adatbázis kapcsolódás adatai.
            string connectionString = "Server=localhost;Port=3306;Database=ingatlan;" + 
                "User=root;Password=;";
            //A lekérdezésünk.
            string query = "SELECT COUNT(*) FROM realestates WHERE sellerId = @SellerId";
            //Itt vesszük használatba a MySql Connectort.
            using (var connection = new MySqlConnection(connectionString))
            {   //KKivétel kezelés.
                try
                {   //Adatbázis kapcsolat megnyitása.
                    connection.Open();
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SellerId", sellerId);
                        adsCount = Convert.ToInt32(command.ExecuteScalar());
                    }
                }
                catch (MySqlException ex) //Ha valami nem stimmel.
                {
                    MessageBox.Show("Hiba történt az adatbázishoz való kapcsolódás során: "
                        + ex.Message);
                }
            }

            return adsCount;
        }
    }
}