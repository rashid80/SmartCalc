namespace SmartCalc
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.res = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.nomerTP = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tipRU = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.month = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataOtkl = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.podryad = new System.Windows.Forms.ComboBox();
            this.podchChet = new System.Windows.Forms.DataGridView();
            this.StringName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vvod1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vvod2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vvod3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vvod4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.rastDver1 = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rastDver2 = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.kolvoVidChetch = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tiporazmerShkafov = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.sredRastMdPU = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.rastTTdoShkafa = new System.Windows.Forms.MaskedTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.rastOtMestaUstDoShkafa = new System.Windows.Forms.MaskedTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.f3ChetchPryamVkl = new System.Windows.Forms.MaskedTextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.f1ChetchPryamVkl = new System.Windows.Forms.MaskedTextBox();
            this.uzelNarachKabel = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolvoChetVShkafu = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.zazhimDlyNarach = new System.Windows.Forms.MaskedTextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.kabelDlyaNarach = new System.Windows.Forms.MaskedTextBox();
            this.svaya = new System.Windows.Forms.CheckBox();
            this.tipMontazha = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonCompute = new System.Windows.Forms.Button();
            this.buttonSelectFolder = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.folderName = new System.Windows.Forms.MaskedTextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.filial = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.podchChet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kolvoVidChetch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiporazmerShkafov)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uzelNarachKabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kolvoChetVShkafu)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // res
            // 
            this.res.FormattingEnabled = true;
            this.res.Location = new System.Drawing.Point(212, 11);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(193, 21);
            this.res.TabIndex = 0;
            // 
            // nomerTP
            // 
            this.nomerTP.Location = new System.Drawing.Point(212, 36);
            this.nomerTP.Name = "nomerTP";
            this.nomerTP.Size = new System.Drawing.Size(193, 20);
            this.nomerTP.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "РЭС:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(13, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Номер ТП:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(13, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Тип РУ:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tipRU
            // 
            this.tipRU.FormattingEnabled = true;
            this.tipRU.Location = new System.Drawing.Point(212, 62);
            this.tipRU.Name = "tipRU";
            this.tipRU.Size = new System.Drawing.Size(193, 21);
            this.tipRU.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(13, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Месяц:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // month
            // 
            this.month.FormattingEnabled = true;
            this.month.Location = new System.Drawing.Point(212, 89);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(193, 21);
            this.month.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(457, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Дата откл.:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataOtkl
            // 
            this.dataOtkl.Location = new System.Drawing.Point(534, 9);
            this.dataOtkl.Mask = "00/00/0000";
            this.dataOtkl.Name = "dataOtkl";
            this.dataOtkl.Size = new System.Drawing.Size(193, 20);
            this.dataOtkl.TabIndex = 9;
            this.dataOtkl.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(457, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "Подрядчик:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // podryad
            // 
            this.podryad.FormattingEnabled = true;
            this.podryad.Location = new System.Drawing.Point(534, 62);
            this.podryad.Name = "podryad";
            this.podryad.Size = new System.Drawing.Size(193, 21);
            this.podryad.TabIndex = 11;
            // 
            // podchChet
            // 
            this.podchChet.AllowUserToAddRows = false;
            this.podchChet.AllowUserToDeleteRows = false;
            this.podchChet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.podchChet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StringName,
            this.vvod1,
            this.Vvod2,
            this.Vvod3,
            this.Vvod4});
            this.podchChet.Location = new System.Drawing.Point(212, 118);
            this.podchChet.Name = "podchChet";
            this.podchChet.Size = new System.Drawing.Size(515, 111);
            this.podchChet.TabIndex = 13;
            // 
            // StringName
            // 
            this.StringName.HeaderText = "";
            this.StringName.Name = "StringName";
            this.StringName.ReadOnly = true;
            this.StringName.Width = 172;
            // 
            // vvod1
            // 
            this.vvod1.HeaderText = "1-й ввод";
            this.vvod1.Name = "vvod1";
            this.vvod1.Width = 75;
            // 
            // Vvod2
            // 
            this.Vvod2.HeaderText = "2-й ввод";
            this.Vvod2.Name = "Vvod2";
            this.Vvod2.Width = 75;
            // 
            // Vvod3
            // 
            this.Vvod3.HeaderText = "3-й ввод";
            this.Vvod3.Name = "Vvod3";
            this.Vvod3.Width = 75;
            // 
            // Vvod4
            // 
            this.Vvod4.HeaderText = "4-й ввод";
            this.Vvod4.Name = "Vvod4";
            this.Vvod4.Width = 75;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(451, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "1 дверь:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rastDver1
            // 
            this.rastDver1.Location = new System.Drawing.Point(515, 235);
            this.rastDver1.Name = "rastDver1";
            this.rastDver1.Size = new System.Drawing.Size(58, 20);
            this.rastDver1.TabIndex = 14;
            this.rastDver1.Text = "0";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(605, 235);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "2 дверь:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rastDver2
            // 
            this.rastDver2.Location = new System.Drawing.Point(669, 235);
            this.rastDver2.Name = "rastDver2";
            this.rastDver2.Size = new System.Drawing.Size(58, 20);
            this.rastDver2.TabIndex = 16;
            this.rastDver2.Text = "0";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(12, 235);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(428, 21);
            this.label10.TabIndex = 18;
            this.label10.Text = "Расстояние между дверью и предполагаемым местом установки ПУ в РУ 0,4 кВ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(13, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(193, 21);
            this.label11.TabIndex = 19;
            this.label11.Text = "Подсчет счетчиков:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(13, 261);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(193, 54);
            this.label12.TabIndex = 21;
            this.label12.Text = "Количество и вид счетчиков монтируемых в существующие шкафы:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // kolvoVidChetch
            // 
            this.kolvoVidChetch.AllowUserToAddRows = false;
            this.kolvoVidChetch.AllowUserToDeleteRows = false;
            this.kolvoVidChetch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kolvoVidChetch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.kolvoVidChetch.Location = new System.Drawing.Point(212, 261);
            this.kolvoVidChetch.Name = "kolvoVidChetch";
            this.kolvoVidChetch.Size = new System.Drawing.Size(515, 111);
            this.kolvoVidChetch.TabIndex = 20;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 172;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "1-й ввод";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 75;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "2-й ввод";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 75;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "3-й ввод";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 75;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "4-й ввод";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 75;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 26);
            this.label1.TabIndex = 23;
            this.label1.Text = "Типоразмер шкафов:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tiporazmerShkafov
            // 
            this.tiporazmerShkafov.AllowUserToAddRows = false;
            this.tiporazmerShkafov.AllowUserToDeleteRows = false;
            this.tiporazmerShkafov.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tiporazmerShkafov.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.tiporazmerShkafov.Location = new System.Drawing.Point(212, 378);
            this.tiporazmerShkafov.Name = "tiporazmerShkafov";
            this.tiporazmerShkafov.Size = new System.Drawing.Size(515, 111);
            this.tiporazmerShkafov.TabIndex = 22;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 172;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Шкаф-1";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 75;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Шкаф-2";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 75;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Шкаф-3";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 75;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Шкаф-4";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 75;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(13, 495);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(258, 20);
            this.label13.TabIndex = 25;
            this.label13.Text = "Среднее расстояние между пунктами учета; м.:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sredRastMdPU
            // 
            this.sredRastMdPU.Location = new System.Drawing.Point(277, 495);
            this.sredRastMdPU.Name = "sredRastMdPU";
            this.sredRastMdPU.Size = new System.Drawing.Size(35, 20);
            this.sredRastMdPU.TabIndex = 24;
            this.sredRastMdPU.Text = "0";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(330, 495);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(356, 20);
            this.label14.TabIndex = 27;
            this.label14.Text = "Тип монтажа (внутри РУ, снаружи РУ):";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(13, 521);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(258, 20);
            this.label15.TabIndex = 29;
            this.label15.Text = "Расстояние от ТТ до шкафа с мастер счетчиком:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rastTTdoShkafa
            // 
            this.rastTTdoShkafa.Location = new System.Drawing.Point(277, 520);
            this.rastTTdoShkafa.Name = "rastTTdoShkafa";
            this.rastTTdoShkafa.Size = new System.Drawing.Size(35, 20);
            this.rastTTdoShkafa.TabIndex = 28;
            this.rastTTdoShkafa.Text = "0";
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(330, 519);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(356, 20);
            this.label16.TabIndex = 31;
            this.label16.Text = "Расстояние от места установки ИБП до шкафа с мастер счетчиком:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rastOtMestaUstDoShkafa
            // 
            this.rastOtMestaUstDoShkafa.Location = new System.Drawing.Point(692, 522);
            this.rastOtMestaUstDoShkafa.Name = "rastOtMestaUstDoShkafa";
            this.rastOtMestaUstDoShkafa.Size = new System.Drawing.Size(35, 20);
            this.rastOtMestaUstDoShkafa.TabIndex = 30;
            this.rastOtMestaUstDoShkafa.Text = "0";
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(759, 36);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(190, 20);
            this.label17.TabIndex = 33;
            this.label17.Text = "3-ф счетчика прямого включения:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // f3ChetchPryamVkl
            // 
            this.f3ChetchPryamVkl.Location = new System.Drawing.Point(980, 36);
            this.f3ChetchPryamVkl.Name = "f3ChetchPryamVkl";
            this.f3ChetchPryamVkl.Size = new System.Drawing.Size(193, 20);
            this.f3ChetchPryamVkl.TabIndex = 32;
            this.f3ChetchPryamVkl.Text = "0";
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(759, 62);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(193, 20);
            this.label18.TabIndex = 35;
            this.label18.Text = "1-ф счетчика прямого включения:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // f1ChetchPryamVkl
            // 
            this.f1ChetchPryamVkl.Location = new System.Drawing.Point(980, 62);
            this.f1ChetchPryamVkl.Name = "f1ChetchPryamVkl";
            this.f1ChetchPryamVkl.Size = new System.Drawing.Size(193, 20);
            this.f1ChetchPryamVkl.TabIndex = 34;
            this.f1ChetchPryamVkl.Text = "0";
            // 
            // uzelNarachKabel
            // 
            this.uzelNarachKabel.AllowUserToAddRows = false;
            this.uzelNarachKabel.AllowUserToDeleteRows = false;
            this.uzelNarachKabel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uzelNarachKabel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.uzelNarachKabel.Location = new System.Drawing.Point(880, 88);
            this.uzelNarachKabel.Name = "uzelNarachKabel";
            this.uzelNarachKabel.Size = new System.Drawing.Size(293, 130);
            this.uzelNarachKabel.TabIndex = 36;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 150;
            // 
            // kolvoChetVShkafu
            // 
            this.kolvoChetVShkafu.AllowUserToAddRows = false;
            this.kolvoChetVShkafu.AllowUserToDeleteRows = false;
            this.kolvoChetVShkafu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kolvoChetVShkafu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.Column1});
            this.kolvoChetVShkafu.Location = new System.Drawing.Point(880, 261);
            this.kolvoChetVShkafu.Name = "kolvoChetVShkafu";
            this.kolvoChetVShkafu.Size = new System.Drawing.Size(293, 111);
            this.kolvoChetVShkafu.TabIndex = 37;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.HeaderText = "";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.HeaderText = "1-й ввод";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Width = 75;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "2-й ввод";
            this.Column1.Name = "Column1";
            this.Column1.Width = 75;
            // 
            // label21
            // 
            this.label21.Location = new System.Drawing.Point(759, 9);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(193, 20);
            this.label21.TabIndex = 42;
            this.label21.Text = "Длина кабеля для наращивания:";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label22
            // 
            this.label22.Location = new System.Drawing.Point(759, 89);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(115, 29);
            this.label22.TabIndex = 43;
            this.label22.Text = "Узел наращивания кабеля:";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label24
            // 
            this.label24.Location = new System.Drawing.Point(759, 261);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(115, 54);
            this.label24.TabIndex = 46;
            this.label24.Text = "Количество счетчиков в новом шкафу:";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(759, 410);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(193, 20);
            this.label19.TabIndex = 50;
            this.label19.Text = "Зажим для наращивания; шт.:";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // zazhimDlyNarach
            // 
            this.zazhimDlyNarach.Location = new System.Drawing.Point(980, 410);
            this.zazhimDlyNarach.Name = "zazhimDlyNarach";
            this.zazhimDlyNarach.Size = new System.Drawing.Size(193, 20);
            this.zazhimDlyNarach.TabIndex = 49;
            this.zazhimDlyNarach.Text = "0";
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(759, 384);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(190, 20);
            this.label20.TabIndex = 48;
            this.label20.Text = "Кабель для наращивания; м.:";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // kabelDlyaNarach
            // 
            this.kabelDlyaNarach.Location = new System.Drawing.Point(980, 384);
            this.kabelDlyaNarach.Name = "kabelDlyaNarach";
            this.kabelDlyaNarach.Size = new System.Drawing.Size(193, 20);
            this.kabelDlyaNarach.TabIndex = 47;
            this.kabelDlyaNarach.Text = "0";
            // 
            // svaya
            // 
            this.svaya.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.svaya.Location = new System.Drawing.Point(1099, 235);
            this.svaya.Name = "svaya";
            this.svaya.Size = new System.Drawing.Size(74, 21);
            this.svaya.TabIndex = 51;
            this.svaya.Text = "Свая:";
            this.svaya.UseVisualStyleBackColor = true;
            // 
            // tipMontazha
            // 
            this.tipMontazha.FormattingEnabled = true;
            this.tipMontazha.Location = new System.Drawing.Point(608, 494);
            this.tipMontazha.Name = "tipMontazha";
            this.tipMontazha.Size = new System.Drawing.Size(119, 21);
            this.tipMontazha.TabIndex = 52;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonCompute);
            this.groupBox1.Controls.Add(this.buttonSelectFolder);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.folderName);
            this.groupBox1.Location = new System.Drawing.Point(762, 436);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 103);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            // 
            // buttonCompute
            // 
            this.buttonCompute.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCompute.Image = global::SmartCalc.Properties.Resources.Calculator_2_icon;
            this.buttonCompute.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCompute.Location = new System.Drawing.Point(162, 48);
            this.buttonCompute.Name = "buttonCompute";
            this.buttonCompute.Size = new System.Drawing.Size(243, 38);
            this.buttonCompute.TabIndex = 54;
            this.buttonCompute.Text = "Добавить расчет в спецификации";
            this.buttonCompute.UseVisualStyleBackColor = true;
            this.buttonCompute.Click += new System.EventHandler(this.ButtonCompute_Click);
            // 
            // buttonSelectFolder
            // 
            this.buttonSelectFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSelectFolder.Location = new System.Drawing.Point(382, 16);
            this.buttonSelectFolder.Name = "buttonSelectFolder";
            this.buttonSelectFolder.Size = new System.Drawing.Size(23, 20);
            this.buttonSelectFolder.TabIndex = 53;
            this.buttonSelectFolder.Text = "...";
            this.buttonSelectFolder.UseVisualStyleBackColor = true;
            this.buttonSelectFolder.Click += new System.EventHandler(this.ButtonSelectFolder_Click);
            // 
            // label23
            // 
            this.label23.Location = new System.Drawing.Point(6, 16);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(45, 20);
            this.label23.TabIndex = 52;
            this.label23.Text = "Папка:";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // folderName
            // 
            this.folderName.Location = new System.Drawing.Point(57, 16);
            this.folderName.Name = "folderName";
            this.folderName.Size = new System.Drawing.Size(318, 20);
            this.folderName.TabIndex = 51;
            // 
            // label25
            // 
            this.label25.Location = new System.Drawing.Point(457, 35);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(71, 21);
            this.label25.TabIndex = 55;
            this.label25.Text = "Филиал:";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // filial
            // 
            this.filial.FormattingEnabled = true;
            this.filial.Location = new System.Drawing.Point(534, 35);
            this.filial.Name = "filial";
            this.filial.Size = new System.Drawing.Size(193, 21);
            this.filial.TabIndex = 54;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 554);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.filial);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tipMontazha);
            this.Controls.Add(this.svaya);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.zazhimDlyNarach);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.kabelDlyaNarach);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.kolvoChetVShkafu);
            this.Controls.Add(this.uzelNarachKabel);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.f1ChetchPryamVkl);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.f3ChetchPryamVkl);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.rastOtMestaUstDoShkafa);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.rastTTdoShkafa);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.sredRastMdPU);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tiporazmerShkafov);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.kolvoVidChetch);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.rastDver2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rastDver1);
            this.Controls.Add(this.podchChet);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.podryad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataOtkl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.month);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tipRU);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nomerTP);
            this.Controls.Add(this.res);
            this.Name = "Form1";
            this.Text = "unknown version";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.podchChet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kolvoVidChetch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiporazmerShkafov)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uzelNarachKabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kolvoChetVShkafu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox res;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.MaskedTextBox nomerTP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox tipRU;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox month;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.MaskedTextBox dataOtkl;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox podryad;
        public System.Windows.Forms.DataGridView podchChet;
        private System.Windows.Forms.DataGridViewTextBoxColumn StringName;
        private System.Windows.Forms.DataGridViewTextBoxColumn vvod1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vvod2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vvod3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vvod4;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.MaskedTextBox rastDver1;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.MaskedTextBox rastDver2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.DataGridView kolvoVidChetch;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView tiporazmerShkafov;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.MaskedTextBox sredRastMdPU;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.MaskedTextBox rastTTdoShkafa;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.MaskedTextBox rastOtMestaUstDoShkafa;
        private System.Windows.Forms.Label label17;
        public System.Windows.Forms.MaskedTextBox f3ChetchPryamVkl;
        private System.Windows.Forms.Label label18;
        public System.Windows.Forms.MaskedTextBox f1ChetchPryamVkl;
        public System.Windows.Forms.DataGridView uzelNarachKabel;
        public System.Windows.Forms.DataGridView kolvoChetVShkafu;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label19;
        public System.Windows.Forms.MaskedTextBox zazhimDlyNarach;
        private System.Windows.Forms.Label label20;
        public System.Windows.Forms.MaskedTextBox kabelDlyaNarach;
        public System.Windows.Forms.CheckBox svaya;
        public System.Windows.Forms.ComboBox tipMontazha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonCompute;
        private System.Windows.Forms.Button buttonSelectFolder;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.MaskedTextBox folderName;
        private System.Windows.Forms.Label label25;
        public System.Windows.Forms.ComboBox filial;
    }
}

