using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;
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
        double geo_lat; // долгота
        double geo_lon; // ширина
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
                        
            gmaps(17, 52.719970, 41.457008);   
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gmaps(13,55.753564, 37.621085);
        }

        public void gmaps(int zooom,double geo_lat, double geo_lon)
        {

            gMapControl1.Bearing = 0;
            gMapControl1.CanDragMap = true; //Открываем доступ к манипулированию картой мышью через зажатие правой кнопкой(по умолчанию).
            gMapControl1.DragButton = MouseButtons.Left; //Меняем кнопку манипулирования с правой кнопки(по умолчанию) на левую кнопку мыши.
            gMapControl1.GrayScaleMode = true;
            gMapControl1.MaxZoom = 18; //Устанавливаем максимальное приближение.
            gMapControl1.MinZoom = 2; //Устанавливаем минимальное приближение.
            gMapControl1.Zoom = zooom;
            gMapControl1.MouseWheelZoomType = MouseWheelZoomType.MousePositionAndCenter; //Устанавливаем центр приближения/удаления курсор мыши.
            
            gMapControl1.PolygonsEnabled = true; //Открываем отображение полигонов на карте.
            gMapControl1.MarkersEnabled = true; //Открываем отображение маркеров на карте.
            gMapControl1.NegativeMode = false; //Отказываемся от негативного режима
            gMapControl1.ShowTileGridLines = false; //Скрываем внешнюю сетку карты с заголовками
            
            //Указываем что будем использовать карты Google.
            gMapControl1.MapProvider =  GMapProviders.GoogleMap;
            GMaps.Instance.Mode = AccessMode.ServerOnly;
           
            gMapControl1.Position = new PointLatLng(geo_lat, geo_lon); //Зададим стартовую позицию, я укажу "Красную площадь".
            GMapOverlay markersOverlay = new GMapOverlay(gMapControl1, "marker"); //Создадим коллекцию маркеров, указываем что имя коллекции "marker", а использоваться она будет в gMapControl1
            GMapMarkerGoogleGreen marker = new GMapMarkerGoogleGreen(new PointLatLng(geo_lat, geo_lon)); //Создаем новый маркер.
            marker.ToolTip = new GMapRoundedToolTip(marker); //Создаем всплывающее окно
            marker.ToolTipText = (nasp +", " +yl.Text + ", "+  dom.Text ); //Задаем текст для всплывающего окна

            markersOverlay.Markers.Add(marker); //Добавляем маркер коллекцию.
            gMapControl1.Overlays.Add(markersOverlay); //Добавляем коллекцию в очередь на вывод на карту.
        }
    }
}
