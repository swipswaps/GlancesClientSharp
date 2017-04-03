namespace GlancesClientSharp
{
    partial class frmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblCpu = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNetUp = new System.Windows.Forms.Label();
            this.lblNetDown = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblRam = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.grpNetUp = new GlancesClientSharp.UI.Graph();
            this.grpNetDown = new GlancesClientSharp.UI.Graph();
            this.grpRam = new GlancesClientSharp.UI.Graph();
            this.grpCpu = new GlancesClientSharp.UI.Graph();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1000 = new System.Windows.Forms.Label();
            this.lblHost = new System.Windows.Forms.Label();
            this.lblIp = new System.Windows.Forms.Label();
            this.lblUptime = new System.Windows.Forms.Label();
            this.lblCovered = new System.Windows.Forms.Label();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "CPU";
            // 
            // lblCpu
            // 
            this.lblCpu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCpu.AutoSize = true;
            this.lblCpu.Location = new System.Drawing.Point(86, 8);
            this.lblCpu.Margin = new System.Windows.Forms.Padding(3);
            this.lblCpu.Name = "lblCpu";
            this.lblCpu.Size = new System.Drawing.Size(18, 13);
            this.lblCpu.TabIndex = 1;
            this.lblCpu.Text = "-%";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.grpRam, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.grpCpu, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(136, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(893, 126);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel4.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel7, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(1, 65);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(107, 60);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.Location = new System.Drawing.Point(3, 23);
            this.label6.Margin = new System.Windows.Forms.Padding(3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "NET";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel7.AutoSize = true;
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.lblNetUp, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.lblNetDown, 0, 1);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(35, 0);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(72, 60);
            this.tableLayoutPanel7.TabIndex = 2;
            // 
            // lblNetUp
            // 
            this.lblNetUp.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNetUp.AutoSize = true;
            this.lblNetUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblNetUp.Location = new System.Drawing.Point(36, 13);
            this.lblNetUp.Margin = new System.Windows.Forms.Padding(3);
            this.lblNetUp.Name = "lblNetUp";
            this.lblNetUp.Size = new System.Drawing.Size(33, 13);
            this.lblNetUp.TabIndex = 1;
            this.lblNetUp.Text = "˄ -XB";
            // 
            // lblNetDown
            // 
            this.lblNetDown.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNetDown.AutoSize = true;
            this.lblNetDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblNetDown.Location = new System.Drawing.Point(36, 43);
            this.lblNetDown.Margin = new System.Windows.Forms.Padding(3);
            this.lblNetDown.Name = "lblNetDown";
            this.lblNetDown.Size = new System.Drawing.Size(33, 13);
            this.lblNetDown.TabIndex = 1;
            this.lblNetDown.Text = "˅ -XB";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblRam, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(1, 33);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(107, 30);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // lblRam
            // 
            this.lblRam.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblRam.AutoSize = true;
            this.lblRam.Location = new System.Drawing.Point(60, 8);
            this.lblRam.Margin = new System.Windows.Forms.Padding(3);
            this.lblRam.Name = "lblRam";
            this.lblRam.Size = new System.Drawing.Size(44, 13);
            this.lblRam.TabIndex = 1;
            this.lblRam.Text = "-XB (-%)";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(3, 8);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "RAM";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblCpu, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1, 1);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(107, 30);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.AutoSize = true;
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.grpNetUp, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.grpNetDown, 0, 1);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(109, 64);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(784, 62);
            this.tableLayoutPanel6.TabIndex = 6;
            // 
            // grpNetUp
            // 
            this.grpNetUp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpNetUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(77)))), ((int)(((byte)(74)))));
            this.grpNetUp.DynamicMaximum = true;
            this.grpNetUp.ForeColor = System.Drawing.Color.White;
            this.grpNetUp.Invert = false;
            this.grpNetUp.Location = new System.Drawing.Point(1, 1);
            this.grpNetUp.Margin = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.grpNetUp.Maximum = 100F;
            this.grpNetUp.Minimum = 1000000F;
            this.grpNetUp.Name = "grpNetUp";
            this.grpNetUp.Size = new System.Drawing.Size(782, 30);
            this.grpNetUp.TabIndex = 0;
            this.grpNetUp.SizeChanged += new System.EventHandler(this.grpCpu_SizeChanged);
            // 
            // grpNetDown
            // 
            this.grpNetDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpNetDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(77)))), ((int)(((byte)(74)))));
            this.grpNetDown.DynamicMaximum = true;
            this.grpNetDown.ForeColor = System.Drawing.Color.White;
            this.grpNetDown.Invert = true;
            this.grpNetDown.Location = new System.Drawing.Point(1, 31);
            this.grpNetDown.Margin = new System.Windows.Forms.Padding(1, 0, 1, 1);
            this.grpNetDown.Maximum = 100F;
            this.grpNetDown.Minimum = 1000000F;
            this.grpNetDown.Name = "grpNetDown";
            this.grpNetDown.Size = new System.Drawing.Size(782, 30);
            this.grpNetDown.TabIndex = 0;
            this.grpNetDown.SizeChanged += new System.EventHandler(this.grpCpu_SizeChanged);
            // 
            // grpRam
            // 
            this.grpRam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpRam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(77)))), ((int)(((byte)(74)))));
            this.grpRam.DynamicMaximum = false;
            this.grpRam.ForeColor = System.Drawing.Color.White;
            this.grpRam.Invert = false;
            this.grpRam.Location = new System.Drawing.Point(110, 33);
            this.grpRam.Margin = new System.Windows.Forms.Padding(1);
            this.grpRam.Maximum = 100F;
            this.grpRam.Minimum = 0F;
            this.grpRam.Name = "grpRam";
            this.grpRam.Size = new System.Drawing.Size(782, 30);
            this.grpRam.TabIndex = 0;
            this.grpRam.SizeChanged += new System.EventHandler(this.grpCpu_SizeChanged);
            // 
            // grpCpu
            // 
            this.grpCpu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpCpu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(77)))), ((int)(((byte)(74)))));
            this.grpCpu.DynamicMaximum = false;
            this.grpCpu.ForeColor = System.Drawing.Color.White;
            this.grpCpu.Invert = false;
            this.grpCpu.Location = new System.Drawing.Point(110, 1);
            this.grpCpu.Margin = new System.Windows.Forms.Padding(1);
            this.grpCpu.Maximum = 100F;
            this.grpCpu.Minimum = 0F;
            this.grpCpu.Name = "grpCpu";
            this.grpCpu.Size = new System.Drawing.Size(782, 30);
            this.grpCpu.TabIndex = 0;
            this.grpCpu.SizeChanged += new System.EventHandler(this.grpCpu_SizeChanged);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel5.AutoSize = true;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.label1000, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.lblHost, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.lblIp, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.lblUptime, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.lblCovered, 1, 3);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 4;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(136, 78);
            this.tableLayoutPanel5.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Host:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 22);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "IP:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 41);
            this.label7.Margin = new System.Windows.Forms.Padding(3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Uptime:";
            // 
            // label1000
            // 
            this.label1000.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1000.AutoSize = true;
            this.label1000.Location = new System.Drawing.Point(3, 61);
            this.label1000.Margin = new System.Windows.Forms.Padding(3);
            this.label1000.Name = "label1000";
            this.label1000.Size = new System.Drawing.Size(75, 13);
            this.label1000.TabIndex = 7;
            this.label1000.Text = "Time covered:";
            // 
            // lblHost
            // 
            this.lblHost.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHost.AutoSize = true;
            this.lblHost.Location = new System.Drawing.Point(84, 3);
            this.lblHost.Margin = new System.Windows.Forms.Padding(3);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(10, 13);
            this.lblHost.TabIndex = 7;
            this.lblHost.Text = "-";
            // 
            // lblIp
            // 
            this.lblIp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblIp.AutoSize = true;
            this.lblIp.Location = new System.Drawing.Point(84, 22);
            this.lblIp.Margin = new System.Windows.Forms.Padding(3);
            this.lblIp.Name = "lblIp";
            this.lblIp.Size = new System.Drawing.Size(28, 13);
            this.lblIp.TabIndex = 7;
            this.lblIp.Text = "-.-.-.-";
            // 
            // lblUptime
            // 
            this.lblUptime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUptime.AutoSize = true;
            this.lblUptime.Location = new System.Drawing.Point(84, 41);
            this.lblUptime.Margin = new System.Windows.Forms.Padding(3);
            this.lblUptime.Name = "lblUptime";
            this.lblUptime.Size = new System.Drawing.Size(49, 13);
            this.lblUptime.TabIndex = 7;
            this.lblUptime.Text = "00:00:00";
            // 
            // lblCovered
            // 
            this.lblCovered.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCovered.AutoSize = true;
            this.lblCovered.Location = new System.Drawing.Point(84, 61);
            this.lblCovered.Margin = new System.Windows.Forms.Padding(3);
            this.lblCovered.Name = "lblCovered";
            this.lblCovered.Size = new System.Drawing.Size(49, 13);
            this.lblCovered.TabIndex = 7;
            this.lblCovered.Text = "00:00:00";
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.AutoSize = true;
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel8.Size = new System.Drawing.Size(1035, 0);
            this.tableLayoutPanel8.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.tableLayoutPanel9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1035, 131);
            this.panel1.TabIndex = 10;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.AutoSize = true;
            this.tableLayoutPanel9.ColumnCount = 2;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel9.Size = new System.Drawing.Size(1029, 126);
            this.tableLayoutPanel9.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1035, 131);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel8);
            this.Name = "frmMain";
            this.Text = "GlancesClientSharp";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private UI.Graph grpCpu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCpu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblRam;
        private System.Windows.Forms.Label label4;
        private UI.Graph grpRam;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private UI.Graph grpNetUp;
        private UI.Graph grpNetDown;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label lblNetUp;
        private System.Windows.Forms.Label lblNetDown;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1000;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.Label lblIp;
        private System.Windows.Forms.Label lblUptime;
        private System.Windows.Forms.Label lblCovered;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
    }
}

