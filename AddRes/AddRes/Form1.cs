using NUnit.Framework;
using suggestionscsharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddRes
{
    public partial class Form1 : Form
    {
        string addres = null;
        string nasp;
        string areaa;
        string type;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void comboBox1_TextUpdate(object sender, EventArgs e)
        {
             
            var token = "888f110f8d1cc69dbdb07839d780e7f29f36fa13";
            var url = "https://suggestions.dadata.ru/suggestions/api/4_1/rs";
            var api = new SuggestClient(token, url);
            var query = comboBox1.Text;
            var response = api.QueryAddress(query);
            var address_data = response.suggestions[0].data;
            if (address_data.settlement != null)
            {
                nasp = (address_data.settlement);
            }
            else if (address_data.city != null)
            {
                nasp = (address_data.city);
            }


            obl.Text = (address_data.region);

            if (address_data.area != null)
            {
                areaa = (address_data.area);
            }
            else if (address_data.city != null)
            {
                areaa = (address_data.city_district);
            }

            rn.Text = areaa;
            nas.Text = nasp;
            yl.Text = (address_data.street);
            dom.Text = (address_data.house);
            kv.Text = (address_data.flat);

            if (address_data.settlement_type_full != null)
            {
                type = (address_data.settlement_type_full);
            }
            else if (address_data.city_type_full != null)
            {
                type = (address_data.city_type_full);
            }


            typ.Text = type;
            comboBox1.Items.Add(string.Join("\n", response.suggestions[0]));

          
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            addres = comboBox1.Text;
            //криво но работает (получается что дубль запрос)
            var token = "888f110f8d1cc69dbdb07839d780e7f29f36fa13";
            var url = "https://suggestions.dadata.ru/suggestions/api/4_1/rs";
            var api = new SuggestClient(token, url);
            var query = comboBox1.Text;
            var response = api.QueryAddress(query);
            var address_data = response.suggestions[0].data;
            if (address_data.settlement != null)
            {
                nasp = (address_data.settlement);
            }
            else if (address_data.city != null)
            {
                nasp = (address_data.city);
            }


            obl.Text = (address_data.region);

           if (address_data.area != null)
            {
                areaa = (address_data.area);
            }
            else if (address_data.city != null)
            {
                areaa = (address_data.city_district);
            }

            rn.Text = areaa;
            nas.Text = nasp;
            yl.Text = (address_data.street);
            dom.Text = (address_data.house);
            kv.Text = (address_data.flat);

            if (address_data.settlement_type_full != null)
            {
                type = (address_data.settlement_type_full);
            }
            else if (address_data.city_type_full != null)
            {
                type = (address_data.city_type_full);
            }


            typ.Text = type;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            comboBox1.Items.Clear();
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            WebBrowser w = new WebBrowser();
            w.Navigate("https://yandex.ru/");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
