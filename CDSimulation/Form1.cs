using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDSimulation
{
    public partial class Form1 : Form
    {
        Disc disc;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            disc = new Disc(360);
            disc.WriteFile("file1.txt");
            disc.WriteFile("file2.txt");
            disc.WriteFile("file3.txt");
            disc.WriteFile("file4.txt");
            disc.WriteFile("file5.txt");

            disc.DeleteFile("file2.txt");
            disc.DeleteFile("file3.txt");

            disc.WriteFile("file3.txt");
            disc.WriteFile("file2.txt");


            discCapacity.Value = disc.GetPersentageOfFilling();
            Console.WriteLine("Persentage Of Filling: "+ disc.GetPersentageOfFilling());
            discCapacity.SuperscriptText = disc.GetPersentageOfFilling().ToString();

            FillTableByDictionary(fileTableLayoutPanel,disc.FileTable);

            
        }

        private void FillTableByDictionary(TableLayoutPanel table, Dictionary<string,int> keyValuePairs)
        {
            int rowIndex = 0;
            foreach (KeyValuePair<string, int> entry in keyValuePairs)
            {
                table.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
                table.Controls.Add(new Label(){ Text = entry.Key }, 0, rowIndex);
                table.Controls.Add(new Label() { Text = entry.Value.ToString() }, 1, rowIndex);

                rowIndex++;
            }
        }
    }
}
