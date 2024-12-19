namespace Project.V14
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            groupBox_IPG = new GroupBox();
            textBox1 = new TextBox();
            pictureBox_IPG = new PictureBox();
            groupBox_IPG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_IPG).BeginInit();
            SuspendLayout();
            // 
            // groupBox_IPG
            // 
            groupBox_IPG.Controls.Add(textBox1);
            groupBox_IPG.Location = new Point(753, 169);
            groupBox_IPG.Name = "groupBox_IPG";
            groupBox_IPG.Size = new Size(579, 470);
            groupBox_IPG.TabIndex = 0;
            groupBox_IPG.TabStop = false;
            groupBox_IPG.Text = "Описание";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(0, 38);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(573, 441);
            textBox1.TabIndex = 0;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // pictureBox_IPG
            // 
            pictureBox_IPG.BackgroundImage = (Image)resources.GetObject("pictureBox_IPG.BackgroundImage");
            pictureBox_IPG.Location = new Point(12, 12);
            pictureBox_IPG.Name = "pictureBox_IPG";
            pictureBox_IPG.Size = new Size(720, 807);
            pictureBox_IPG.TabIndex = 1;
            pictureBox_IPG.TabStop = false;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1363, 850);
            Controls.Add(pictureBox_IPG);
            Controls.Add(groupBox_IPG);
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Транспортные маршруты";
            Load += FormAbout_Load;
            groupBox_IPG.ResumeLayout(false);
            groupBox_IPG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_IPG).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox_IPG;
        private TextBox textBox1;
        private PictureBox pictureBox_IPG;
    }
}