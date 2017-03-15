using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace MockAdmit
{
    public class ExcelParser
    {
        public static List<Applier> ParseApplierFile(String filePath) {
            DataTable dt = parseExcel(filePath);
            List<Applier> applierList = new List<Applier>();
            foreach (DataRow row in dt.Rows) {
                String applierName = row[1].ToString();
                String applierRegisterNumber = row[0].ToString();
                Double applierScore = Convert.ToDouble(row[10]);
                String applierSubject = row[2].ToString();
                bool acceptChange = row[9].ToString().ToLower() == "true";
                String[] preferedMajor = new String[] { row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString(),row[8].ToString() };
                Applier applier = new Applier(applierName,applierRegisterNumber,applierSubject,applierScore, preferedMajor, acceptChange);
                applierList.Add(applier);
            }
            return applierList.OrderBy(a=>a.Subject).ThenByDescending(a=>a.Score).ToList();
        }

        public static List<Major> ParseMajorFile(String filePath)
        {
            DataTable dt = parseExcel(filePath);
            List<Major> majorList = new List<Major>();
            foreach (DataRow row in dt.Rows)
            {
                String majorName = row[1].ToString();
                int plannedCapacity = Convert.ToInt32(row[2].ToString());
                String majorSubject = row[0].ToString();
                Major major = new Major(majorName, majorSubject, plannedCapacity);
                majorList.Add(major);
            }
            return majorList;
        }

        protected static DataTable parseExcel(String filePath)
        {
            string connStr = "";
            string fileType = System.IO.Path.GetExtension(filePath);

            if (fileType == ".xls")
                connStr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + filePath + ";" + ";Extended Properties=\"Excel 8.0;HDR=YES;IMEX=1\"";
            else
                connStr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + filePath + ";" + ";Extended Properties=\"Excel 12.0;HDR=YES;IMEX=1\"";
            string sql_F = "Select * FROM [{0}]";

            OleDbConnection conn = null;
            OleDbDataAdapter da = new OleDbDataAdapter();
            DataTable dtSheetName = null;
            DataTable dt = new DataTable();
            try
            {
                conn = new OleDbConnection(connStr);
                conn.Open();
                string SheetName = "";
                dtSheetName = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
                SheetName = (string)dtSheetName.Rows[0]["TABLE_NAME"];
                da.SelectCommand = new OleDbCommand(String.Format(sql_F, SheetName), conn);
                da.Fill(dt);
                return dt;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                    da.Dispose();
                    conn.Dispose();
                }
            }
        }

    }
}
