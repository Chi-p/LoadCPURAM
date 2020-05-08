namespace Load_CPU_RAM
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblTotalRAM = new System.Windows.Forms.Label();
            this.lblTotalRAMValue = new System.Windows.Forms.Label();
            this.lblUsedFreeRAM = new System.Windows.Forms.Label();
            this.prgUsedFreeRAM = new System.Windows.Forms.ProgressBar();
            this.lblUsedFreeRAMValue = new System.Windows.Forms.Label();
            this.grpRAM = new System.Windows.Forms.GroupBox();
            this.lblPoolSize = new System.Windows.Forms.Label();
            this.btnPauseFillRAM = new System.Windows.Forms.Button();
            this.lblPoolSizeText = new System.Windows.Forms.Label();
            this.btnFillRAM = new System.Windows.Forms.Button();
            this.btnFreeRAM = new System.Windows.Forms.Button();
            this.lblFillRateUnit = new System.Windows.Forms.Label();
            this.lblSizeUnit = new System.Windows.Forms.Label();
            this.lblFillRate = new System.Windows.Forms.Label();
            this.nudFillRateValue = new System.Windows.Forms.NumericUpDown();
            this.lblReservedRAM = new System.Windows.Forms.Label();
            this.nudReservedRAMValue = new System.Windows.Forms.NumericUpDown();
            this.tmrCheckRAMSizeAndCPULoad = new System.Windows.Forms.Timer(this.components);
            this.grpCPU = new System.Windows.Forms.GroupBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblStressRateUnit = new System.Windows.Forms.Label();
            this.lblStressRate = new System.Windows.Forms.Label();
            this.nudStressRateValue = new System.Windows.Forms.NumericUpDown();
            this.lblReservedCore = new System.Windows.Forms.Label();
            this.nudReservedCoreValue = new System.Windows.Forms.NumericUpDown();
            this.lblTotalCore = new System.Windows.Forms.Label();
            this.lblUsedCoreValue = new System.Windows.Forms.Label();
            this.lblTotalCoreValue = new System.Windows.Forms.Label();
            this.prgUsedCore = new System.Windows.Forms.ProgressBar();
            this.lblUsedCore = new System.Windows.Forms.Label();
            this.grpRAM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFillRateValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudReservedRAMValue)).BeginInit();
            this.grpCPU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStressRateValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudReservedCoreValue)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotalRAM
            // 
            this.lblTotalRAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotalRAM.Location = new System.Drawing.Point(6, 20);
            this.lblTotalRAM.Name = "lblTotalRAM";
            this.lblTotalRAM.Size = new System.Drawing.Size(211, 18);
            this.lblTotalRAM.TabIndex = 1;
            this.lblTotalRAM.Text = "Доступно памяти в системе:";
            // 
            // lblTotalRAMValue
            // 
            this.lblTotalRAMValue.AutoSize = true;
            this.lblTotalRAMValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotalRAMValue.Location = new System.Drawing.Point(223, 15);
            this.lblTotalRAMValue.Name = "lblTotalRAMValue";
            this.lblTotalRAMValue.Size = new System.Drawing.Size(63, 26);
            this.lblTotalRAMValue.TabIndex = 2;
            this.lblTotalRAMValue.Text = "-- ГБ";
            // 
            // lblUsedFreeRAM
            // 
            this.lblUsedFreeRAM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsedFreeRAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUsedFreeRAM.Location = new System.Drawing.Point(6, 52);
            this.lblUsedFreeRAM.Name = "lblUsedFreeRAM";
            this.lblUsedFreeRAM.Size = new System.Drawing.Size(280, 30);
            this.lblUsedFreeRAM.TabIndex = 3;
            this.lblUsedFreeRAM.Text = "Занято / Cвободно";
            this.lblUsedFreeRAM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUsedFreeRAM.Click += new System.EventHandler(this.lblUsedFreeRAM_Click);
            // 
            // prgUsedFreeRAM
            // 
            this.prgUsedFreeRAM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prgUsedFreeRAM.Location = new System.Drawing.Point(6, 85);
            this.prgUsedFreeRAM.Name = "prgUsedFreeRAM";
            this.prgUsedFreeRAM.Size = new System.Drawing.Size(280, 23);
            this.prgUsedFreeRAM.TabIndex = 4;
            // 
            // lblUsedFreeRAMValue
            // 
            this.lblUsedFreeRAMValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsedFreeRAMValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUsedFreeRAMValue.Location = new System.Drawing.Point(6, 111);
            this.lblUsedFreeRAMValue.Name = "lblUsedFreeRAMValue";
            this.lblUsedFreeRAMValue.Size = new System.Drawing.Size(280, 36);
            this.lblUsedFreeRAMValue.TabIndex = 5;
            this.lblUsedFreeRAMValue.Text = "-- %";
            this.lblUsedFreeRAMValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUsedFreeRAMValue.Click += new System.EventHandler(this.lblUsedFreeRAMValue_Click);
            // 
            // grpRAM
            // 
            this.grpRAM.Controls.Add(this.lblPoolSize);
            this.grpRAM.Controls.Add(this.btnPauseFillRAM);
            this.grpRAM.Controls.Add(this.lblPoolSizeText);
            this.grpRAM.Controls.Add(this.btnFillRAM);
            this.grpRAM.Controls.Add(this.btnFreeRAM);
            this.grpRAM.Controls.Add(this.lblFillRateUnit);
            this.grpRAM.Controls.Add(this.lblSizeUnit);
            this.grpRAM.Controls.Add(this.lblFillRate);
            this.grpRAM.Controls.Add(this.nudFillRateValue);
            this.grpRAM.Controls.Add(this.lblReservedRAM);
            this.grpRAM.Controls.Add(this.nudReservedRAMValue);
            this.grpRAM.Controls.Add(this.lblTotalRAM);
            this.grpRAM.Controls.Add(this.lblUsedFreeRAMValue);
            this.grpRAM.Controls.Add(this.lblTotalRAMValue);
            this.grpRAM.Controls.Add(this.prgUsedFreeRAM);
            this.grpRAM.Controls.Add(this.lblUsedFreeRAM);
            this.grpRAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grpRAM.Location = new System.Drawing.Point(12, 12);
            this.grpRAM.Name = "grpRAM";
            this.grpRAM.Size = new System.Drawing.Size(635, 163);
            this.grpRAM.TabIndex = 6;
            this.grpRAM.TabStop = false;
            this.grpRAM.Text = "ОЗУ";
            // 
            // lblPoolSize
            // 
            this.lblPoolSize.AutoSize = true;
            this.lblPoolSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPoolSize.ForeColor = System.Drawing.Color.Green;
            this.lblPoolSize.Location = new System.Drawing.Point(187, 145);
            this.lblPoolSize.Name = "lblPoolSize";
            this.lblPoolSize.Size = new System.Drawing.Size(15, 15);
            this.lblPoolSize.TabIndex = 9;
            this.lblPoolSize.Text = "0";
            this.lblPoolSize.Visible = false;
            // 
            // btnPauseFillRAM
            // 
            this.btnPauseFillRAM.BackColor = System.Drawing.Color.Yellow;
            this.btnPauseFillRAM.Location = new System.Drawing.Point(433, 97);
            this.btnPauseFillRAM.Name = "btnPauseFillRAM";
            this.btnPauseFillRAM.Size = new System.Drawing.Size(75, 48);
            this.btnPauseFillRAM.TabIndex = 11;
            this.btnPauseFillRAM.Text = "Пауза";
            this.btnPauseFillRAM.UseVisualStyleBackColor = false;
            this.btnPauseFillRAM.Click += new System.EventHandler(this.btnPauseFillRAM_Click);
            // 
            // lblPoolSizeText
            // 
            this.lblPoolSizeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPoolSizeText.ForeColor = System.Drawing.Color.Green;
            this.lblPoolSizeText.Location = new System.Drawing.Point(3, 142);
            this.lblPoolSizeText.Name = "lblPoolSizeText";
            this.lblPoolSizeText.Size = new System.Drawing.Size(179, 18);
            this.lblPoolSizeText.TabIndex = 8;
            this.lblPoolSizeText.Text = "Текущий размер списка:";
            this.lblPoolSizeText.Visible = false;
            // 
            // btnFillRAM
            // 
            this.btnFillRAM.BackColor = System.Drawing.Color.Coral;
            this.btnFillRAM.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFillRAM.Location = new System.Drawing.Point(310, 97);
            this.btnFillRAM.Name = "btnFillRAM";
            this.btnFillRAM.Size = new System.Drawing.Size(115, 48);
            this.btnFillRAM.TabIndex = 10;
            this.btnFillRAM.Text = "Заполнить";
            this.btnFillRAM.UseVisualStyleBackColor = false;
            this.btnFillRAM.Click += new System.EventHandler(this.btnFillRAM_Click);
            // 
            // btnFreeRAM
            // 
            this.btnFreeRAM.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnFreeRAM.Location = new System.Drawing.Point(515, 97);
            this.btnFreeRAM.Name = "btnFreeRAM";
            this.btnFreeRAM.Size = new System.Drawing.Size(114, 48);
            this.btnFreeRAM.TabIndex = 9;
            this.btnFreeRAM.Text = "Освободить";
            this.btnFreeRAM.UseVisualStyleBackColor = false;
            this.btnFreeRAM.Click += new System.EventHandler(this.btnFreeRAM_Click);
            // 
            // lblFillRateUnit
            // 
            this.lblFillRateUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFillRateUnit.Location = new System.Drawing.Point(572, 53);
            this.lblFillRateUnit.Name = "lblFillRateUnit";
            this.lblFillRateUnit.Size = new System.Drawing.Size(47, 22);
            this.lblFillRateUnit.TabIndex = 8;
            this.lblFillRateUnit.Text = "МБ/с";
            this.lblFillRateUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSizeUnit
            // 
            this.lblSizeUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSizeUnit.Location = new System.Drawing.Point(571, 20);
            this.lblSizeUnit.Name = "lblSizeUnit";
            this.lblSizeUnit.Size = new System.Drawing.Size(48, 22);
            this.lblSizeUnit.TabIndex = 8;
            this.lblSizeUnit.Text = "МБ";
            this.lblSizeUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFillRate
            // 
            this.lblFillRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFillRate.Location = new System.Drawing.Point(316, 52);
            this.lblFillRate.Name = "lblFillRate";
            this.lblFillRate.Size = new System.Drawing.Size(162, 23);
            this.lblFillRate.TabIndex = 7;
            this.lblFillRate.Text = "Скорость заполнения";
            this.lblFillRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudFillRateValue
            // 
            this.nudFillRateValue.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudFillRateValue.Location = new System.Drawing.Point(480, 51);
            this.nudFillRateValue.Maximum = new decimal(new int[] {
            1048576,
            0,
            0,
            0});
            this.nudFillRateValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFillRateValue.Name = "nudFillRateValue";
            this.nudFillRateValue.Size = new System.Drawing.Size(90, 24);
            this.nudFillRateValue.TabIndex = 6;
            this.nudFillRateValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudFillRateValue.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudFillRateValue.ValueChanged += new System.EventHandler(this.nudFillRateValue_ValueChanged);
            // 
            // lblReservedRAM
            // 
            this.lblReservedRAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblReservedRAM.Location = new System.Drawing.Point(319, 19);
            this.lblReservedRAM.Name = "lblReservedRAM";
            this.lblReservedRAM.Size = new System.Drawing.Size(155, 23);
            this.lblReservedRAM.TabIndex = 7;
            this.lblReservedRAM.Text = "Зарезервировать";
            this.lblReservedRAM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudReservedRAMValue
            // 
            this.nudReservedRAMValue.BackColor = System.Drawing.Color.PaleGreen;
            this.nudReservedRAMValue.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudReservedRAMValue.Location = new System.Drawing.Point(480, 18);
            this.nudReservedRAMValue.Maximum = new decimal(new int[] {
            3145728,
            0,
            0,
            0});
            this.nudReservedRAMValue.Name = "nudReservedRAMValue";
            this.nudReservedRAMValue.Size = new System.Drawing.Size(90, 24);
            this.nudReservedRAMValue.TabIndex = 6;
            this.nudReservedRAMValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudReservedRAMValue.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudReservedRAMValue.ValueChanged += new System.EventHandler(this.nudReservedRAMValue_ValueChanged);
            // 
            // tmrCheckRAMSizeAndCPULoad
            // 
            this.tmrCheckRAMSizeAndCPULoad.Enabled = true;
            this.tmrCheckRAMSizeAndCPULoad.Interval = 1000;
            this.tmrCheckRAMSizeAndCPULoad.Tick += new System.EventHandler(this.tmrCheckRAMSizeAndCPULoad_Tick);
            // 
            // grpCPU
            // 
            this.grpCPU.Controls.Add(this.btnStart);
            this.grpCPU.Controls.Add(this.btnStop);
            this.grpCPU.Controls.Add(this.lblStressRateUnit);
            this.grpCPU.Controls.Add(this.lblStressRate);
            this.grpCPU.Controls.Add(this.nudStressRateValue);
            this.grpCPU.Controls.Add(this.lblReservedCore);
            this.grpCPU.Controls.Add(this.nudReservedCoreValue);
            this.grpCPU.Controls.Add(this.lblTotalCore);
            this.grpCPU.Controls.Add(this.lblUsedCoreValue);
            this.grpCPU.Controls.Add(this.lblTotalCoreValue);
            this.grpCPU.Controls.Add(this.prgUsedCore);
            this.grpCPU.Controls.Add(this.lblUsedCore);
            this.grpCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grpCPU.Location = new System.Drawing.Point(12, 191);
            this.grpCPU.Name = "grpCPU";
            this.grpCPU.Size = new System.Drawing.Size(635, 163);
            this.grpCPU.TabIndex = 7;
            this.grpCPU.TabStop = false;
            this.grpCPU.Text = "ЦП";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Coral;
            this.btnStart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStart.Location = new System.Drawing.Point(312, 85);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(150, 60);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "Запустить стресс-тест";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Lime;
            this.btnStop.Location = new System.Drawing.Point(479, 85);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(149, 60);
            this.btnStop.TabIndex = 9;
            this.btnStop.Text = "Остановить стресс-тест";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblStressRateUnit
            // 
            this.lblStressRateUnit.Enabled = false;
            this.lblStressRateUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStressRateUnit.Location = new System.Drawing.Point(572, 53);
            this.lblStressRateUnit.Name = "lblStressRateUnit";
            this.lblStressRateUnit.Size = new System.Drawing.Size(47, 22);
            this.lblStressRateUnit.TabIndex = 8;
            this.lblStressRateUnit.Text = "%";
            this.lblStressRateUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStressRate
            // 
            this.lblStressRate.Enabled = false;
            this.lblStressRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStressRate.Location = new System.Drawing.Point(316, 52);
            this.lblStressRate.Name = "lblStressRate";
            this.lblStressRate.Size = new System.Drawing.Size(162, 23);
            this.lblStressRate.TabIndex = 7;
            this.lblStressRate.Text = "Величина нагрузки";
            this.lblStressRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudStressRateValue
            // 
            this.nudStressRateValue.Enabled = false;
            this.nudStressRateValue.Location = new System.Drawing.Point(480, 51);
            this.nudStressRateValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudStressRateValue.Name = "nudStressRateValue";
            this.nudStressRateValue.Size = new System.Drawing.Size(90, 24);
            this.nudStressRateValue.TabIndex = 6;
            this.nudStressRateValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudStressRateValue.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudStressRateValue.ValueChanged += new System.EventHandler(this.nudStressRateValue_ValueChanged);
            // 
            // lblReservedCore
            // 
            this.lblReservedCore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblReservedCore.Location = new System.Drawing.Point(301, 19);
            this.lblReservedCore.Name = "lblReservedCore";
            this.lblReservedCore.Size = new System.Drawing.Size(173, 23);
            this.lblReservedCore.TabIndex = 7;
            this.lblReservedCore.Text = "Зарезервировать ядер";
            this.lblReservedCore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudReservedCoreValue
            // 
            this.nudReservedCoreValue.BackColor = System.Drawing.Color.PaleGreen;
            this.nudReservedCoreValue.Location = new System.Drawing.Point(480, 18);
            this.nudReservedCoreValue.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudReservedCoreValue.Name = "nudReservedCoreValue";
            this.nudReservedCoreValue.Size = new System.Drawing.Size(90, 24);
            this.nudReservedCoreValue.TabIndex = 6;
            this.nudReservedCoreValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudReservedCoreValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudReservedCoreValue.ValueChanged += new System.EventHandler(this.nudReservedCoreValue_ValueChanged);
            // 
            // lblTotalCore
            // 
            this.lblTotalCore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotalCore.Location = new System.Drawing.Point(6, 20);
            this.lblTotalCore.Name = "lblTotalCore";
            this.lblTotalCore.Size = new System.Drawing.Size(196, 18);
            this.lblTotalCore.TabIndex = 1;
            this.lblTotalCore.Text = "Доступно ядер в системе:";
            // 
            // lblUsedCoreValue
            // 
            this.lblUsedCoreValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsedCoreValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUsedCoreValue.Location = new System.Drawing.Point(6, 111);
            this.lblUsedCoreValue.Name = "lblUsedCoreValue";
            this.lblUsedCoreValue.Size = new System.Drawing.Size(280, 36);
            this.lblUsedCoreValue.TabIndex = 5;
            this.lblUsedCoreValue.Text = "-- %";
            this.lblUsedCoreValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalCoreValue
            // 
            this.lblTotalCoreValue.AutoSize = true;
            this.lblTotalCoreValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotalCoreValue.Location = new System.Drawing.Point(198, 15);
            this.lblTotalCoreValue.Name = "lblTotalCoreValue";
            this.lblTotalCoreValue.Size = new System.Drawing.Size(28, 26);
            this.lblTotalCoreValue.TabIndex = 2;
            this.lblTotalCoreValue.Text = "--";
            // 
            // prgUsedCore
            // 
            this.prgUsedCore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prgUsedCore.Location = new System.Drawing.Point(6, 85);
            this.prgUsedCore.Name = "prgUsedCore";
            this.prgUsedCore.Size = new System.Drawing.Size(280, 23);
            this.prgUsedCore.TabIndex = 4;
            // 
            // lblUsedCore
            // 
            this.lblUsedCore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsedCore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUsedCore.Location = new System.Drawing.Point(6, 52);
            this.lblUsedCore.Name = "lblUsedCore";
            this.lblUsedCore.Size = new System.Drawing.Size(280, 30);
            this.lblUsedCore.TabIndex = 3;
            this.lblUsedCore.Text = "Общая загрузка ЦП";
            this.lblUsedCore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 362);
            this.Controls.Add(this.grpCPU);
            this.Controls.Add(this.grpRAM);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Тест нагрузки ЦП и ОЗУ";
            this.grpRAM.ResumeLayout(false);
            this.grpRAM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFillRateValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudReservedRAMValue)).EndInit();
            this.grpCPU.ResumeLayout(false);
            this.grpCPU.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStressRateValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudReservedCoreValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTotalRAM;
        private System.Windows.Forms.Label lblTotalRAMValue;
        private System.Windows.Forms.Label lblUsedFreeRAM;
        private System.Windows.Forms.ProgressBar prgUsedFreeRAM;
        private System.Windows.Forms.Label lblUsedFreeRAMValue;
        private System.Windows.Forms.GroupBox grpRAM;
        private System.Windows.Forms.Button btnFillRAM;
        private System.Windows.Forms.Button btnFreeRAM;
        private System.Windows.Forms.Label lblSizeUnit;
        private System.Windows.Forms.Label lblReservedRAM;
        private System.Windows.Forms.NumericUpDown nudReservedRAMValue;
        private System.Windows.Forms.Label lblFillRateUnit;
        private System.Windows.Forms.Label lblFillRate;
        private System.Windows.Forms.NumericUpDown nudFillRateValue;
        private System.Windows.Forms.Button btnPauseFillRAM;
        private System.Windows.Forms.Timer tmrCheckRAMSizeAndCPULoad;
        private System.Windows.Forms.Label lblPoolSize;
        private System.Windows.Forms.Label lblPoolSizeText;
        private System.Windows.Forms.GroupBox grpCPU;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblStressRateUnit;
        private System.Windows.Forms.Label lblStressRate;
        private System.Windows.Forms.NumericUpDown nudStressRateValue;
        private System.Windows.Forms.Label lblReservedCore;
        private System.Windows.Forms.NumericUpDown nudReservedCoreValue;
        private System.Windows.Forms.Label lblTotalCore;
        private System.Windows.Forms.Label lblUsedCoreValue;
        private System.Windows.Forms.Label lblTotalCoreValue;
        private System.Windows.Forms.ProgressBar prgUsedCore;
        private System.Windows.Forms.Label lblUsedCore;
    }
}

