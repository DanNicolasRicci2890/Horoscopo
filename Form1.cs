using System.Globalization;

namespace Horoscopo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_OkAceptar_Click(object sender, EventArgs e)
        {            
            DateTime fecha = this.Calendar.SelectionStart;
            string frase = String.Concat(fecha.Day.ToString(), " de ");
            frase += String.Concat(fecha.ToString("MMMM", new CultureInfo("es-AR")));
            frase += String.Concat(" ", fecha.Year.ToString());
            this.lbl_FECHA.Text = frase;
            HOROSCOPO_CHINO(sender, e, fecha);
            HOROSCOPO_ZODIACO(sender, e, fecha);
            this.Calendar.Enabled = false;
        }

        private void btn_CLEAR_Click(object sender, EventArgs e)
        {
            this.Calendar.Enabled = true;
            this.lbl_FECHA.Text = "";
            this.lbl_TITLE_CHINESE.Text = "";
            this.lbl_TITLE_ZODIACO.Text = "";
            this.pcb_HOROSCOPO_CHINO.BackgroundImage = Properties.Resources.horoscopo_chino;
            this.pcb_HOROSCOPO_ZODIACO.BackgroundImage = Properties.Resources.horoscopo_zodiaco;    
        }
        private void HOROSCOPO_ZODIACO(object sender, EventArgs e, DateTime fecha)
        {
            DateTime verif1 = new DateTime(fecha.Year, 3, 21);
            DateTime verif2 = new DateTime(fecha.Year, 4, 19);
            int cont = 0;

            while(cont < 12)
            {
                switch(cont)
                {
                    case 0: verif1 = new DateTime(fecha.Year, 3, 21);
                            verif2 = new DateTime(fecha.Year, 4, 19);
                            break;

                    case 1: verif1 = new DateTime(fecha.Year, 4, 20);
                            verif2 = new DateTime(fecha.Year, 5, 20);
                            break;

                    case 2: verif1 = new DateTime(fecha.Year, 5, 21);
                            verif2 = new DateTime(fecha.Year, 6, 20);
                            break;

                    case 3: verif1 = new DateTime(fecha.Year, 6, 21);
                            verif2 = new DateTime(fecha.Year, 7, 22);
                            break;

                    case 4: verif1 = new DateTime(fecha.Year, 7, 23);
                            verif2 = new DateTime(fecha.Year, 8, 22);
                            break;

                    case 5: verif1 = new DateTime(fecha.Year, 8, 23);
                            verif2 = new DateTime(fecha.Year, 9, 22);
                            break;

                    case 6: verif1 = new DateTime(fecha.Year, 9, 23);
                            verif2 = new DateTime(fecha.Year, 10, 22);
                            break;

                    case 7: verif1 = new DateTime(fecha.Year, 10, 23);
                            verif2 = new DateTime(fecha.Year, 11, 21);
                            break;

                    case 8: verif1 = new DateTime(fecha.Year, 11, 22);
                            verif2 = new DateTime(fecha.Year, 12, 21);
                            break;

                    case 9: verif1 = new DateTime(fecha.Year, 12, 22);
                            verif2 = new DateTime(fecha.Year, 1, 20);
                            break;

                    case 10: verif1 = new DateTime(fecha.Year, 1, 21);
                             verif2 = new DateTime(fecha.Year, 2, 19);
                             break;

                    case 11: verif1 = new DateTime(fecha.Year, 2, 20);
                             verif2 = new DateTime(fecha.Year, 3, 20);
                             break;
                }
                if ((verif1 <= fecha) && (verif2 >= fecha))
                {
                    break;
                }
                cont++;
            }
            this.lbl_TITLE_ZODIACO.Text = LabelZodiaco(cont);
            PictureZodiaco(sender, e, cont);
        }
        private void HOROSCOPO_CHINO(object sender, EventArgs e, DateTime fecha)
        {
            int cond1 = CalcularHoroscopoChino(fecha);
            int year_chinese = fecha.Year - cond1;
            int Kchinese = year_chinese % 12;
            int element = CalcularElemento(year_chinese);
            int const_chinese = (Kchinese * 5) + element;
            string label_chino = LabelChinese(const_chinese);
            this.lbl_TITLE_CHINESE.Text = label_chino;
            PictureChinese(sender, e, Kchinese);
           
        }
        private void PictureZodiaco(object sender, EventArgs e, int cont)
        {
            switch(cont)
            {
                case 0: this.pcb_HOROSCOPO_ZODIACO.BackgroundImage = Properties.Resources.Aries; break;
                case 1: this.pcb_HOROSCOPO_ZODIACO.BackgroundImage = Properties.Resources.Tauro; break;
                case 2: this.pcb_HOROSCOPO_ZODIACO.BackgroundImage = Properties.Resources.Geminis; break;
                case 3: this.pcb_HOROSCOPO_ZODIACO.BackgroundImage = Properties.Resources.Cancer; break;
                case 4: this.pcb_HOROSCOPO_ZODIACO.BackgroundImage = Properties.Resources.Leo; break;
                case 5: this.pcb_HOROSCOPO_ZODIACO.BackgroundImage = Properties.Resources.Virgo; break;
                case 6: this.pcb_HOROSCOPO_ZODIACO.BackgroundImage = Properties.Resources.Libra; break;
                case 7: this.pcb_HOROSCOPO_ZODIACO.BackgroundImage = Properties.Resources.Escorpio; break;
                case 8: this.pcb_HOROSCOPO_ZODIACO.BackgroundImage = Properties.Resources.Sagitario; break;
                case 9: this.pcb_HOROSCOPO_ZODIACO.BackgroundImage = Properties.Resources.Capricornio; break;
                case 10: this.pcb_HOROSCOPO_ZODIACO.BackgroundImage = Properties.Resources.Acuario; break;
                case 11: this.pcb_HOROSCOPO_ZODIACO.BackgroundImage = Properties.Resources.Piscis; break;
            }
        }
        private void PictureChinese(object sender, EventArgs e, int Kchinese)
        {            
            switch (Kchinese)
            {
                case 0: this.pcb_HOROSCOPO_CHINO.BackgroundImage = Properties.Resources.chino_mono; break;
                case 1: this.pcb_HOROSCOPO_CHINO.BackgroundImage = Properties.Resources.chino_gallo; break;
                case 2: this.pcb_HOROSCOPO_CHINO.BackgroundImage = Properties.Resources.chino_perro; break;
                case 3: this.pcb_HOROSCOPO_CHINO.BackgroundImage = Properties.Resources.chino_cerdo; break;

                case 4: this.pcb_HOROSCOPO_CHINO.BackgroundImage = Properties.Resources.chino_rata; break;
                case 5: this.pcb_HOROSCOPO_CHINO.BackgroundImage = Properties.Resources.chino_buey; break;
                case 6: this.pcb_HOROSCOPO_CHINO.BackgroundImage = Properties.Resources.chino_tigre; break;
                case 7: this.pcb_HOROSCOPO_CHINO.BackgroundImage = Properties.Resources.chino_conejo; break;

                case 8: this.pcb_HOROSCOPO_CHINO.BackgroundImage = Properties.Resources.chino_dragon; break;
                case 9: this.pcb_HOROSCOPO_CHINO.BackgroundImage = Properties.Resources.chino_serpiente; break;
                case 10: this.pcb_HOROSCOPO_CHINO.BackgroundImage = Properties.Resources.chino_caballo; break;
                case 11: this.pcb_HOROSCOPO_CHINO.BackgroundImage = Properties.Resources.chino_cabra; break;
            }
        }
        private string LabelZodiaco(int const_zodiaco)
        {
            string label_zodiaco = "";
            switch(const_zodiaco)
            {
                case 0: label_zodiaco = "ARIES"; break;
                case 1: label_zodiaco = "TAURO"; break;
                case 2: label_zodiaco = "GEMINIS"; break;
                case 3: label_zodiaco = "CANCER"; break;
                case 4: label_zodiaco = "LEO"; break;
                case 5: label_zodiaco = "VIRGO"; break;
                case 6: label_zodiaco = "LIBRA"; break;
                case 7: label_zodiaco = "ESCORPIO"; break;
                case 8: label_zodiaco = "SAGITARIO"; break;
                case 9: label_zodiaco = "CAPRICORNIO"; break;
                case 10: label_zodiaco = "ACUARIO"; break;
                case 11: label_zodiaco = "PISCIS"; break;
            }

            return label_zodiaco;
        }
        private string LabelChinese(int const_chinese)
        {
            string label_chino = "";
            switch(const_chinese)
            {
                case 0: label_chino = "MONO de METAL"; break;
                case 1: label_chino = "MONO de AGUA"; break;
                case 2: label_chino = "MONO de MADERA"; break;
                case 3: label_chino = "MONO de FUEGO"; break;
                case 4: label_chino = "MONO de TIERRA"; break;

                case 5: label_chino = "GALLO de METAL"; break;
                case 6: label_chino = "GALLO de AGUA"; break;
                case 7: label_chino = "GALLO de MADERA"; break;
                case 8: label_chino = "GALLO de FUEGO"; break;
                case 9: label_chino = "GALLO de TIERRA"; break;

                case 10: label_chino = "PERRO de METAL"; break;
                case 11: label_chino = "PERRO de AGUA"; break;
                case 12: label_chino = "PERRO de MADERA"; break;
                case 13: label_chino = "PERRO de FUEGO"; break;
                case 14: label_chino = "PERRO de TIERRA"; break;

                case 15: label_chino = "CERDO de METAL"; break;
                case 16: label_chino = "CERDO de AGUA"; break;
                case 17: label_chino = "CERDO de MADERA"; break;
                case 18: label_chino = "CERDO de FUEGO"; break;
                case 19: label_chino = "CERDO de TIERRA"; break;

                case 20: label_chino = "RATA de METAL"; break;
                case 21: label_chino = "RATA de AGUA"; break;
                case 22: label_chino = "RATA de MADERA"; break;
                case 23: label_chino = "RATA de FUEGO"; break;
                case 24: label_chino = "RATA de TIERRA"; break;

                case 25: label_chino = "BUEY de METAL"; break;
                case 26: label_chino = "BUEY de AGUA"; break;
                case 27: label_chino = "BUEY de MADERA"; break;
                case 28: label_chino = "BUEY de FUEGO"; break;
                case 29: label_chino = "BUEY de TIERRA"; break;

                case 30: label_chino = "TIGRE de METAL"; break;
                case 31: label_chino = "TIGRE de AGUA"; break;
                case 32: label_chino = "TIGRE de MADERA"; break;
                case 33: label_chino = "TIGRE de FUEGO"; break;
                case 34: label_chino = "TIGRE de TIERRA"; break;

                case 35: label_chino = "CONEJO de METAL"; break;
                case 36: label_chino = "CONEJO de AGUA"; break;
                case 37: label_chino = "CONEJO de MADERA"; break;
                case 38: label_chino = "CONEJO de FUEGO"; break;
                case 39: label_chino = "CONEJO de TIERRA"; break;

                case 40: label_chino = "DRAGON de METAL"; break;
                case 41: label_chino = "DRAGON de AGUA"; break;
                case 42: label_chino = "DRAGON de MADERA"; break;
                case 43: label_chino = "DRAGON de FUEGO"; break;
                case 44: label_chino = "DRAGON de TIERRA"; break;

                case 45: label_chino = "SERPIENTE de METAL"; break;
                case 46: label_chino = "SERPIENTE de AGUA"; break;
                case 47: label_chino = "SERPIENTE de MADERA"; break;
                case 48: label_chino = "SERPIENTE de FUEGO"; break;
                case 49: label_chino = "SERPIENTE de TIERRA"; break;

                case 50: label_chino = "CABALLO de METAL"; break;
                case 51: label_chino = "CABALLO de AGUA"; break;
                case 52: label_chino = "CABALLO de MADERA"; break;
                case 53: label_chino = "CABALLO de FUEGO"; break;
                case 54: label_chino = "CABALLO de TIERRA"; break;

                case 55: label_chino = "CABRA de METAL"; break;
                case 56: label_chino = "CABRA de AGUA"; break;
                case 57: label_chino = "CABRA de MADERA"; break;
                case 58: label_chino = "CABRA de FUEGO"; break;
                case 59: label_chino = "CABRA de TIERRA"; break;
            }

            return label_chino;
        }

        private int CalcularElemento(int year)
        {
            int element = 0;
            switch(year % 10)
            {
                case 0:
                case 1: element = 0; break;
                case 2:
                case 3: element = 1; break;
                case 4:
                case 5: element = 2; break;
                case 6:
                case 7: element = 3; break;
                case 8:
                case 9: element = 4; break;
            }
            return element;
        }

        private int CalcularHoroscopoChino(DateTime fecha)
        {
            DateTime ANCHINO = CalcularAnioNuevoChino((int)fecha.Year);

            // verificar si la fecha seleccionada es anterior o posterior
            // a la fecha del año nuevo chino.
            if ((DateTime.Compare(fecha, ANCHINO)) < 0) {
                return 1;
            }
            return 0;
        }

        private DateTime CalcularAnioNuevoChino(int year)
        {
            var chineseCalendar = new ChineseLunisolarCalendar();

            // El Año Nuevo Chino siempre es el primer día del primer mes del calendario lunisolar chino
            return chineseCalendar.ToDateTime(year, 1, 1, 0, 0, 0, 0);
        }       
    }
}
