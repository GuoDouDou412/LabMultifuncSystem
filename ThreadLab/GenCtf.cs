using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ThreadLab
{
    public interface IGenCtf
    {
        /// <summary>
        /// path for saving document
        /// </summary>
        string strPath { get; set; }
        /// <summary>
        /// convert pdf to xls as raw data 
        /// </summary>
        void ConvertPdfToXls();
        /// <summary>
        /// convert txt to xls as raw data
        /// </summary>
        void ConvertTxtToXls();
        /// <summary>
        /// generation a certification
        /// </summary>
        /// <param name="Path"></param>
        void GenDoc(string Path);
        /// <summary>
        /// judgement for the state of database's connection
        /// </summary>
        /// <returns>boolean</returns>
        bool ConnDatabase();
        /// <summary>
        /// upload the related data to database
        /// </summary>
        /// <param name="ClientInfo"></param>
        void UploadToDatabase(List<string> ClientInfo);
        /// <summary>
        /// load client's information from xls data
        /// </summary>
        /// <param name="Range"></param>
        /// <returns>List<string></returns>
        List<string> LoadXlsClientInfo(string Range);
        /// <summary>
        /// load raw data from xls data
        /// </summary>
        /// <param name="Range"></param>
        /// <returns>List<string></returns>
        List<string> LoadXlsDataInfo(string Range);
    }

    public class ThreadMachine : IGenCtf
    {
        private string DocPath;
        public string strPath
        {
            get
            {
                return DocPath;
            }

            set
            {
                DocPath = value;
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

        public List<string> LoadXlsClientInfo()
        {
            throw new NotImplementedException();
        }

        public List<string> LoadXlsClientInfo(string Range)
        {
            throw new NotImplementedException();
        }

        public List<string> LoadXlsDataInfo()
        {
            throw new NotImplementedException();
        }

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
