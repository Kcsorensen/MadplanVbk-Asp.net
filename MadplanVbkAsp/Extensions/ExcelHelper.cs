using OfficeOpenXml;
using PdfRpt.Core.Contracts;
using PdfRpt.FluentInterface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace MadplanVbkAsp.Extensions
{
    public class ExcelHelper
    {
        private ExcelPackage _excelTemplate;

        public ExcelHelper()
        {
            var assembly = Assembly.GetExecutingAssembly();

            var stream = assembly.GetManifestResourceStream("MadplanVbkAsp.Resources.Skabelon.xlsx");

            _excelTemplate = new ExcelPackage(stream);

            var worksheet = _excelTemplate.Workbook.Worksheets.First();

            worksheet.Cells["B4"].Value = "Kim";
        }

        public Stream GetXlsxStream()
        {
            return new MemoryStream(_excelTemplate.GetAsByteArray());
        }

        //public Stream GetPdfStream()
        //{
        //    var test = InMemoryPdfReport
        //}

        public void SaveFileToDisk()
        {

        }

    }
}
