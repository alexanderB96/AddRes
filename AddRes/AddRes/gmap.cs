using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms.ToolTips;
using GMap.NET.WindowsForms.Markers;

namespace AddRes
{
    
    class gmap
    {
        Form1 form = new Form1();
        

       /* public void gmaps()
        {
            
            gMapControl1.Bearing = 0;
            gMapControl1.CanDragMap = true; //Открываем доступ к манипулированию картой мышью через зажатие правой кнопкой(по умолчанию).
            gMapControl1.DragButton = MouseButtons.Left; //Меняем кнопку манипулирования с правой кнопки(по умолчанию) на левую кнопку мыши.
            gMapControl1.GrayScaleMode = true;
            gMapControl1.MaxZoom = 18; //Устанавливаем максимальное приближение.
            gMapControl1.MinZoom = 2; //Устанавливаем минимальное приближение.
            gMapControl1.MouseWheelZoomType = MouseWheelZoomType.MousePositionAndCenter; //Устанавливаем центр приближения/удаления курсор мыши.

            gMapControl1.PolygonsEnabled = true; //Открываем отображение полигонов на карте.
            gMapControl1.MarkersEnabled = true; //Открываем отображение маркеров на карте.
            gMapControl1.NegativeMode = false; //Отказываемся от негативного режима
            gMapControl1.ShowTileGridLines = false; //Скрываем внешнюю сетку карты с заголовками
            gMapControl1.Dock = DockStyle.Fill; //Закрепляем контрол внутри формы, чтобы размеры контрола изменялись вместе с размером формы.
            gMapControl1.MapProvider = GMapProviders.OpenStreetMap; //Указываем что будут использоваться карты OpenStreetMaps. Здесь куча карт на выбор.
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            //Если у вас используется прокси то вам нужны еще эти строки, описывать не буду, скажу только что параметры входа берутся из IE:
            //GMapProvider.WebProxy = System.Net.WebRequest.GetSystemWebProxy();
            //GMapProvider.WebProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;

            gMapControl1.Position = new GMap.NET.PointLatLng(55.75393, 37.620795); //Зададим стартовую позицию, я укажу "Красную площадь".
            GMapOverlay markersOverlay = new GMapOverlay(gMapControl1, "marker"); //Создадим коллекцию маркеров, указываем что имя коллекции "marker", а использоваться она будет в gMapControl1
            GMapMarkerGoogleGreen marker = new GMapMarkerGoogleGreen(new PointLatLng(55.604387, 37.369907)); //Создаем новый маркер.
            marker.ToolTip = new GMapRoundedToolTip(marker); //Создаем всплывающее окно
            marker.ToolTipText = "Дом"; //Задаем текст для всплывающего окна

            markersOverlay.Markers.Add(marker); //Добавляем маркер коллекцию.
            gMapControl1.Overlays.Add(markersOverlay); //Добавляем коллекцию в очередь на вывод на карту.
        }*/
        
    }
}
