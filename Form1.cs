using System;
using System.Windows.Forms;

namespace PersonInfoGUI
{
    public partial class Form1 : Form
    {
        private Person person;

        public Form1()
        {
            InitializeComponent();
            person = new Person();
        }

        private void InitializeComponent()
        {
            this.Text = "Personel Bilgi Sistemi";
            this.Size = new System.Drawing.Size(400, 300);

            // Create controls
            Label lblSicilNo = new Label { Text = "Sicil No:", Location = new System.Drawing.Point(20, 20) };
            TextBox txtSicilNo = new TextBox { Location = new System.Drawing.Point(120, 20), Width = 200 };

            Label lblAdSoyad = new Label { Text = "Ad Soyad:", Location = new System.Drawing.Point(20, 50) };
            TextBox txtAdSoyad = new TextBox { Location = new System.Drawing.Point(120, 50), Width = 200 };

            Label lblCinsiyet = new Label { Text = "Cinsiyet:", Location = new System.Drawing.Point(20, 80) };
            ComboBox cmbCinsiyet = new ComboBox { Location = new System.Drawing.Point(120, 80), Width = 200 };
            cmbCinsiyet.Items.AddRange(new string[] { "Erkek", "Kadın" });

            Label lblYas = new Label { Text = "Yaş:", Location = new System.Drawing.Point(20, 110) };
            NumericUpDown numYas = new NumericUpDown { Location = new System.Drawing.Point(120, 110), Width = 200, Minimum = 18, Maximum = 100 };

            Button btnKaydet = new Button { Text = "Kaydet", Location = new System.Drawing.Point(120, 150), Width = 200 };
            Button btnGoster = new Button { Text = "Bilgileri Göster", Location = new System.Drawing.Point(120, 190), Width = 200 };

            // Add controls to form
            this.Controls.AddRange(new Control[] { 
                lblSicilNo, txtSicilNo,
                lblAdSoyad, txtAdSoyad,
                lblCinsiyet, cmbCinsiyet,
                lblYas, numYas,
                btnKaydet, btnGoster
            });

            // Event handlers
            btnKaydet.Click += (s, e) =>
            {
                person.SicilNo = txtSicilNo.Text;
                person.AdSoyad = txtAdSoyad.Text;
                person.Cinsiyet = cmbCinsiyet.Text;
                person.Yas = (int)numYas.Value;
                MessageBox.Show("Bilgiler kaydedildi!");
            };

            btnGoster.Click += (s, e) =>
            {
                MessageBox.Show(person.PersInfo());
            };
        }
    }
}
