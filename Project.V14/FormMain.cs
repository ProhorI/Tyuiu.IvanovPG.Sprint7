using Tyuiu.IvanovPG.Sprint7.Task0.V14.Lib;
using System.IO;
using System.Windows.Forms;

namespace Project.V14
{
    public partial class FormMain : Form
    {
        public string? openFilePath;

        public List<string[]>? items;

        int rows;
        const int COLUMNS = 6;

        int rowFocusIndex;

        DataService dataService = new DataService();
        public FormMain()
        {
            InitializeComponent();

            saveFileDialog_IPG.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(() =>
            {
                buttonOpenFile_IPG.Focus();
            }));

            dataGridViewRoutes_IPG.RowCount = 14;
            dataGridViewFeatures_IPG.RowCount = 14;
        }

        private void ToolStripMenuAbout_IPG_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void ToolStripMenuExit_IPG_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void buttonOpenFile_IPG_Click(object sender, EventArgs e)
        {
            openFileDialog_IPG.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            openFileDialog_IPG.ShowDialog();
            if (File.Exists(openFileDialog_IPG.FileName))
            {
                openFilePath = openFileDialog_IPG.FileName;
                items = dataService.ParseRouteItems(openFilePath);

                for (int i = 0; i < items.Count; i++)
                {
                    if (items[i].Length < 4 || !int.TryParse(items[i][0], out _))
                    {
                        MessageBox.Show("Неверные данные в файле", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                SetItemsToGrid(items);

                for (int i = 0; i < rows; i++)
                {
                    if (items[i].Count() == 5)
                    {
                        try
                        {
                            if (Convert.ToBoolean(items[i][4])) AddRowToFeature(i);
                        }
                        catch
                        {
                            MessageBox.Show("Неверные данные в файле (опция \"Избранное\n не является bool значением)", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                buttonSaveFile_IPG.Enabled = true;
                buttonUpdateFile_IPG.Enabled = true;

                ToolStripMenuOpenNewFileTool_IPG.Enabled = true;
                ToolStripMenuOpenFile_IPG.Enabled = true;
                ToolStripMenuRefresh_IPG.Enabled = true;
                ToolStripMenuSaveFile_IPG.Enabled = true;
            }

        }

        private void SetItemsToGrid(List<string[]> items)
        {
            rows = items.Count;

            dataGridViewRoutes_IPG.RowCount = rows;
            dataGridViewRoutes_IPG.ColumnCount = COLUMNS - 2;

            dataGridViewFeatures_IPG.RowCount = 0;

            for (int i = 0; i < rows; i++)
            {
                string[] routes = items[i][1].Split('|');
                dataGridViewRoutes_IPG.Rows[i].Cells[0].Value = items[i][0];
                dataGridViewRoutes_IPG.Rows[i].Cells[1].Value = routes[0];
                dataGridViewRoutes_IPG.Rows[i].Cells[2].Value = routes[^1];
                dataGridViewRoutes_IPG.Rows[i].Cells[3].Value = items[i][2];
            }
        }

        private void buttonSaveFile_IPG_Click(object sender, EventArgs e)
        {
            saveFileDialog_IPG.FileName = "file.csv";
            saveFileDialog_IPG.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog_IPG.ShowDialog();

            string path = saveFileDialog_IPG.FileName;

            FileInfo fileInfo = new FileInfo(path);
            if (fileInfo.Exists)
            {
                File.Delete(path);
            }

            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < COLUMNS; j++)
                {
                    if (j != COLUMNS - 1)
                    {
                        str += dataGridViewRoutes_IPG.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewRoutes_IPG.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonUpdateFile_IPG_Click(object sender, EventArgs e)
        {
            items = dataService.ParseRouteItems(openFilePath);
            SetItemsToGrid(items);
        }

        private void buttonSetFeature_IPG_Click(object sender, EventArgs e)
        {
            if (dataGridViewFeatures_IPG.RowCount != 0)
            {
                for (int i = 0; i < dataGridViewFeatures_IPG.RowCount; i++)
                {
                    if ((string)dataGridViewFeatures_IPG.Rows[i].Cells[0].Value == items[rowFocusIndex][0]) return;
                }
            }

            AddRowToFeature(rowFocusIndex);

            buttonSetFeature_IPG.Enabled = false;
        }
        private void AddRowToFeature(int index)
        {
            int indexRow = dataGridViewFeatures_IPG.RowCount;
            dataGridViewFeatures_IPG.RowCount += 1;
            dataGridViewFeatures_IPG.Rows[indexRow].Cells[0].Value = dataGridViewRoutes_IPG.Rows[index].Cells[0].Value;
            dataGridViewFeatures_IPG.Rows[indexRow].Cells[1].Value = dataGridViewRoutes_IPG.Rows[index].Cells[1].Value;
            dataGridViewFeatures_IPG.Rows[indexRow].Cells[2].Value = dataGridViewRoutes_IPG.Rows[index].Cells[2].Value;
            dataGridViewFeatures_IPG.Rows[indexRow].Cells[3].Value = dataGridViewRoutes_IPG.Rows[index].Cells[3].Value;
        }

        private void dataGridViewRoutes_IPG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                rowFocusIndex = e.RowIndex;

                buttonSetFeature_IPG.Enabled = true;
                buttonOpenRoute_IPG.Enabled = true;

                labelRowFocusIndex_IPG.Text = rowFocusIndex.ToString();
            }
        }

        private void tabControlRoutes_IPG_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControlRoutes_IPG.SelectedIndex == 0)
            {
                dataGridViewRoutes_IPG.Sort(dataGridViewRoutes_IPG.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
            }
            else dataGridViewFeatures_IPG.Sort(dataGridViewFeatures_IPG.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
        }
        private void buttonSearch_IPG_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxSearch_IPG.Text, out int number))
            {
                DataGridView dataGrid = tabControlRoutes_IPG.SelectedIndex == 0 ? dataGridViewRoutes_IPG : dataGridViewFeatures_IPG;
                foreach (DataGridViewRow row in dataGrid.Rows)
                {
                    if (Convert.ToInt32(row.Cells[0].Value) != number)
                    {
                        dataGrid.Rows.Remove(row);
                    }
                }
            }
            else
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void ToolStripMenuOpenFile_IPG_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = openFilePath;
            txt.Start();
        }

        private void buttonOpenRoute_IPG_Click(object sender, EventArgs e)
        {
            FormRoute formRoute = new FormRoute(items[rowFocusIndex]);
            formRoute.Text = "Маршрут " + GetCurrentDataGridView().CurrentRow.Cells[0].Value;
            formRoute.ShowDialog();
        }

        private DataGridView GetCurrentDataGridView()
        {
            if (tabControlRoutes_IPG.SelectedIndex == 0) return dataGridViewRoutes_IPG;
            else return dataGridViewFeatures_IPG;
        }
        private void ToolStripMenuImages_IPG_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (Directory.Exists(dialog.SelectedPath))
                {
                    DataService.imagesFolder = dialog.SelectedPath;
                }
            }
        }
        private void buttonHelpImages_IPG_Click(object sender, EventArgs e)
        {
            FormGuideImage formGuideImage = new FormGuideImage();
            formGuideImage.ShowDialog();
        }

        private void buttonHelp_IPG_Click(object sender, EventArgs e)
        {
            FormGuide formGuide = new FormGuide();
            formGuide.ShowDialog();
        }

        #region MouseEnterTips
        private void buttonOpenFile_IPG_MouseEnter(object sender, EventArgs e)
        {
            toolTip_IPG.ToolTipTitle = "Открытие";
        }

        private void buttonSaveFile_IPG_MouseEnter(object sender, EventArgs e)
        {
            toolTip_IPG.ToolTipTitle = "Экспорт";
        }

        private void buttonUpdateFile_IPG_MouseEnter(object sender, EventArgs e)
        {
            toolTip_IPG.ToolTipTitle = "Обновить";
        }

        private void buttonHelp_IPG_MouseEnter(object sender, EventArgs e)
        {
            toolTip_IPG.ToolTipTitle = "Руководство";
        }

        private void textBoxSearch_IPG_MouseEnter(object sender, EventArgs e)
        {
            toolTip_IPG.ToolTipTitle = "Поиск";
        }

        private void buttonOpenRoute_IPG_MouseEnter(object sender, EventArgs e)
        {
            toolTip_IPG.ToolTipTitle = "Открыть";
        }

        private void buttonSetFeature_IPG_MouseEnter(object sender, EventArgs e)
        {
            toolTip_IPG.ToolTipTitle = "Избранное";
        }
        private void buttonHelpImages_IPG_MouseEnter(object sender, EventArgs e)
        {
            toolTip_IPG.ToolTipTitle = "Руководство";
        }

#endregion
    }
}

