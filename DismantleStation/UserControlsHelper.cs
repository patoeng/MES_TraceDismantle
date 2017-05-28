using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using Microsoft.ApplicationBlocks.Data;

namespace DismantleStation
{
    public static class UserControlsHelper
    {
        //Read Control points based on Roles defined in table and call this method on form load.
        public static  bool SetFormAccess(Form frm, int roleId, string databaseConnection)
        {
            Control item = null;
            string ctrlName = "";
            bool isAllow = false;
            //write function to get entity based on role
            var dataSet = SqlHelper.ExecuteDataset(databaseConnection, CommandType.StoredProcedure, "usp_controlsCheck",
                new SqlParameter("@RoleId", SqlDbType.BigInt) {Value = roleId});
            if (dataSet.Tables.Count <= 0) return false;

            var dt = dataSet.Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                ctrlName = dr["ControlName"].ToString();
                isAllow = Convert.ToBoolean(dr["IsAllowed"]);

                //Find object in forms control collection 
                var ctls = GetAll(frm, typeof(Button));
                foreach (Control c in ctls)
                {
                    if (c.Name == ctrlName)
                        item = c;
                }

                if (item != null)
                {
                    if (dr["ControlProperty"].ToString() == "Enabled")
                        item.Enabled = isAllow;
                    else if (dr["ControlProperty"].ToString() == "Visible")
                        item.Visible = isAllow;
                    else
                        item.Enabled = isAllow;
                }
            }
            return true;
        }
        public static IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            var enumerable = controls as Control[] ?? controls.ToArray();
            return enumerable.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(enumerable)
                                      .Where(c => c.GetType() == type);
        }
        public static int LoginCheck(int roleId, string password, string databaseConnection)
        {
            var result = new SqlParameter("@password", SqlDbType.NVarChar,250) {Direction = ParameterDirection.Output};
            var paramaters = new[]
            {
                new SqlParameter("@RoleId", SqlDbType.BigInt) {Value = roleId+1},
                result
            };
            var login = SqlHelper.ExecuteNonQuery(databaseConnection, CommandType.StoredProcedure, "usp_LoginCheck", paramaters);
            if (login !=-1) return login;

            var dbPassword = Encryption.Decrypt(result.Value.ToString());
            if (dbPassword.Equals(password)) return roleId;
            return -1;
        }

        public static bool PasswordChange(int roleId, string newPassword, string databaseConnection)
        {
            var encryptedPassword = Encryption.Encrypt(newPassword);
            var paramaters = new[]
            {
                new SqlParameter("@RoleId", SqlDbType.BigInt) {Value = roleId},
                new SqlParameter("@Password", SqlDbType.NVarChar) {Value = encryptedPassword}
            };
            var result = SqlHelper.ExecuteNonQuery(databaseConnection, CommandType.StoredProcedure, "usp_PasswordChange", paramaters);
            return result>-1;
        }
    }
}
