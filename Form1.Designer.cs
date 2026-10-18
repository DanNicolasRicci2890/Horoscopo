namespace Horoscopo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Calendar = new MonthCalendar();
            btn_OkAceptar = new Button();
            btn_CLEAR = new Button();
            lbl_FECHA = new Label();
            pcb_HOROSCOPO_CHINO = new PictureBox();
            pcb_HOROSCOPO_ZODIACO = new PictureBox();
            lbl_TITLE_CHINESE = new Label();
            lbl_TITLE_ZODIACO = new Label();
            ((System.ComponentModel.ISupportInitialize)pcb_HOROSCOPO_CHINO).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcb_HOROSCOPO_ZODIACO).BeginInit();
            SuspendLayout();
            // 
            // Calendar
            // 
            Calendar.BackColor = SystemColors.MenuHighlight;
            Calendar.Location = new Point(18, 18);
            Calendar.Name = "Calendar";
            Calendar.TabIndex = 0;
            Calendar.TitleForeColor = Color.Cyan;
            Calendar.TrailingForeColor = Color.FromArgb(0, 192, 192);
            // 
            // btn_OkAceptar
            // 
            btn_OkAceptar.Image = Properties.Resources.IconAceptar;
            btn_OkAceptar.Location = new Point(281, 18);
            btn_OkAceptar.MaximumSize = new Size(75, 75);
            btn_OkAceptar.MinimumSize = new Size(75, 75);
            btn_OkAceptar.Name = "btn_OkAceptar";
            btn_OkAceptar.Size = new Size(75, 75);
            btn_OkAceptar.TabIndex = 1;
            btn_OkAceptar.UseVisualStyleBackColor = true;
            btn_OkAceptar.Click += btn_OkAceptar_Click;
            // 
            // btn_CLEAR
            // 
            btn_CLEAR.BackColor = Color.Transparent;
            btn_CLEAR.Image = Properties.Resources.basura1;
            btn_CLEAR.Location = new Point(281, 105);
            btn_CLEAR.MaximumSize = new Size(75, 75);
            btn_CLEAR.MinimumSize = new Size(75, 75);
            btn_CLEAR.Name = "btn_CLEAR";
            btn_CLEAR.Size = new Size(75, 75);
            btn_CLEAR.TabIndex = 2;
            btn_CLEAR.UseVisualStyleBackColor = false;
            btn_CLEAR.Click += btn_CLEAR_Click;
            // 
            // lbl_FECHA
            // 
            lbl_FECHA.AutoSize = true;
            lbl_FECHA.BackColor = Color.Transparent;
            lbl_FECHA.Font = new Font("Showcard Gothic", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_FECHA.ForeColor = Color.Red;
            lbl_FECHA.Location = new Point(389, 55);
            lbl_FECHA.Name = "lbl_FECHA";
            lbl_FECHA.Size = new Size(0, 79);
            lbl_FECHA.TabIndex = 3;
            // 
            // pcb_HOROSCOPO_CHINO
            // 
            pcb_HOROSCOPO_CHINO.BackColor = Color.Transparent;
            pcb_HOROSCOPO_CHINO.BackgroundImage = Properties.Resources.horoscopo_chino;
            pcb_HOROSCOPO_CHINO.BackgroundImageLayout = ImageLayout.Stretch;
            pcb_HOROSCOPO_CHINO.Location = new Point(118, 297);
            pcb_HOROSCOPO_CHINO.MaximumSize = new Size(400, 400);
            pcb_HOROSCOPO_CHINO.MinimumSize = new Size(400, 400);
            pcb_HOROSCOPO_CHINO.Name = "pcb_HOROSCOPO_CHINO";
            pcb_HOROSCOPO_CHINO.Size = new Size(400, 400);
            pcb_HOROSCOPO_CHINO.TabIndex = 4;
            pcb_HOROSCOPO_CHINO.TabStop = false;
            // 
            // pcb_HOROSCOPO_ZODIACO
            // 
            pcb_HOROSCOPO_ZODIACO.BackColor = Color.Transparent;
            pcb_HOROSCOPO_ZODIACO.BackgroundImage = Properties.Resources.horoscopo_zodiaco;
            pcb_HOROSCOPO_ZODIACO.BackgroundImageLayout = ImageLayout.Stretch;
            pcb_HOROSCOPO_ZODIACO.Location = new Point(601, 297);
            pcb_HOROSCOPO_ZODIACO.MaximumSize = new Size(400, 400);
            pcb_HOROSCOPO_ZODIACO.MinimumSize = new Size(400, 400);
            pcb_HOROSCOPO_ZODIACO.Name = "pcb_HOROSCOPO_ZODIACO";
            pcb_HOROSCOPO_ZODIACO.Size = new Size(400, 400);
            pcb_HOROSCOPO_ZODIACO.TabIndex = 5;
            pcb_HOROSCOPO_ZODIACO.TabStop = false;
            // 
            // lbl_TITLE_CHINESE
            // 
            lbl_TITLE_CHINESE.AutoSize = true;
            lbl_TITLE_CHINESE.BackColor = Color.Transparent;
            lbl_TITLE_CHINESE.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_TITLE_CHINESE.ForeColor = Color.Red;
            lbl_TITLE_CHINESE.Location = new Point(156, 236);
            lbl_TITLE_CHINESE.Name = "lbl_TITLE_CHINESE";
            lbl_TITLE_CHINESE.Size = new Size(0, 45);
            lbl_TITLE_CHINESE.TabIndex = 6;
            // 
            // lbl_TITLE_ZODIACO
            // 
            lbl_TITLE_ZODIACO.AutoSize = true;
            lbl_TITLE_ZODIACO.BackColor = Color.Transparent;
            lbl_TITLE_ZODIACO.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_TITLE_ZODIACO.ForeColor = Color.Red;
            lbl_TITLE_ZODIACO.Location = new Point(720, 236);
            lbl_TITLE_ZODIACO.Name = "lbl_TITLE_ZODIACO";
            lbl_TITLE_ZODIACO.Size = new Size(0, 45);
            lbl_TITLE_ZODIACO.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo;
            ClientSize = new Size(1131, 726);
            Controls.Add(lbl_TITLE_ZODIACO);
            Controls.Add(lbl_TITLE_CHINESE);
            Controls.Add(pcb_HOROSCOPO_ZODIACO);
            Controls.Add(pcb_HOROSCOPO_CHINO);
            Controls.Add(lbl_FECHA);
            Controls.Add(btn_CLEAR);
            Controls.Add(btn_OkAceptar);
            Controls.Add(Calendar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1147, 765);
            MinimumSize = new Size(1147, 765);
            Name = "Form1";
            Text = "HOROSCOPO";
            ((System.ComponentModel.ISupportInitialize)pcb_HOROSCOPO_CHINO).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcb_HOROSCOPO_ZODIACO).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar Calendar;
        private Button btn_OkAceptar;
        private Button btn_CLEAR;
        private Label lbl_FECHA;
        private PictureBox pcb_HOROSCOPO_CHINO;
        private PictureBox pcb_HOROSCOPO_ZODIACO;
        private Label lbl_TITLE_CHINESE;
        private Label lbl_TITLE_ZODIACO;
    }
}
