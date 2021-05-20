
namespace KreditSimulator
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
            this.lCredit = new System.Windows.Forms.Label();
            this.numupdownCredit = new System.Windows.Forms.NumericUpDown();
            this.numupdownInstalment = new System.Windows.Forms.NumericUpDown();
            this.lInstalment = new System.Windows.Forms.Label();
            this.numupdownRate = new System.Windows.Forms.NumericUpDown();
            this.lRate = new System.Windows.Forms.Label();
            this.savedialog = new System.Windows.Forms.SaveFileDialog();
            this.gboxCredit = new System.Windows.Forms.GroupBox();
            this.gboxRandomness = new System.Windows.Forms.GroupBox();
            this.trackbarRandomnessRate = new System.Windows.Forms.TrackBar();
            this.lRandomnessRate = new System.Windows.Forms.Label();
            this.bSimulateExport = new System.Windows.Forms.Button();
            this.gboxSimulation = new System.Windows.Forms.GroupBox();
            this.cboxAutoEnd = new System.Windows.Forms.CheckBox();
            this.numupdownLength = new System.Windows.Forms.NumericUpDown();
            this.lLength = new System.Windows.Forms.Label();
            this.cboxAutoOpen = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numupdownCredit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numupdownInstalment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numupdownRate)).BeginInit();
            this.gboxCredit.SuspendLayout();
            this.gboxRandomness.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackbarRandomnessRate)).BeginInit();
            this.gboxSimulation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numupdownLength)).BeginInit();
            this.SuspendLayout();
            // 
            // lCredit
            // 
            this.lCredit.AutoSize = true;
            this.lCredit.Location = new System.Drawing.Point(6, 19);
            this.lCredit.Name = "lCredit";
            this.lCredit.Size = new System.Drawing.Size(95, 15);
            this.lCredit.TabIndex = 0;
            this.lCredit.Text = "Kreditsumme [€]";
            // 
            // numupdownCredit
            // 
            this.numupdownCredit.DecimalPlaces = 2;
            this.numupdownCredit.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numupdownCredit.Location = new System.Drawing.Point(107, 17);
            this.numupdownCredit.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numupdownCredit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numupdownCredit.Name = "numupdownCredit";
            this.numupdownCredit.Size = new System.Drawing.Size(212, 23);
            this.numupdownCredit.TabIndex = 1;
            this.numupdownCredit.ThousandsSeparator = true;
            this.numupdownCredit.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // numupdownInstalment
            // 
            this.numupdownInstalment.DecimalPlaces = 2;
            this.numupdownInstalment.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numupdownInstalment.Location = new System.Drawing.Point(107, 46);
            this.numupdownInstalment.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numupdownInstalment.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numupdownInstalment.Name = "numupdownInstalment";
            this.numupdownInstalment.Size = new System.Drawing.Size(212, 23);
            this.numupdownInstalment.TabIndex = 3;
            this.numupdownInstalment.ThousandsSeparator = true;
            this.numupdownInstalment.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // lInstalment
            // 
            this.lInstalment.AutoSize = true;
            this.lInstalment.Location = new System.Drawing.Point(6, 48);
            this.lInstalment.Name = "lInstalment";
            this.lInstalment.Size = new System.Drawing.Size(87, 15);
            this.lInstalment.TabIndex = 2;
            this.lInstalment.Text = "Rate [€/Monat]";
            // 
            // numupdownRate
            // 
            this.numupdownRate.DecimalPlaces = 2;
            this.numupdownRate.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.numupdownRate.Location = new System.Drawing.Point(107, 75);
            this.numupdownRate.Name = "numupdownRate";
            this.numupdownRate.Size = new System.Drawing.Size(212, 23);
            this.numupdownRate.TabIndex = 5;
            // 
            // lRate
            // 
            this.lRate.AutoSize = true;
            this.lRate.Location = new System.Drawing.Point(6, 77);
            this.lRate.Name = "lRate";
            this.lRate.Size = new System.Drawing.Size(70, 15);
            this.lRate.TabIndex = 4;
            this.lRate.Text = "Zinssatz [%]";
            // 
            // savedialog
            // 
            this.savedialog.Filter = "txt-Datei|*.csv";
            this.savedialog.Title = "Simulieren und Exportieren";
            // 
            // gboxCredit
            // 
            this.gboxCredit.Controls.Add(this.lCredit);
            this.gboxCredit.Controls.Add(this.numupdownRate);
            this.gboxCredit.Controls.Add(this.numupdownCredit);
            this.gboxCredit.Controls.Add(this.lRate);
            this.gboxCredit.Controls.Add(this.lInstalment);
            this.gboxCredit.Controls.Add(this.numupdownInstalment);
            this.gboxCredit.Location = new System.Drawing.Point(12, 12);
            this.gboxCredit.Name = "gboxCredit";
            this.gboxCredit.Size = new System.Drawing.Size(325, 104);
            this.gboxCredit.TabIndex = 6;
            this.gboxCredit.TabStop = false;
            this.gboxCredit.Text = "Kredit";
            // 
            // gboxRandomness
            // 
            this.gboxRandomness.Controls.Add(this.trackbarRandomnessRate);
            this.gboxRandomness.Controls.Add(this.lRandomnessRate);
            this.gboxRandomness.Location = new System.Drawing.Point(12, 122);
            this.gboxRandomness.Name = "gboxRandomness";
            this.gboxRandomness.Size = new System.Drawing.Size(325, 51);
            this.gboxRandomness.TabIndex = 7;
            this.gboxRandomness.TabStop = false;
            this.gboxRandomness.Text = "Zufälligkeit";
            // 
            // trackbarRandomnessRate
            // 
            this.trackbarRandomnessRate.AutoSize = false;
            this.trackbarRandomnessRate.Location = new System.Drawing.Point(123, 20);
            this.trackbarRandomnessRate.Maximum = 75;
            this.trackbarRandomnessRate.Name = "trackbarRandomnessRate";
            this.trackbarRandomnessRate.Size = new System.Drawing.Size(196, 23);
            this.trackbarRandomnessRate.TabIndex = 7;
            this.trackbarRandomnessRate.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackbarRandomnessRate.Value = 5;
            // 
            // lRandomnessRate
            // 
            this.lRandomnessRate.AutoSize = true;
            this.lRandomnessRate.Location = new System.Drawing.Point(6, 24);
            this.lRandomnessRate.Name = "lRandomnessRate";
            this.lRandomnessRate.Size = new System.Drawing.Size(111, 15);
            this.lRandomnessRate.TabIndex = 6;
            this.lRandomnessRate.Text = "Zufälligkeit Zinssatz";
            // 
            // bSimulateExport
            // 
            this.bSimulateExport.Location = new System.Drawing.Point(12, 271);
            this.bSimulateExport.Name = "bSimulateExport";
            this.bSimulateExport.Size = new System.Drawing.Size(325, 23);
            this.bSimulateExport.TabIndex = 8;
            this.bSimulateExport.Text = "Simulieren und Exportieren";
            this.bSimulateExport.UseVisualStyleBackColor = true;
            this.bSimulateExport.Click += new System.EventHandler(this.bSimulateExport_Click);
            // 
            // gboxSimulation
            // 
            this.gboxSimulation.Controls.Add(this.cboxAutoEnd);
            this.gboxSimulation.Controls.Add(this.numupdownLength);
            this.gboxSimulation.Controls.Add(this.lLength);
            this.gboxSimulation.Location = new System.Drawing.Point(12, 179);
            this.gboxSimulation.Name = "gboxSimulation";
            this.gboxSimulation.Size = new System.Drawing.Size(325, 78);
            this.gboxSimulation.TabIndex = 8;
            this.gboxSimulation.TabStop = false;
            this.gboxSimulation.Text = "Simulation";
            // 
            // cboxAutoEnd
            // 
            this.cboxAutoEnd.AutoSize = true;
            this.cboxAutoEnd.Checked = true;
            this.cboxAutoEnd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboxAutoEnd.Location = new System.Drawing.Point(103, 51);
            this.cboxAutoEnd.Name = "cboxAutoEnd";
            this.cboxAutoEnd.Size = new System.Drawing.Size(201, 19);
            this.cboxAutoEnd.TabIndex = 8;
            this.cboxAutoEnd.Text = "Simulation automatisch beenden";
            this.cboxAutoEnd.UseVisualStyleBackColor = true;
            this.cboxAutoEnd.CheckedChanged += new System.EventHandler(this.cboxAutoEnd_CheckedChanged);
            // 
            // numupdownLength
            // 
            this.numupdownLength.Enabled = false;
            this.numupdownLength.Location = new System.Drawing.Point(103, 22);
            this.numupdownLength.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numupdownLength.Name = "numupdownLength";
            this.numupdownLength.Size = new System.Drawing.Size(216, 23);
            this.numupdownLength.TabIndex = 7;
            // 
            // lLength
            // 
            this.lLength.AutoSize = true;
            this.lLength.Location = new System.Drawing.Point(6, 24);
            this.lLength.Name = "lLength";
            this.lLength.Size = new System.Drawing.Size(91, 15);
            this.lLength.TabIndex = 6;
            this.lLength.Text = "Länge [Monate]";
            // 
            // cboxAutoOpen
            // 
            this.cboxAutoOpen.AutoSize = true;
            this.cboxAutoOpen.Checked = true;
            this.cboxAutoOpen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboxAutoOpen.Location = new System.Drawing.Point(134, 300);
            this.cboxAutoOpen.Name = "cboxAutoOpen";
            this.cboxAutoOpen.Size = new System.Drawing.Size(203, 19);
            this.cboxAutoOpen.TabIndex = 10;
            this.cboxAutoOpen.Text = "Datei automatisch in Excel öffnen";
            this.cboxAutoOpen.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 331);
            this.Controls.Add(this.cboxAutoOpen);
            this.Controls.Add(this.gboxSimulation);
            this.Controls.Add(this.bSimulateExport);
            this.Controls.Add(this.gboxRandomness);
            this.Controls.Add(this.gboxCredit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Kredit Simulator";
            ((System.ComponentModel.ISupportInitialize)(this.numupdownCredit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numupdownInstalment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numupdownRate)).EndInit();
            this.gboxCredit.ResumeLayout(false);
            this.gboxCredit.PerformLayout();
            this.gboxRandomness.ResumeLayout(false);
            this.gboxRandomness.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackbarRandomnessRate)).EndInit();
            this.gboxSimulation.ResumeLayout(false);
            this.gboxSimulation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numupdownLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lCredit;
        private System.Windows.Forms.NumericUpDown numupdownCredit;
        private System.Windows.Forms.NumericUpDown numupdownInstalment;
        private System.Windows.Forms.Label lInstalment;
        private System.Windows.Forms.NumericUpDown numupdownRate;
        private System.Windows.Forms.Label lRate;
        private System.Windows.Forms.SaveFileDialog savedialog;
        private System.Windows.Forms.GroupBox gboxCredit;
        private System.Windows.Forms.GroupBox gboxRandomness;
        private System.Windows.Forms.TrackBar trackbarRandomnessRate;
        private System.Windows.Forms.Label lRandomnessRate;
        private System.Windows.Forms.Button bSimulateExport;
        private System.Windows.Forms.GroupBox gboxSimulation;
        private System.Windows.Forms.NumericUpDown numupdownLength;
        private System.Windows.Forms.Label lLength;
        private System.Windows.Forms.CheckBox cboxAutoEnd;
        private System.Windows.Forms.CheckBox cboxAutoOpen;
    }
}

