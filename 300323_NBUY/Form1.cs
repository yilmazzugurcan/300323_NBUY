using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _300323_NBUY
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        
        }
        int selectedFoodIndex = -1;
        int selectedTypeIndex = -1;

        private void cmbYiyecek_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cesit = cmbYiyecek.SelectedItem.ToString();
           
            if (cesit == "Yiyecek")
            {
                cmbCesit.Items.Clear();
                cmbCesit.Items.Add("Hamburger");
                cmbCesit.Items.Add("Cheesburger");
                cmbCesit.Items.Add("Karışık Pizza");
                cmbCesit.Items.Add("Sucuklu Pizza");
                cmbCesit.Items.Add("Ton Balıklı Pizza");
               

            }
            else if (cesit == "İçecek")
            {
                cmbCesit.Items.Clear();
                cmbCesit.Items.Add("Su");
                cmbCesit.Items.Add("Ayran");
                cmbCesit.Items.Add("Kola");
                cmbCesit.Items.Add("Gazoz");
                cmbCesit.Items.Add("Ice Tea");
               
            }
            
        }
        
        private void cmbCesit_SelectedIndexChanged(object sender, EventArgs e)
        {
           
    }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string yiyecek = cmbCesit.SelectedItem.ToString();
            string cesit = cmbCesit.SelectedItem.ToString();
            string fiyat = null;

            if (yiyecek == "Yiyecek")
            {
                if (cesit == "Hamburger")
                    fiyat = "20 TL";
                else if (cesit == "Cheesburger")
                    fiyat = "25 TL";
                else if (cesit == "Karışık Pizza")
                    fiyat = "30 TL";
                else if (cesit == "Sucuklu Pizza")
                    fiyat = "35 TL";
                else if (cesit == "Ton Balıklı Pizza")
                    fiyat = "40 TL";
            }
            else if (yiyecek == "İçecek")
            {
                if (cesit == "Su")
                    fiyat = "2 TL";
                else if (cesit == "Ayran")
                    fiyat = "3 TL";
                else if (cesit == "Kola")
                    fiyat = "5 TL";
                else if (cesit == "Gazoz")
                    fiyat = "5 TL";
                else if (cesit == "Ice Tea")
                    fiyat = "7 TL";
            }

            ListViewItem lvi = new ListViewItem();
            lvi.Text = yiyecek;
            lvi.SubItems.Add(cesit);
            lvi.SubItems.Add(fiyat);
            lstYiyeceks.Items.Add(lvi);

        }
    }
}
