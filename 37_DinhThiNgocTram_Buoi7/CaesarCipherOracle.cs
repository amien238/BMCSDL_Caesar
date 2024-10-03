using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Windows.Forms;

namespace _37_DinhThiNgocTram_Buoi7
{
    class CaesarCipherOracle
    {
        private OracleConnection conn;
        public CaesarCipherOracle(OracleConnection conn)
        {
            this.conn = conn;
        }
        public string EncryptCaesar_Func(string Plaintext, int key)
        {
            try
            {
                string Function = "encryptCaesarCipher";

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = Function;
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter resultParam = new OracleParameter();
                resultParam.ParameterName="@Result";
                resultParam.OracleDbType=OracleDbType.Varchar2;
                resultParam.Size=100;
                resultParam.Direction=ParameterDirection.ReturnValue;
                cmd.Parameters.Add(resultParam);

                OracleParameter str = new OracleParameter();
                str.ParameterName = "@str";
                str.OracleDbType = OracleDbType.Varchar2;
                str.Value = Plaintext;
                str.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(str);

                OracleParameter k = new OracleParameter();
                k.ParameterName = "@k";
                k.OracleDbType = OracleDbType.Int32;
                k.Value = key;
                k.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(k);

                cmd.ExecuteNonQuery();

                string s = "null";
                if(resultParam.Value!=DBNull.Value)
                {
                    OracleString ret = (OracleString)resultParam.Value;
                    s = ret.ToString();
                }
                return s;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().ToString());
            }
            return null;
        }

        public string DecryptCaesar_Func(string Plaintext, int key)
        {
            try
            {
                string Function = "decryptCaesarCipher";

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = Function;
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter resultParam = new OracleParameter();
                resultParam.ParameterName = "@Result";
                resultParam.OracleDbType = OracleDbType.Varchar2;
                resultParam.Size = 100;
                resultParam.Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(resultParam);

                OracleParameter str = new OracleParameter();
                str.ParameterName = "@str";
                str.OracleDbType = OracleDbType.Varchar2;
                str.Value = Plaintext;
                str.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(str);

                OracleParameter k = new OracleParameter();
                k.ParameterName = "@k";
                k.OracleDbType = OracleDbType.Int32;
                k.Value = key;
                k.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(k);

                cmd.ExecuteNonQuery();

                string s = "null";
                if (resultParam.Value != DBNull.Value)
                {
                    OracleString ret = (OracleString)resultParam.Value;
                    s = ret.ToString();
                }
                return s;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().ToString());
            }
            return null;
        }
    }
}
