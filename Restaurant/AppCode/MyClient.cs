using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Management;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Restaurant.AppCode
{ 
    
    public class MyClient
    {
        SqlDataAdapter da;
        SqlConnection conn;
        DataTable dt = new DataTable();

        string  connStr = Properties.Settings.Default.ConnectionUrl.ToString();

        public string PassHash(string input)
        {
            MD5 md5Hasher = MD5.Create();
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }


        public byte[] Encrypt(byte[] input)
        {
            PasswordDeriveBytes pdb = new PasswordDeriveBytes("‭B7D5923C3F‬", new byte[] { 0x43, 0x87, 0x23, 0x72 });
            MemoryStream ms = new MemoryStream();
            Aes aes = new AesManaged();
            aes.Key = pdb.GetBytes(aes.KeySize / 8);
            aes.IV = pdb.GetBytes(aes.BlockSize / 8);
            CryptoStream cs = new CryptoStream(ms,
              aes.CreateEncryptor(), CryptoStreamMode.Write);
            cs.Write(input, 0, input.Length);
            cs.Close();
            return ms.ToArray();
        }

        public byte[] Decrypt(byte[] input)
        {
            PasswordDeriveBytes pdb = new PasswordDeriveBytes("‭B7D5923C3F‬", new byte[] { 0x43, 0x87, 0x23, 0x72 });
            MemoryStream ms = new MemoryStream();
            Aes aes = new AesManaged();
            aes.Key = pdb.GetBytes(aes.KeySize / 8);
            aes.IV = pdb.GetBytes(aes.BlockSize / 8);
            CryptoStream cs = new CryptoStream(ms,
              aes.CreateDecryptor(), CryptoStreamMode.Write);
            cs.Write(input, 0, input.Length);
            cs.Close();
            return ms.ToArray();
        }


        public  string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }


        public DataTable GetProcedure(string name)
        {

            try
            {
                conn = new SqlConnection(connStr);
                conn.Open();

                SqlCommand cmd = new SqlCommand("ProcDynamic", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Par_Table", SqlDbType.VarChar).Value = name;
               //da.SelectCommand = cmd;
               da = new SqlDataAdapter(cmd);
               da.Fill(dt);
                conn.Close();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
       
        
        public DataTable GetTable(string strQuery)
        {
            DataTable dt = new DataTable();

            try
            {
                conn = new SqlConnection(connStr);
                conn.Open();

                da = new SqlDataAdapter(strQuery, conn);
                da.Fill(dt);
                conn.Close();

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public DataSet GetDataSet(string strQuery)
        {
            DataSet ds = new DataSet();
            try
            {
                conn = new SqlConnection(connStr);
                conn.Open();

                da = new SqlDataAdapter(strQuery, conn);
                da.Fill(ds);

                conn.Close();
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public string SHA512Hash(string input)
        {
            SHA512 sha = new SHA512Managed();
            byte[] hash = sha.ComputeHash(Encoding.ASCII.GetBytes(input));
            StringBuilder stringBuilder = new StringBuilder();
            foreach (byte b in hash)
            {
                stringBuilder.AppendFormat("{0:x2}", b);
            }
            return stringBuilder.ToString();
        }

        public  string ReadFile(string FileName)
        {
            string ReadLine = null;
            StreamReader reader = new StreamReader(@FileName);
            ReadLine = reader.ReadLine();
            reader.Close();
            return ReadLine;
        }
    }
}
