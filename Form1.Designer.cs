namespace WaterKoresVisualizer
{
    partial class Form1
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
            timer1 = new System.Windows.Forms.Timer(components);
            trackBar1 = new TrackBar();
            lbl_vel = new Label();
            openFileDialog1 = new OpenFileDialog();
            btnOpenFile = new Button();
            btnExport = new Button();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 10;
            // 
            // trackBar1
            // 
            trackBar1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            trackBar1.Location = new Point(743, 12);
            trackBar1.Minimum = 1;
            trackBar1.Name = "trackBar1";
            trackBar1.Orientation = Orientation.Vertical;
            trackBar1.Size = new Size(45, 223);
            trackBar1.TabIndex = 0;
            trackBar1.Value = 1;
            trackBar1.ValueChanged += trackBar1_ValueChanged;
            // 
            // lbl_vel
            // 
            lbl_vel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lbl_vel.AutoSize = true;
            lbl_vel.BackColor = SystemColors.ActiveCaptionText;
            lbl_vel.Font = new Font("Arial Black", 18F, FontStyle.Bold);
            lbl_vel.ForeColor = Color.Gold;
            lbl_vel.Location = new Point(741, 238);
            lbl_vel.Name = "lbl_vel";
            lbl_vel.Size = new Size(47, 33);
            lbl_vel.TabIndex = 1;
            lbl_vel.Text = "00";
            lbl_vel.TextAlign = ContentAlignment.TopCenter;
            lbl_vel.UseMnemonic = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnOpenFile
            // 
            btnOpenFile.Location = new Point(667, 415);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(121, 23);
            btnOpenFile.TabIndex = 2;
            btnOpenFile.Text = "Carregar Imagem";
            btnOpenFile.UseVisualStyleBackColor = true;
            btnOpenFile.Click += btnOpenFile_Click;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(12, 415);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(75, 23);
            btnExport.TabIndex = 3;
            btnExport.Text = "Exportar";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExport);
            Controls.Add(btnOpenFile);
            Controls.Add(lbl_vel);
            Controls.Add(trackBar1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private TrackBar trackBar1;
        private Label lbl_vel;
        private OpenFileDialog openFileDialog1;
        private Button btnOpenFile;
        private Button btnExport;
    }
}
