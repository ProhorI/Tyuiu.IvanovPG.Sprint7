using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;
using Tyuiu.IvanovPG.Sprint7.Task0.V14.Lib;

namespace Project.V14
{
    public partial class FormRoute : Form
    {
        string[]? itemInfo;
        string[]? stops;
        DataService dataService = new DataService();
        public FormRoute(string[] item)
        {
            InitializeComponent();
            itemInfo = item;
        }

        public void FormRoute_Load(object sender, EventArgs e)
        {
            if (itemInfo != null)
            {
                textBoxRouteId_IPG.Text = "Номер маршрута: " + itemInfo[0];

                stops = itemInfo[1].Split('|');

                textBoxRouteStart_IPG.Text = "Начальная остановка: " + stops[0];
                textBoxRouteEnd_IPG.Text = "Конечная остановка: " + stops[^1];
                textBoxRouteType_IPG.Text = "Вид транспорта: " + itemInfo[2];

                for (int i = 0; i < stops.Length; i++)
                {
                    flowLayoutPanel_IPG.Controls.Add(CreateButton(stops[i]));
                }

            }
        }
        private Button CreateButton(string name)
        {
            Button button = new Button
            {
                Text = name,
                Width = 95,
                Height = 25,
                AutoSize = true
            };
            button.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button.Click += buttonRouteStop_IPG_Click;
            return button;
        }
        public void buttonRouteStop_IPG_Click(object sender, EventArgs e)
        {
            if (stops != null && stops.Length != 0)
            {
                string nameButton = (sender as Button).Text;
                string[] times = itemInfo[3].Split("|");
                string time = string.IsNullOrWhiteSpace(times[Array.IndexOf(stops, nameButton)]) ? "??? " : times[Array.IndexOf(stops, (sender as Button).Text)];
                textBoxRouteTime_IPG.Text = "Примерное время ожидания автобуса - " + time + (time.Contains(':') ? "" : " минут");

                if (DataService.imagesFolder != string.Empty)
                {
                    try
                    {
                        if (dataService.GetPathImageFile(nameButton, DataService.imagesFolder, out string picture))
                        {
                            pictureBoxRoute_IPG.Image = Image.FromFile(picture);
                        }
                        else
                        {
                            pictureBoxRoute_IPG.Image = pictureBoxRoute_IPG.ErrorImage;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Неверное фото остановки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(Path.Combine(DataService.imagesFolder, nameButton));
                    pictureBoxRoute_IPG.Image = pictureBoxRoute_IPG.ErrorImage;
                }
            }
        }
    }
}