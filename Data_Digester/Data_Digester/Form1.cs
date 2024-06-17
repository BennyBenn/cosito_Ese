using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Data_Digester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            var excelApp = new Microsoft.Office.Interop.Excel.Application();
            var workbook = excelApp.Workbooks.Open(@"C:\Users\ENTIDADES1\Documents\Visual Studio 2012\Projects\cosito_Ese\Data_Digester\EXCEL\Catalogos_2024.xlsx");
            var worksheet = workbook.Worksheets[1];

            var range = worksheet.UsedRange;
            var data = (range.Value as object[,]).Select(x => x.ToString()).ToList();

            var gridView = new DataGridView();
            gridView.DataSource = data;
            gridView.DataBind();*/



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'pruebasDataSet.RAMO' Puede moverla o quitarla según sea necesario.
            this.rAMOTableAdapter.Fill(this.pruebasDataSet.RAMO);

        }
    }
}
