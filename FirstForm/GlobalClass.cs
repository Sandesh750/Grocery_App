using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace FirstForm
{
    public static class GlobalClass
    {
        public static OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\Teach4\\FirstForm\\FirstForm\\bin\\Debug\\FirstForm.mdb");
        public static OleDbCommand cmd = new OleDbCommand();
        public static OleDbDataReader dr;
        public static OleDbDataAdapter da = new OleDbDataAdapter();
        public static DataSet ds = new DataSet();


        public static string Uname = "";
        public static string Pass = "";
        public static string FUname="";
        public static string Que = "";
        public static string Ans = "";

        public static string CustNo = "";
        public static string CustName = "";
        public static string Address = "";
        public static string City = "";
        public static string MobileNo = "";
        public static string DueAmount = "";

        public static string ICode = "";
        public static string IName = "";
        public static string Price = "";

        public static string lstiname = "";
        public static string lsticode = "";
        public static string lstprice = "";
        public static string lstqty = "";
        public static string lstamount = "";
        public static string sbillNo;
        public static string PayMode = "";

        public static string STrNo;
        public static string Balance;

        public static string pbillNo;
        public static string SuppNo = "";
        public static string SuppName = "";
        public static string PTrNo;

        public static string SrNo;

        public static void record_Reader(String sqlcmd)
        {
            con.Open();
            cmd = new OleDbCommand(sqlcmd,con);
            dr = cmd.ExecuteReader();
        }

        public static int id_Resder(string sqlcmd)
        {
            int i = 0;
            con.Open();
            cmd = new OleDbCommand(sqlcmd , con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                i = Convert.ToInt32(dr[0].ToString());
            }
            dr.Close();
            con.Close();
            i = i + 1;
            return i;
        }

        public static void record_Manip(string sqlcmd)
        {
            con.Open ();
            cmd=new OleDbCommand (sqlcmd,con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static void Show_List(string sqlcmd)
        {
            con.Open();
            da = new OleDbDataAdapter(sqlcmd,con);
            ds = new DataSet("Employee");
            da.Fill(ds, "Employee");
        }

        public static void Show_List_Student(string sqlcmd)
        {
            con.Open();
            da = new OleDbDataAdapter(sqlcmd, con);
            ds = new DataSet("Student");
            da.Fill(ds, "Student");
        }

        public static void Show_List_Customer(string sqlcmd)
        {
            con.Open();
            da = new OleDbDataAdapter(sqlcmd, con);
            ds = new DataSet("Customer");
            da.Fill(ds, "Customer");
        }

        public static void Show_List_Supplier(string sqlcmd)
        {
            con.Open();
            da = new OleDbDataAdapter(sqlcmd, con);
            ds = new DataSet("Supplier");
            da.Fill(ds, "Supplier");
        }

        public static void Show_List_Supplier_pay(string sqlcmd)
        {
            con.Open();
            da = new OleDbDataAdapter(sqlcmd, con);
            ds = new DataSet("Supplier_Payment");
            da.Fill(ds, "Supplier_Payment");
        }

        public static void Show_List_Customer_pay(string sqlcmd)
        {
            con.Open();
            da = new OleDbDataAdapter(sqlcmd, con);
            ds = new DataSet("Customer_Payment");
            da.Fill(ds, "Customer_Payment");
        }


        public static OleDbConnection bcon = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='E:\\Teach4\\FirstForm\\FirstForm\\bin\\Debug\\EmployeeBook.xls'; Extended properties= Excel 8.0;");
        public static OleDbCommand bcmd = new OleDbCommand();
        public static OleDbDataReader bdr;
        public static OleDbDataAdapter bda = new OleDbDataAdapter();
        public static DataSet bds = new DataSet();

       
        public static string CCode = "";
        public static string CName = "";
        public static string Fees = "";

        public static string EmpNo = ""; 
        public static string EmpName = "";
        public static string Post = "";
        public static string Salary = "";
        

        public static void book_Reader(String sqlbcmd)
        {
            bcon.Open();
            bcmd = new OleDbCommand(sqlbcmd, bcon);
            bdr = bcmd.ExecuteReader();
        }

        public static void book_Manip(string sqlbcmd)
        {
            bcon.Open();
            bcmd = new OleDbCommand(sqlbcmd, bcon);
            bcmd.ExecuteNonQuery();
            bcon.Close();
        }

        public static int bookid_Resder(string sqlbcmd)
        {
            int i = 0;
            bcon.Open();
            bcmd = new OleDbCommand(sqlbcmd, bcon);
            bdr = bcmd.ExecuteReader();

            while (bdr.Read())
            {
                i = Convert.ToInt32(bdr[0].ToString());
            }
            bdr.Close();
            bcon.Close();
            i = i + 1;
            return i;
        }

        public static void BShow_List(string sqlbcmd)
        {
            bcon.Open();
            bda = new OleDbDataAdapter(sqlbcmd, bcon);
            bds = new DataSet("[Sheet2$]");
            bda.Fill(bds, "[Sheet2$]");
        }
        
    }
}
