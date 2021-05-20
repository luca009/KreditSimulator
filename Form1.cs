using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KreditSimulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<string> Simulate(decimal credit, decimal ratePercent, decimal instalment, int length, decimal randomnessRate, List<string> list, bool autoEnd = true)
        {
            decimal lastCredit = credit;
            decimal lastTotalInstalment = instalment - (lastCredit * (ratePercent / 100));
            decimal actualRatePercent = ratePercent;
            Random random = new Random(Guid.NewGuid().GetHashCode());

            //Initialize first month
            list.Add($"1\t{credit}€\t{ratePercent}%\t{credit * (ratePercent / 100)}€\t{instalment}€\t-");

            //Loop from month 2 to the end
            for (int i = 2; i <= length + 1; i++)
            {
                //Update rate
                if (!(randomnessRate == 0))
                {
                    decimal lastRandom = (decimal)random.NextDouble();
                    actualRatePercent = actualRatePercent * (((lastRandom - 0.5m) * randomnessRate) + 1);
                    actualRatePercent = Math.Round(actualRatePercent, 5);
                    actualRatePercent = Math.Clamp(actualRatePercent, ratePercent - randomnessRate, ratePercent + randomnessRate);
                }
                else
                    actualRatePercent = ratePercent;
                

                lastTotalInstalment = instalment - (lastCredit * (actualRatePercent / 100));
                lastCredit = lastCredit - lastTotalInstalment;

                //If needed, automatically end
                if (autoEnd)
                {
                    if (i > 999999)
                    {
                        MessageBox.Show("Die Simulation läuft schon zu lange.\nDeshalb wurde sie frühzeitig beendet.", "Simulation läuft zu lange", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return list;
                    }
                    if (lastCredit < 0)
                        return list;
                }

                //Add new row
                list.Add($"{i}\t{lastCredit}€\t{actualRatePercent}%\t{lastCredit * (actualRatePercent / 100)}€\t{instalment}€\t{lastTotalInstalment}€");
            }

            return list;
        }

        private void bSimulateExport_Click(object sender, EventArgs e)
        {
            if (savedialog.ShowDialog() == DialogResult.OK)
            {
                List<string> list = new List<string>();
                string filePath = savedialog.FileName;
                int length;
                if (cboxAutoEnd.Checked)
                    length = int.MaxValue - 1;
                else
                    length = (int)Math.Ceiling(numupdownLength.Value);

                //Initialize first row
                list.Add("Monat\tSchuldenstand\tZinssatz\tZinsen\tRate\tTilgung");

                try
                {
                    Simulate(numupdownCredit.Value, numupdownRate.Value / 12, numupdownInstalment.Value, length, (decimal)trackbarRandomnessRate.Value / 100m, list, cboxAutoEnd.Checked);

                    using (TextWriter tw = new StreamWriter(filePath, false, Encoding.UTF32))
                    {
                        foreach (var item in list)
                            tw.WriteLine(item);
                        tw.Write("\uFEFF");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //Finally, open the file or display a message
                if (cboxAutoOpen.Checked)
                {
                    Process p = new Process();
                    p.StartInfo.UseShellExecute = true;
                    p.StartInfo.FileName = "excel";
                    p.StartInfo.Arguments = filePath;
                    p.Start();
                }
                else
                    MessageBox.Show($"Der Export ist nun fertig.\nDie fertige Datei liegt bei {filePath}.", "Export fertig.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cboxAutoEnd_CheckedChanged(object sender, EventArgs e)
        {
            numupdownLength.Enabled = !cboxAutoEnd.Checked;
        }
    }
}
