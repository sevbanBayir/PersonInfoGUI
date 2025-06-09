using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PersonInfoGUI
{
    public partial class Form1 : Form
    {
        private List<Person> persons;
        private ListBox lstPersons;

        public Form1()
        {
            persons = new List<Person>();
            this.Text = "Personel Bilgi Sistemi";
            this.Size = new System.Drawing.Size(600, 400);

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

            // Add ListBox
            lstPersons = new ListBox { Location = new System.Drawing.Point(340, 20), Width = 220, Height = 300 };
            Label lblListe = new Label { Text = "Kayıtlı Personel:", Location = new System.Drawing.Point(340, 5) };

            // Add controls to form
            this.Controls.AddRange(new Control[] { 
                lblSicilNo, txtSicilNo,
                lblAdSoyad, txtAdSoyad,
                lblCinsiyet, cmbCinsiyet,
                lblYas, numYas,
                btnKaydet, btnGoster,
                lstPersons, lblListe
            });

            // Event handlers
            btnKaydet.Click += (s, e) =>
            {
                Person person = new Person
                {
                    SicilNo = txtSicilNo.Text,
                    AdSoyad = txtAdSoyad.Text,
                    Cinsiyet = cmbCinsiyet.Text,
                    Yas = (int)numYas.Value
                };
                persons.Add(person);
                lstPersons.Items.Add($"{person.SicilNo} - {person.AdSoyad}");
                MessageBox.Show("Bilgiler kaydedildi!");
            };

            btnGoster.Click += (s, e) =>
            {
                if (lstPersons.SelectedIndex != -1)
                {
                    MessageBox.Show(persons[lstPersons.SelectedIndex].PersInfo());
                }
                else
                {
                    MessageBox.Show("Lütfen listeden bir personel seçin!");
                }
            };
        }
    }
}
