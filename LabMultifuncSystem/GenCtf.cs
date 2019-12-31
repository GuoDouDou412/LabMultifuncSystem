using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Spreadsheet;

namespace LabMultifuncSystem
{
    public interface IGenCtf
    {
        string strPath { get; set; }
        bool ConnDatabase();
        void ConvertPdfToXls();
        void ConvertTxtToXls();
        void GenDoc(string Path);
        List<string> LoadEtalonInfo(string Range);
        List<string> LoadXlsClientInfo(string Range);
        List<string> LoadXlsDataInfo(string Range);
        void UploadToDatabase(List<string> ClientInfo);
    }
    public class Certifications : IGenCtf
    {
        public string strPath
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public bool ConnDatabase()
        {
            throw new NotImplementedException();
        }

        public void ConvertPdfToXls()
        {
            throw new NotImplementedException();
        }

        public void ConvertTxtToXls()
        {
            throw new NotImplementedException();
        }

        public void GenDoc(string Path)
        {
            throw new NotImplementedException();
        }

        public List<string> LoadEtalonInfo(string Range)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// load client's information
        /// </summary>
        /// <param name="Range"></param>
        /// <returns></returns>
        public List<string> LoadXlsClientInfo(string Range)
        {
            IWorkbook workbook = MainWindow.MyMainWindow.xlsViewer.Document;
            workbook.LoadDocument(@"F:\Working\原始记录\螺纹机\2019\新模板\温州院 _2019.12.26\温州院_2019.12.26.xlsx");
            Worksheet worksheet = workbook.Worksheets[0];
            Range range = worksheet["D8:D11"];
            List<string> list = new List<string>();
            for (int i = 0; i < range.RowCount; i++)
            {
                string a = range[i].Value.ToString();
                list.Add(a);
                System.Windows.MessageBox.Show(a);
            }
            return list;
        }

        /// <summary>
        /// load data from raw data in xls format
        /// </summary>
        /// <param name="Range"></param>
        /// <returns>List<string></returns>
        public List<string> LoadXlsDataInfo(string Range)
        {
            throw new NotImplementedException();
        }

        public void UploadToDatabase(List<string> ClientInfo)
        {
            throw new NotImplementedException();
        }
    }
}
