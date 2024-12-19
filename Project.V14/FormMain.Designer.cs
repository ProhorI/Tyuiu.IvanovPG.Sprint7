namespace Project.V14
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            saveFileDialog_IPG = new SaveFileDialog();
            openFileDialog_IPG = new OpenFileDialog();
            toolTip_IPG = new ToolTip(components);
            flowLayoutPanel1 = new FlowLayoutPanel();
            groupBoxSearch_IPG = new GroupBox();
            textBoxSearch_IPG = new TextBox();
            buttonSearch_IPG = new Button();
            groupBoxFile_IPG = new GroupBox();
            buttonSaveFile_IPG = new Button();
            buttonOpenFile_IPG = new Button();
            buttonUpdateFile_IPG = new Button();
            groupBoxEdit_IPG = new GroupBox();
            buttonOpenRoute_IPG = new Button();
            buttonSetFeature_IPG = new Button();
            groupBox1 = new GroupBox();
            buttonHelp_IPG = new Button();
            buttonHelpImages_IPG = new Button();
            labelRowFocusIndex_IPG = new Label();
            miniToolStrip = new ToolStrip();
            menuStrip_IPG = new MenuStrip();
            ToolStripMenuItemProgramm_IPG = new ToolStripMenuItem();
            ToolStripMenuAbout_IPG = new ToolStripMenuItem();
            ToolStripMenuExit_IPG = new ToolStripMenuItem();
            ToolStripMenuItemFile_IPG = new ToolStripMenuItem();
            ToolStripMenuOpenNewFileTool_IPG = new ToolStripMenuItem();
            ToolStripMenuOpenNewFile_IPG = new ToolStripMenuItem();
            ToolStripMenuImages_IPG = new ToolStripMenuItem();
            ToolStripMenuSaveFile_IPG = new ToolStripMenuItem();
            ToolStripMenuRefresh_IPG = new ToolStripMenuItem();
            ToolStripMenuOpenFile_IPG = new ToolStripMenuItem();
            открытьНовыйФайлToolStripMenuItem = new ToolStripMenuItem();
            tabControlRoutes_IPG = new TabControl();
            tabPage1 = new TabPage();
            dataGridViewRoutes_IPG = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            tabPage2 = new TabPage();
            dataGridViewFeatures_IPG = new DataGridView();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
            groupBoxSearch_IPG.SuspendLayout();
            groupBoxFile_IPG.SuspendLayout();
            groupBoxEdit_IPG.SuspendLayout();
            groupBox1.SuspendLayout();
            menuStrip_IPG.SuspendLayout();
            tabControlRoutes_IPG.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRoutes_IPG).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFeatures_IPG).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog_IPG
            // 
            openFileDialog_IPG.FileName = "openFileDialog1";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(groupBoxSearch_IPG);
            flowLayoutPanel1.Controls.Add(groupBoxFile_IPG);
            flowLayoutPanel1.Controls.Add(groupBoxEdit_IPG);
            flowLayoutPanel1.Controls.Add(groupBox1);
            flowLayoutPanel1.Location = new Point(3, 53);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(595, 1010);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // groupBoxSearch_IPG
            // 
            groupBoxSearch_IPG.Controls.Add(textBoxSearch_IPG);
            groupBoxSearch_IPG.Controls.Add(buttonSearch_IPG);
            groupBoxSearch_IPG.Location = new Point(3, 3);
            groupBoxSearch_IPG.Name = "groupBoxSearch_IPG";
            groupBoxSearch_IPG.Size = new Size(555, 146);
            groupBoxSearch_IPG.TabIndex = 0;
            groupBoxSearch_IPG.TabStop = false;
            groupBoxSearch_IPG.Text = "Поиск";
            // 
            // textBoxSearch_IPG
            // 
            textBoxSearch_IPG.Location = new Point(20, 65);
            textBoxSearch_IPG.Name = "textBoxSearch_IPG";
            textBoxSearch_IPG.Size = new Size(326, 39);
            textBoxSearch_IPG.TabIndex = 1;
            // 
            // buttonSearch_IPG
            // 
            buttonSearch_IPG.BackgroundImage = (Image)resources.GetObject("buttonSearch_IPG.BackgroundImage");
            buttonSearch_IPG.Location = new Point(444, 38);
            buttonSearch_IPG.Name = "buttonSearch_IPG";
            buttonSearch_IPG.Size = new Size(77, 84);
            buttonSearch_IPG.TabIndex = 0;
            buttonSearch_IPG.UseVisualStyleBackColor = true;
            buttonSearch_IPG.Click += buttonSearch_IPG_Click;
            // 
            // groupBoxFile_IPG
            // 
            groupBoxFile_IPG.Controls.Add(buttonSaveFile_IPG);
            groupBoxFile_IPG.Controls.Add(buttonOpenFile_IPG);
            groupBoxFile_IPG.Controls.Add(buttonUpdateFile_IPG);
            groupBoxFile_IPG.Location = new Point(3, 155);
            groupBoxFile_IPG.Name = "groupBoxFile_IPG";
            groupBoxFile_IPG.Size = new Size(558, 200);
            groupBoxFile_IPG.TabIndex = 1;
            groupBoxFile_IPG.TabStop = false;
            groupBoxFile_IPG.Text = "Файл";
            // 
            // buttonSaveFile_IPG
            // 
            buttonSaveFile_IPG.BackgroundImage = (Image)resources.GetObject("buttonSaveFile_IPG.BackgroundImage");
            buttonSaveFile_IPG.Location = new Point(170, 49);
            buttonSaveFile_IPG.Name = "buttonSaveFile_IPG";
            buttonSaveFile_IPG.Size = new Size(133, 128);
            buttonSaveFile_IPG.TabIndex = 0;
            buttonSaveFile_IPG.UseVisualStyleBackColor = true;
            buttonSaveFile_IPG.Click += buttonSaveFile_IPG_Click;
            buttonSaveFile_IPG.MouseEnter += buttonSaveFile_IPG_MouseEnter;
            // 
            // buttonOpenFile_IPG
            // 
            buttonOpenFile_IPG.BackgroundImage = (Image)resources.GetObject("buttonOpenFile_IPG.BackgroundImage");
            buttonOpenFile_IPG.Location = new Point(6, 49);
            buttonOpenFile_IPG.Name = "buttonOpenFile_IPG";
            buttonOpenFile_IPG.Size = new Size(130, 128);
            buttonOpenFile_IPG.TabIndex = 0;
            buttonOpenFile_IPG.UseVisualStyleBackColor = true;
            buttonOpenFile_IPG.Click += buttonOpenFile_IPG_Click;
            buttonOpenFile_IPG.MouseEnter += buttonOpenFile_IPG_MouseEnter;
            // 
            // buttonUpdateFile_IPG
            // 
            buttonUpdateFile_IPG.BackgroundImage = (Image)resources.GetObject("buttonUpdateFile_IPG.BackgroundImage");
            buttonUpdateFile_IPG.Location = new Point(358, 49);
            buttonUpdateFile_IPG.Name = "buttonUpdateFile_IPG";
            buttonUpdateFile_IPG.Size = new Size(129, 128);
            buttonUpdateFile_IPG.TabIndex = 0;
            buttonUpdateFile_IPG.UseVisualStyleBackColor = true;
            buttonUpdateFile_IPG.Click += buttonUpdateFile_IPG_Click;
            buttonUpdateFile_IPG.MouseEnter += buttonUpdateFile_IPG_MouseEnter;
            // 
            // groupBoxEdit_IPG
            // 
            groupBoxEdit_IPG.Controls.Add(buttonOpenRoute_IPG);
            groupBoxEdit_IPG.Controls.Add(buttonSetFeature_IPG);
            groupBoxEdit_IPG.Location = new Point(3, 361);
            groupBoxEdit_IPG.Name = "groupBoxEdit_IPG";
            groupBoxEdit_IPG.Size = new Size(558, 200);
            groupBoxEdit_IPG.TabIndex = 2;
            groupBoxEdit_IPG.TabStop = false;
            groupBoxEdit_IPG.Text = "Работа с маршрутами";
            // 
            // buttonOpenRoute_IPG
            // 
            buttonOpenRoute_IPG.BackgroundImage = (Image)resources.GetObject("buttonOpenRoute_IPG.BackgroundImage");
            buttonOpenRoute_IPG.Location = new Point(36, 42);
            buttonOpenRoute_IPG.Name = "buttonOpenRoute_IPG";
            buttonOpenRoute_IPG.Size = new Size(136, 129);
            buttonOpenRoute_IPG.TabIndex = 0;
            buttonOpenRoute_IPG.UseVisualStyleBackColor = true;
            buttonOpenRoute_IPG.Click += buttonOpenRoute_IPG_Click;
            buttonOpenRoute_IPG.MouseEnter += buttonOpenRoute_IPG_MouseEnter;
            // 
            // buttonSetFeature_IPG
            // 
            buttonSetFeature_IPG.BackgroundImage = (Image)resources.GetObject("buttonSetFeature_IPG.BackgroundImage");
            buttonSetFeature_IPG.Location = new Point(251, 42);
            buttonSetFeature_IPG.Name = "buttonSetFeature_IPG";
            buttonSetFeature_IPG.Size = new Size(142, 134);
            buttonSetFeature_IPG.TabIndex = 0;
            buttonSetFeature_IPG.UseVisualStyleBackColor = true;
            buttonSetFeature_IPG.Click += buttonSetFeature_IPG_Click;
            buttonSetFeature_IPG.MouseEnter += buttonSetFeature_IPG_MouseEnter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonHelp_IPG);
            groupBox1.Controls.Add(buttonHelpImages_IPG);
            groupBox1.Controls.Add(labelRowFocusIndex_IPG);
            groupBox1.Location = new Point(3, 567);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(558, 200);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Руководство";
            // 
            // buttonHelp_IPG
            // 
            buttonHelp_IPG.BackgroundImage = (Image)resources.GetObject("buttonHelp_IPG.BackgroundImage");
            buttonHelp_IPG.Location = new Point(36, 48);
            buttonHelp_IPG.Name = "buttonHelp_IPG";
            buttonHelp_IPG.Size = new Size(136, 126);
            buttonHelp_IPG.TabIndex = 0;
            buttonHelp_IPG.UseVisualStyleBackColor = true;
            buttonHelp_IPG.Click += buttonHelp_IPG_Click;
            buttonHelp_IPG.MouseEnter += buttonHelp_IPG_MouseEnter;
            // 
            // buttonHelpImages_IPG
            // 
            buttonHelpImages_IPG.BackgroundImage = (Image)resources.GetObject("buttonHelpImages_IPG.BackgroundImage");
            buttonHelpImages_IPG.Location = new Point(296, 48);
            buttonHelpImages_IPG.Name = "buttonHelpImages_IPG";
            buttonHelpImages_IPG.Size = new Size(131, 126);
            buttonHelpImages_IPG.TabIndex = 0;
            buttonHelpImages_IPG.UseVisualStyleBackColor = true;
            buttonHelpImages_IPG.Click += buttonHelpImages_IPG_Click;
            buttonHelpImages_IPG.MouseEnter += buttonHelpImages_IPG_MouseEnter;
            // 
            // labelRowFocusIndex_IPG
            // 
            labelRowFocusIndex_IPG.AutoSize = true;
            labelRowFocusIndex_IPG.Location = new Point(457, 95);
            labelRowFocusIndex_IPG.Name = "labelRowFocusIndex_IPG";
            labelRowFocusIndex_IPG.Size = new Size(0, 32);
            labelRowFocusIndex_IPG.TabIndex = 4;
            // 
            // miniToolStrip
            // 
            miniToolStrip.AccessibleName = "New item selection";
            miniToolStrip.AccessibleRole = AccessibleRole.ButtonDropDown;
            miniToolStrip.AutoSize = false;
            miniToolStrip.CanOverflow = false;
            miniToolStrip.Dock = DockStyle.None;
            miniToolStrip.GripStyle = ToolStripGripStyle.Hidden;
            miniToolStrip.ImageScalingSize = new Size(32, 32);
            miniToolStrip.Location = new Point(18, 0);
            miniToolStrip.Name = "miniToolStrip";
            miniToolStrip.Size = new Size(120, 25);
            miniToolStrip.TabIndex = 4;
            // 
            // menuStrip_IPG
            // 
            menuStrip_IPG.ImageScalingSize = new Size(32, 32);
            menuStrip_IPG.Items.AddRange(new ToolStripItem[] { ToolStripMenuItemProgramm_IPG, ToolStripMenuItemFile_IPG });
            menuStrip_IPG.Location = new Point(0, 0);
            menuStrip_IPG.Name = "menuStrip_IPG";
            menuStrip_IPG.Size = new Size(603, 42);
            menuStrip_IPG.TabIndex = 3;
            menuStrip_IPG.Text = "menuStrip1";
            // 
            // ToolStripMenuItemProgramm_IPG
            // 
            ToolStripMenuItemProgramm_IPG.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuAbout_IPG, ToolStripMenuExit_IPG });
            ToolStripMenuItemProgramm_IPG.Name = "ToolStripMenuItemProgramm_IPG";
            ToolStripMenuItemProgramm_IPG.Size = new Size(160, 38);
            ToolStripMenuItemProgramm_IPG.Text = "Программа";
            // 
            // ToolStripMenuAbout_IPG
            // 
            ToolStripMenuAbout_IPG.Name = "ToolStripMenuAbout_IPG";
            ToolStripMenuAbout_IPG.Size = new Size(359, 44);
            ToolStripMenuAbout_IPG.Text = "О Программе";
            ToolStripMenuAbout_IPG.Click += ToolStripMenuAbout_IPG_Click;
            // 
            // ToolStripMenuExit_IPG
            // 
            ToolStripMenuExit_IPG.Name = "ToolStripMenuExit_IPG";
            ToolStripMenuExit_IPG.Size = new Size(359, 44);
            ToolStripMenuExit_IPG.Text = "Выход";
            ToolStripMenuExit_IPG.Click += ToolStripMenuExit_IPG_Click;
            // 
            // ToolStripMenuItemFile_IPG
            // 
            ToolStripMenuItemFile_IPG.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuOpenNewFileTool_IPG, ToolStripMenuSaveFile_IPG, ToolStripMenuRefresh_IPG, ToolStripMenuOpenFile_IPG, открытьНовыйФайлToolStripMenuItem });
            ToolStripMenuItemFile_IPG.Name = "ToolStripMenuItemFile_IPG";
            ToolStripMenuItemFile_IPG.Size = new Size(90, 38);
            ToolStripMenuItemFile_IPG.Text = "Файл";
            // 
            // ToolStripMenuOpenNewFileTool_IPG
            // 
            ToolStripMenuOpenNewFileTool_IPG.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuOpenNewFile_IPG, ToolStripMenuImages_IPG });
            ToolStripMenuOpenNewFileTool_IPG.Name = "ToolStripMenuOpenNewFileTool_IPG";
            ToolStripMenuOpenNewFileTool_IPG.Size = new Size(393, 44);
            ToolStripMenuOpenNewFileTool_IPG.Text = "Открыть новый файл";
            ToolStripMenuOpenNewFileTool_IPG.Click += ToolStripMenuOpenFile_IPG_Click;
            // 
            // ToolStripMenuOpenNewFile_IPG
            // 
            ToolStripMenuOpenNewFile_IPG.Name = "ToolStripMenuOpenNewFile_IPG";
            ToolStripMenuOpenNewFile_IPG.Size = new Size(504, 44);
            ToolStripMenuOpenNewFile_IPG.Text = "Открыть файл маршрутов";
            ToolStripMenuOpenNewFile_IPG.Click += ToolStripMenuOpenFile_IPG_Click;
            // 
            // ToolStripMenuImages_IPG
            // 
            ToolStripMenuImages_IPG.Name = "ToolStripMenuImages_IPG";
            ToolStripMenuImages_IPG.Size = new Size(504, 44);
            ToolStripMenuImages_IPG.Text = "Выбрать папку с изображением";
            ToolStripMenuImages_IPG.Click += ToolStripMenuImages_IPG_Click;
            // 
            // ToolStripMenuSaveFile_IPG
            // 
            ToolStripMenuSaveFile_IPG.Name = "ToolStripMenuSaveFile_IPG";
            ToolStripMenuSaveFile_IPG.Size = new Size(393, 44);
            ToolStripMenuSaveFile_IPG.Text = "Сохранить как";
            ToolStripMenuSaveFile_IPG.Click += buttonSaveFile_IPG_Click;
            // 
            // ToolStripMenuRefresh_IPG
            // 
            ToolStripMenuRefresh_IPG.Name = "ToolStripMenuRefresh_IPG";
            ToolStripMenuRefresh_IPG.Size = new Size(393, 44);
            ToolStripMenuRefresh_IPG.Text = "Обновить";
            ToolStripMenuRefresh_IPG.Click += buttonUpdateFile_IPG_Click;
            // 
            // ToolStripMenuOpenFile_IPG
            // 
            ToolStripMenuOpenFile_IPG.Name = "ToolStripMenuOpenFile_IPG";
            ToolStripMenuOpenFile_IPG.Size = new Size(393, 44);
            ToolStripMenuOpenFile_IPG.Text = "Открыть данный файл";
            ToolStripMenuOpenFile_IPG.Click += ToolStripMenuOpenFile_IPG_Click;
            // 
            // открытьНовыйФайлToolStripMenuItem
            // 
            открытьНовыйФайлToolStripMenuItem.Name = "открытьНовыйФайлToolStripMenuItem";
            открытьНовыйФайлToolStripMenuItem.Size = new Size(393, 44);
            открытьНовыйФайлToolStripMenuItem.Text = "Открыть новый файл";
            // 
            // tabControlRoutes_IPG
            // 
            tabControlRoutes_IPG.Controls.Add(tabPage1);
            tabControlRoutes_IPG.Controls.Add(tabPage2);
            tabControlRoutes_IPG.Location = new Point(606, 53);
            tabControlRoutes_IPG.Name = "tabControlRoutes_IPG";
            tabControlRoutes_IPG.SelectedIndex = 0;
            tabControlRoutes_IPG.Size = new Size(1282, 1010);
            tabControlRoutes_IPG.TabIndex = 2;
            tabControlRoutes_IPG.Selected += tabControlRoutes_IPG_Selected;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridViewRoutes_IPG);
            tabPage1.Location = new Point(8, 46);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1266, 956);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Список маршрутов";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewRoutes_IPG
            // 
            dataGridViewRoutes_IPG.AllowUserToAddRows = false;
            dataGridViewRoutes_IPG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRoutes_IPG.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridViewRoutes_IPG.Location = new Point(6, 22);
            dataGridViewRoutes_IPG.Name = "dataGridViewRoutes_IPG";
            dataGridViewRoutes_IPG.RowHeadersVisible = false;
            dataGridViewRoutes_IPG.RowHeadersWidth = 82;
            dataGridViewRoutes_IPG.Size = new Size(1281, 928);
            dataGridViewRoutes_IPG.TabIndex = 0;
            dataGridViewRoutes_IPG.CellContentClick += dataGridViewRoutes_IPG_CellClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "№";
            Column1.MinimumWidth = 10;
            Column1.Name = "Column1";
            Column1.Width = 200;
            // 
            // Column2
            // 
            Column2.HeaderText = "Начальная остановка";
            Column2.MinimumWidth = 10;
            Column2.Name = "Column2";
            Column2.Width = 200;
            // 
            // Column3
            // 
            Column3.HeaderText = "Конечная остановка";
            Column3.MinimumWidth = 10;
            Column3.Name = "Column3";
            Column3.Width = 200;
            // 
            // Column4
            // 
            Column4.HeaderText = "Тип";
            Column4.MinimumWidth = 10;
            Column4.Name = "Column4";
            Column4.Width = 200;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridViewFeatures_IPG);
            tabPage2.Location = new Point(8, 46);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1266, 956);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Избранное";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFeatures_IPG
            // 
            dataGridViewFeatures_IPG.AllowUserToAddRows = false;
            dataGridViewFeatures_IPG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFeatures_IPG.Columns.AddRange(new DataGridViewColumn[] { Column5, Column6, Column7, Column8 });
            dataGridViewFeatures_IPG.Location = new Point(6, 22);
            dataGridViewFeatures_IPG.Name = "dataGridViewFeatures_IPG";
            dataGridViewFeatures_IPG.RowHeadersVisible = false;
            dataGridViewFeatures_IPG.RowHeadersWidth = 82;
            dataGridViewFeatures_IPG.Size = new Size(1281, 919);
            dataGridViewFeatures_IPG.TabIndex = 0;
            // 
            // Column5
            // 
            Column5.HeaderText = "№";
            Column5.MinimumWidth = 10;
            Column5.Name = "Column5";
            Column5.Width = 200;
            // 
            // Column6
            // 
            Column6.HeaderText = "Начальная остановка";
            Column6.MinimumWidth = 10;
            Column6.Name = "Column6";
            Column6.Width = 200;
            // 
            // Column7
            // 
            Column7.HeaderText = "Конечная остановка";
            Column7.MinimumWidth = 10;
            Column7.Name = "Column7";
            Column7.Width = 200;
            // 
            // Column8
            // 
            Column8.HeaderText = "Тип";
            Column8.MinimumWidth = 10;
            Column8.Name = "Column8";
            Column8.Width = 200;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.9138012F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.0862F));
            tableLayoutPanel1.Controls.Add(tabControlRoutes_IPG, 1, 1);
            tableLayoutPanel1.Controls.Add(menuStrip_IPG, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4.611443F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 95.38856F));
            tableLayoutPanel1.Size = new Size(1891, 1096);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1891, 1096);
            Controls.Add(tableLayoutPanel1);
            MainMenuStrip = menuStrip_IPG;
            Name = "FormMain";
            Text = "Транспортные маршруты ";
            flowLayoutPanel1.ResumeLayout(false);
            groupBoxSearch_IPG.ResumeLayout(false);
            groupBoxSearch_IPG.PerformLayout();
            groupBoxFile_IPG.ResumeLayout(false);
            groupBoxEdit_IPG.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip_IPG.ResumeLayout(false);
            menuStrip_IPG.PerformLayout();
            tabControlRoutes_IPG.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewRoutes_IPG).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewFeatures_IPG).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private SaveFileDialog saveFileDialog_IPG;
        private OpenFileDialog openFileDialog_IPG;
        private ToolTip toolTip_IPG;
        private FlowLayoutPanel flowLayoutPanel1;
        private GroupBox groupBoxSearch_IPG;
        private TextBox textBoxSearch_IPG;
        private Button buttonSearch_IPG;
        private GroupBox groupBoxFile_IPG;
        private Button buttonSaveFile_IPG;
        private Button buttonOpenFile_IPG;
        private Button buttonUpdateFile_IPG;
        private GroupBox groupBoxEdit_IPG;
        private Button buttonOpenRoute_IPG;
        private Button buttonSetFeature_IPG;
        private GroupBox groupBox1;
        private Button buttonHelp_IPG;
        private Button buttonHelpImages_IPG;
        private ToolStrip miniToolStrip;
        private MenuStrip menuStrip_IPG;
        private ToolStripMenuItem ToolStripMenuItemProgramm_IPG;
        private ToolStripMenuItem ToolStripMenuAbout_IPG;
        private ToolStripMenuItem ToolStripMenuExit_IPG;
        private ToolStripMenuItem ToolStripMenuItemFile_IPG;
        private ToolStripMenuItem ToolStripMenuOpenNewFileTool_IPG;
        private ToolStripMenuItem ToolStripMenuSaveFile_IPG;
        private ToolStripMenuItem ToolStripMenuRefresh_IPG;
        private ToolStripMenuItem ToolStripMenuOpenFile_IPG;
        private TabControl tabControlRoutes_IPG;
        private TabPage tabPage1;
        private DataGridView dataGridViewRoutes_IPG;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private TabPage tabPage2;
        private DataGridView dataGridViewFeatures_IPG;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private TableLayoutPanel tableLayoutPanel1;
        private Label labelRowFocusIndex_IPG;
        private ToolStripMenuItem ToolStripMenuOpenNewFile_IPG;
        private ToolStripMenuItem ToolStripMenuImages_IPG;
        private ToolStripMenuItem открытьНовыйФайлToolStripMenuItem;
    }
}
