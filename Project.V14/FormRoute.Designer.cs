namespace Project.V14
{
    partial class FormRoute
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelRouteDescription_IPG = new FlowLayoutPanel();
            groupBoxRouteDescription_IPG = new GroupBox();
            textBoxRouteType_IPG = new TextBox();
            textBoxRouteEnd_IPG = new TextBox();
            textBoxRouteStart_IPG = new TextBox();
            textBoxRouteId_IPG = new TextBox();
            groupBox2 = new GroupBox();
            textBoxRouteTime_IPG = new TextBox();
            pictureBoxRoute_IPG = new PictureBox();
            panelRouteStops_IPG = new FlowLayoutPanel();
            groupBoxRouteList_IPG = new GroupBox();
            flowLayoutPanel_IPG = new FlowLayoutPanel();
            panelRouteDescription_IPG.SuspendLayout();
            groupBoxRouteDescription_IPG.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRoute_IPG).BeginInit();
            panelRouteStops_IPG.SuspendLayout();
            groupBoxRouteList_IPG.SuspendLayout();
            SuspendLayout();
            // 
            // panelRouteDescription_IPG
            // 
            panelRouteDescription_IPG.Controls.Add(groupBoxRouteDescription_IPG);
            panelRouteDescription_IPG.Location = new Point(12, 12);
            panelRouteDescription_IPG.Name = "panelRouteDescription_IPG";
            panelRouteDescription_IPG.Size = new Size(498, 721);
            panelRouteDescription_IPG.TabIndex = 0;
            // 
            // groupBoxRouteDescription_IPG
            // 
            groupBoxRouteDescription_IPG.Controls.Add(textBoxRouteType_IPG);
            groupBoxRouteDescription_IPG.Controls.Add(textBoxRouteEnd_IPG);
            groupBoxRouteDescription_IPG.Controls.Add(textBoxRouteStart_IPG);
            groupBoxRouteDescription_IPG.Controls.Add(textBoxRouteId_IPG);
            groupBoxRouteDescription_IPG.Controls.Add(groupBox2);
            groupBoxRouteDescription_IPG.Location = new Point(3, 3);
            groupBoxRouteDescription_IPG.Name = "groupBoxRouteDescription_IPG";
            groupBoxRouteDescription_IPG.Size = new Size(483, 709);
            groupBoxRouteDescription_IPG.TabIndex = 0;
            groupBoxRouteDescription_IPG.TabStop = false;
            groupBoxRouteDescription_IPG.Text = "Описание маршрутов ";
            // 
            // textBoxRouteType_IPG
            // 
            textBoxRouteType_IPG.BorderStyle = BorderStyle.None;
            textBoxRouteType_IPG.Location = new Point(20, 398);
            textBoxRouteType_IPG.Name = "textBoxRouteType_IPG";
            textBoxRouteType_IPG.ReadOnly = true;
            textBoxRouteType_IPG.Size = new Size(200, 32);
            textBoxRouteType_IPG.TabIndex = 4;
            textBoxRouteType_IPG.Text = "Вид траспорта - ";
            // 
            // textBoxRouteEnd_IPG
            // 
            textBoxRouteEnd_IPG.BorderStyle = BorderStyle.None;
            textBoxRouteEnd_IPG.Location = new Point(20, 319);
            textBoxRouteEnd_IPG.Name = "textBoxRouteEnd_IPG";
            textBoxRouteEnd_IPG.ReadOnly = true;
            textBoxRouteEnd_IPG.Size = new Size(275, 32);
            textBoxRouteEnd_IPG.TabIndex = 3;
            textBoxRouteEnd_IPG.Text = "Конечная остановка - ";
            // 
            // textBoxRouteStart_IPG
            // 
            textBoxRouteStart_IPG.BorderStyle = BorderStyle.None;
            textBoxRouteStart_IPG.Location = new Point(20, 230);
            textBoxRouteStart_IPG.Name = "textBoxRouteStart_IPG";
            textBoxRouteStart_IPG.ReadOnly = true;
            textBoxRouteStart_IPG.Size = new Size(304, 32);
            textBoxRouteStart_IPG.TabIndex = 2;
            textBoxRouteStart_IPG.Text = "Начальная остановка -";
            // 
            // textBoxRouteId_IPG
            // 
            textBoxRouteId_IPG.BorderStyle = BorderStyle.None;
            textBoxRouteId_IPG.Location = new Point(20, 111);
            textBoxRouteId_IPG.Name = "textBoxRouteId_IPG";
            textBoxRouteId_IPG.ReadOnly = true;
            textBoxRouteId_IPG.Size = new Size(241, 32);
            textBoxRouteId_IPG.TabIndex = 1;
            textBoxRouteId_IPG.Text = "Номер маршрута - ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxRouteTime_IPG);
            groupBox2.Location = new Point(20, 494);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(400, 200);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Время в пути ";
            // 
            // textBoxRouteTime_IPG
            // 
            textBoxRouteTime_IPG.BorderStyle = BorderStyle.None;
            textBoxRouteTime_IPG.Location = new Point(6, 38);
            textBoxRouteTime_IPG.Multiline = true;
            textBoxRouteTime_IPG.Name = "textBoxRouteTime_IPG";
            textBoxRouteTime_IPG.ReadOnly = true;
            textBoxRouteTime_IPG.Size = new Size(334, 78);
            textBoxRouteTime_IPG.TabIndex = 0;
            textBoxRouteTime_IPG.Text = "Примерное время ожидания автобуса - ";
            // 
            // pictureBoxRoute_IPG
            // 
            pictureBoxRoute_IPG.Location = new Point(519, 8);
            pictureBoxRoute_IPG.Name = "pictureBoxRoute_IPG";
            pictureBoxRoute_IPG.Size = new Size(491, 190);
            pictureBoxRoute_IPG.TabIndex = 1;
            pictureBoxRoute_IPG.TabStop = false;
            // 
            // panelRouteStops_IPG
            // 
            panelRouteStops_IPG.Controls.Add(groupBoxRouteList_IPG);
            panelRouteStops_IPG.Location = new Point(516, 204);
            panelRouteStops_IPG.Name = "panelRouteStops_IPG";
            panelRouteStops_IPG.Size = new Size(498, 543);
            panelRouteStops_IPG.TabIndex = 0;
            // 
            // groupBoxRouteList_IPG
            // 
            groupBoxRouteList_IPG.Controls.Add(flowLayoutPanel_IPG);
            groupBoxRouteList_IPG.Location = new Point(3, 3);
            groupBoxRouteList_IPG.Name = "groupBoxRouteList_IPG";
            groupBoxRouteList_IPG.Size = new Size(491, 526);
            groupBoxRouteList_IPG.TabIndex = 0;
            groupBoxRouteList_IPG.TabStop = false;
            groupBoxRouteList_IPG.Text = "Остановки города";
            // 
            // flowLayoutPanel_IPG
            // 
            flowLayoutPanel_IPG.Location = new Point(17, 38);
            flowLayoutPanel_IPG.Name = "flowLayoutPanel_IPG";
            flowLayoutPanel_IPG.Size = new Size(468, 488);
            flowLayoutPanel_IPG.TabIndex = 0;
            // 
            // FormRoute
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 759);
            Controls.Add(pictureBoxRoute_IPG);
            Controls.Add(panelRouteStops_IPG);
            Controls.Add(panelRouteDescription_IPG);
            Name = "FormRoute";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Транспортные маршруты";
            Load += FormRoute_Load;
            panelRouteDescription_IPG.ResumeLayout(false);
            groupBoxRouteDescription_IPG.ResumeLayout(false);
            groupBoxRouteDescription_IPG.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRoute_IPG).EndInit();
            panelRouteStops_IPG.ResumeLayout(false);
            groupBoxRouteList_IPG.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel panelRouteDescription_IPG;
        private GroupBox groupBoxRouteDescription_IPG;
        private TextBox textBoxRouteType_IPG;
        private TextBox textBoxRouteEnd_IPG;
        private TextBox textBoxRouteStart_IPG;
        private TextBox textBoxRouteId_IPG;
        private GroupBox groupBox2;
        private TextBox textBoxRouteTime_IPG;
        private PictureBox pictureBoxRoute_IPG;
        private FlowLayoutPanel panelRouteStops_IPG;
        private GroupBox groupBoxRouteList_IPG;
        private FlowLayoutPanel flowLayoutPanel_IPG;
    }
}