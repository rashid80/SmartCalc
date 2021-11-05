using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            formInit();
        }


        private void formInit()
        {

            this.Text = Service.getVersion();

            res.DataSource = new BindingSource(Service.getStringArrayFromJsonResources(Properties.Resources.res_json), null);
            tipRU.DataSource = new BindingSource(Service.getStringArrayFromJsonResources(Properties.Resources.tipRU_json), null);

            month.DataSource = new BindingSource(Service.getDictionaryFromJsonResources(Properties.Resources.monts_json), null);
            month.DisplayMember = "Key";
            month.ValueMember = "Value";

            podryad.DataSource = new BindingSource(Service.getStringArrayFromJsonResources(Properties.Resources.podrayd_json), null);

            tipMontazha.DataSource = new BindingSource(Service.getDictionaryFromJsonResources(Properties.Resources.tipMontazha_json), null);
            tipMontazha.DisplayMember = "Key";
            tipMontazha.ValueMember = "Value";

            filial.DataSource = new BindingSource(Service.getStringArrayFromJsonResources(Properties.Resources.filial_json), null);

            podchChet.Rows.Clear();
            podchChet.Rows.Add("Мастер 3ф ТТ", "0", "0", "0", "0");
            podchChet.Rows.Add("Линейный 3ф ТТ", "0", "0", "0", "0");
            podchChet.Rows.Add("Отходящий 3 Ф", "0", "0", "0", "0");
            podchChet.Rows.Add("Отходящий 1 Ф", "0", "0", "0", "0");
            podchChet.AllowUserToAddRows = false;

            kolvoVidChetch.Rows.Clear();
            kolvoVidChetch.Rows.Add("Мастер 3ф ТТ", "0", "0", "0", "0");
            kolvoVidChetch.Rows.Add("Линейный 3ф ТТ", "0", "0", "0", "0");
            kolvoVidChetch.Rows.Add("Отходящий 3 Ф", "0", "0", "0", "0");
            kolvoVidChetch.Rows.Add("Отходящий 1 Ф", "0", "0", "0", "0");
            kolvoVidChetch.AllowUserToAddRows = false;

            tiporazmerShkafov.Rows.Clear();
            tiporazmerShkafov.Rows.Add("1-2", "0", "0", "0", "0");
            tiporazmerShkafov.Rows.Add("3-4", "0", "0", "0", "0");
            tiporazmerShkafov.Rows.Add("5-9", "0", "0", "0", "0");
            tiporazmerShkafov.Rows.Add("10-12", "0", "0", "0", "0");
            tiporazmerShkafov.AllowUserToAddRows = false;

            uzelNarachKabel.Rows.Clear();
            uzelNarachKabel.Rows.Add("25 мм2", "0");
            uzelNarachKabel.Rows.Add("35 мм2", "0");
            uzelNarachKabel.Rows.Add("50 мм2", "0");
            uzelNarachKabel.Rows.Add("75 мм2", "0");
            uzelNarachKabel.Rows.Add("95 мм2", "0");
            tiporazmerShkafov.AllowUserToAddRows = false;

            kolvoChetVShkafu.Rows.Clear();
            kolvoChetVShkafu.Rows.Add("Мастер 3ф ТТ", "0", "0");
            kolvoChetVShkafu.Rows.Add("Линейный 3ф ТТ", "0", "0");
            kolvoChetVShkafu.Rows.Add("Отходящий 3 Ф", "0", "0");
            kolvoChetVShkafu.Rows.Add("Отходящий 1 Ф", "0", "0");
            kolvoChetVShkafu.AllowUserToAddRows = false;

            nomerTP.Text = "";
            dataOtkl.Text = "";
            rastDver1.Text = "0";
            rastDver2.Text = "0";
            sredRastMdPU.Text = "0";
            rastTTdoShkafa.Text = "0";
            rastOtMestaUstDoShkafa.Text = "0";
            f3ChetchPryamVkl.Text = "0";
            f1ChetchPryamVkl.Text = "0";
            svaya.Checked = false;
            kabelDlyaNarach.Text = "0";
            zazhimDlyNarach.Text = "0";

        }

        private void SelectFolder()
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            FBD.SelectedPath = folderName.Text;

            if (FBD.ShowDialog() == DialogResult.OK)
            {
                folderName.Text = FBD.SelectedPath;
            }

        }


        private void ButtonSelectFolder_Click(object sender, EventArgs e)
        {
            SelectFolder();
        }

        private void ButtonCompute_Click(object sender, EventArgs e)
        {

            //            string text = @"Выполняется расчет.
            //После окончания расчета в папку <" + folderName.Text + @"> ,
            //в 4 файла спецификации будут добавлены строки с расчетными данными.";
            //
            //           MessageBox.Show(text);

            this.Enabled = false;

            GenerateReports();

            this.Enabled = true;

        }

        private void GenerateReports() {

            if (folderName.Text == "")
            {
                MessageBox.Show("Не выбрана папка для записи!");
                return;
            }


            Reports reps;

            try
            {

                var ol = new Ol(this); //Структура исходных данных
                reps = new Reports(ol); // Готовим структуры Расчет1 и Расчет2
            }
            catch (Exception e)
            {

                MessageBox.Show(@"Расчет невозможен по причине: " + e.ToString());
                return;

            }

            var t1 = reps.AddStringToReport_BSH(folderName.Text);
            var t2 = reps.AddStringToReport_MPOT(folderName.Text);
            var t3 = reps.AddStringToReport_PE(folderName.Text);
            var t4 = reps.AddStringToReport_SZ(folderName.Text);

            MessageBox.Show(t1.Item2 + Environment.NewLine + t2.Item2 + Environment.NewLine + t3.Item2 + Environment.NewLine + t4.Item2);

            if (t1.Item1 | t2.Item1 | t3.Item1 | t4.Item1)
            {
                return;
            }

            formInit();

        }



    }
}
