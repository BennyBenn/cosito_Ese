using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Web.UI.WebControls;
using System.Collections.Generic;


namespace Data_Digester{
    class Class1{
        /*
        public void volcar_excel(){

            var excelApp = new Microsoft.Office.Interop.Excel.Application();
            var workbook = excelApp.Workbooks.Open(@"C:\Users\ENTIDADES1\Documents\Visual Studio 2012\Projects\cosito_Ese\Data_Digester\EXCEL\Catalogos_2024.xlsx");
            var worksheet = workbook.Worksheets[1];

            var range = worksheet.UsedRange;
            var data = (range.Value as object[,]).Select(x => x.ToString()).ToList();

            var gridView = new DataGridView();
            gridView.DataSource = data;
            gridView.DataBind();
        }
         * */
    }
}


/*
 
 // Load the Excel file
var excelApp = new Microsoft.Office.Interop.Excel.Application();
var workbook = excelApp.Workbooks.Open(@"path\to\your\file.xlsx");
var worksheet = workbook.Worksheets[1];

// Get the data
var range = worksheet.UsedRange;
var data = (range.Value as object[,]).Select(x => x.ToString()).ToList();

// Dump it onto a GridView
var gridView = new GridView();
gridView.DataSource = data;
gridView.DataBind();
 * 
 * 
 */
