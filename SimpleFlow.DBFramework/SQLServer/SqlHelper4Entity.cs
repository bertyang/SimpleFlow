using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using SimpleFlow.SystemFramework;

namespace SimpleFlow.DBFramework.SQLServer
{
    public sealed partial class SqlHelper
    {
        #region private method
        private static EntityAttribute GetEntityAttribute(System.Type entity_type)
        {
            object[] attr_array = entity_type.GetCustomAttributes(typeof(EntityAttribute), false);
            if (attr_array.Length > 0)
            {
                return attr_array[0] as EntityAttribute;
            }
            throw new ApplicationException(string.Format("{0} does not implementation Entity Attribute.", entity_type.FullName));
        }

        private static EntityAttribute GetEntityAttribute(IEntity entity)
        {
            return GetEntityAttribute(entity.GetType());
        }

        private static IEntityHelper<T> GetEntityHelper<T>()
            where T : IEntity, new()
        {
            return GetEntityAttribute(typeof(T)).EntityHelper as IEntityHelper<T>;
        }


        private static IEntityHelper GetEntityHelper(IEntity entity)
        {
            return GetEntityAttribute(entity).EntityHelper as IEntityHelper;
        }

        private static IEntityHelper GetEntityHelper(System.Type entity_type)
        {
            return GetEntityAttribute(entity_type).EntityHelper as IEntityHelper;
        }

        #endregion private method



        #region Insert
        public static void Insert(SqlTransaction trans, IEntity entity)
        {
            GetEntityHelper(entity).Insert(trans, entity);
        }

        public static void Insert(SqlConnection conn, IEntity entity)
        {
            GetEntityHelper(entity).Insert(conn, entity);
        }

        public static void Insert(string connection_string, IEntity entity)
        {
            GetEntityHelper(entity).Insert(connection_string, entity);
        }
        #endregion

        #region Update
        public static void Update(SqlTransaction trans, IEntity entity)
        {
            GetEntityHelper(entity).Update(trans, entity);
        }

        public static void Update(SqlConnection conn, IEntity entity)
        {
            GetEntityHelper(entity).Update(conn, entity);
        }

        public static void Update(string connection_string, IEntity entity)
        {
            GetEntityHelper(entity).Update(connection_string, entity);
        }
        #endregion

        #region Delete
        public static void Delete(SqlTransaction trans, IEntity entity)
        {
            GetEntityHelper(entity).Delete(trans, entity);
        }

        public static void Delete(SqlConnection conn, IEntity entity)
        {
            GetEntityHelper(entity).Delete(conn, entity);
        }

        public static void Delete(string connection_string, IEntity entity)
        {
            GetEntityHelper(entity).Delete(connection_string, entity);
        }
        #endregion 



        #region T GetEntity<T>
        public static T GetEntity<T>(SqlTransaction trans, string sql)
            where T : IEntity, new()
        {
            DataTable data = ExecuteDataTableBySql(trans, sql);
            if (data.Rows.Count > 0)
            {
                // IEntityHelper<T> helper = GetEntityHelper<T>();
                // return helper.Row2Entity(data.Rows[0]);
                IEntityHelper helper = GetEntityHelper(typeof(T));
                return (T)helper.Row2Object(data.Rows[0]);
            }
            else
            {
                return default(T);
            }
        }

        public static T GetEntity<T>(SqlConnection conn, string sql)
            where T : IEntity, new()
        {
            DataTable data = ExecuteDataTableBySql(conn, sql);
            if (data.Rows.Count > 0)
            {
                // IEntityHelper<T> helper = GetEntityHelper<T>();
                // return helper.Row2Entity(data.Rows[0]);
                IEntityHelper helper = GetEntityHelper(typeof(T));
                return (T)helper.Row2Object(data.Rows[0]);
            }
            else
            {
                return default(T);
            }
        }

        public static T GetEntity<T>(string connection_string, string sql)
            where T : IEntity, new()
        {
            DataTable data = ExecuteDataTableBySql(connection_string, sql);
            if (data.Rows.Count > 0)
            {
                // IEntityHelper<T> helper = GetEntityHelper<T>();
                // return helper.Row2Entity(data.Rows[0]);
                IEntityHelper helper = GetEntityHelper(typeof(T));
                return (T)helper.Row2Object(data.Rows[0]);
            }
            else
            {
                return default(T);
            }
        }        
        

        public static T GetEntity<T>(SqlTransaction trans, string sql, SqlParameter[] param_list)
            where T : IEntity, new()
        {
            DataTable data = ExecuteDataTableBySql(trans, sql, param_list);
            if (data.Rows.Count > 0)
            {
                // IEntityHelper<T> helper = GetEntityHelper<T>();
                // return helper.Row2Entity(data.Rows[0]);
                IEntityHelper helper = GetEntityHelper(typeof(T));
                return (T)helper.Row2Object(data.Rows[0]);
            }
            else
            {
                return default(T);
            }
        }

        public static T GetEntity<T>(SqlConnection conn, string sql, SqlParameter[] param_list)
            where T : IEntity, new()
        {
            DataTable data = ExecuteDataTableBySql(conn, sql, param_list);
            if (data.Rows.Count > 0)
            {
                // IEntityHelper<T> helper = GetEntityHelper<T>();
                // return helper.Row2Entity(data.Rows[0]);
                IEntityHelper helper = GetEntityHelper(typeof(T));
                return (T)helper.Row2Object(data.Rows[0]);
            }
            else
            {
                return default(T);
            }
        }

        public static T GetEntity<T>(string connection_string, string sql, SqlParameter[] param_list)
            where T : IEntity, new()
        {
            DataTable data = ExecuteDataTableBySql(connection_string, sql, param_list);
            if (data.Rows.Count > 0)
            {
                // IEntityHelper<T> helper = GetEntityHelper<T>();
                // return helper.Row2Entity(data.Rows[0]);
                IEntityHelper helper = GetEntityHelper(typeof(T));
                return (T)helper.Row2Object(data.Rows[0]);
            }
            else
            {
                return default(T);
            }
        }



        #endregion 

        #region Retrieve<T>

        public static T Retrieve<T>(string connection_string, T entity)
            where T : IEntity, new()
        {
            return GetEntityHelper<T>().Retrieve(connection_string, entity);
        }

        public static T Retrieve<T>(SqlTransaction transaction, T entity)
            where T : IEntity, new()
        {
            return GetEntityHelper<T>().Retrieve(transaction, entity);
        }


        public static T Retrieve<T>(SqlConnection connection, T entity)
            where T : IEntity, new()
        {
            return GetEntityHelper<T>().Retrieve(connection, entity);
        }

        #endregion Retrieve<T>


        #region List<T> GetAll<T>
        public static List<T> GetAll<T>(SqlTransaction trans)
            where T : IEntity, new()
        {
            // IEntity entity = new T();
            EntityAttribute attr = GetEntityAttribute(typeof(T));
            string sql = string.Format("select * from [{0}]", attr.TableName);
            DataTable data = SqlHelper.ExecuteDataTable(trans, CommandType.Text, sql);

            return (attr.EntityHelper as EntityHelper<T>).DataTable2List(data);

        }

        public static List<T> GetAll<T>(SqlConnection conn)
            where T : IEntity, new()
        {
            // IEntity entity = new T();
            EntityAttribute attr = GetEntityAttribute(typeof(T));
            string sql = string.Format("select * from [{0}]", attr.TableName);
            DataTable data = SqlHelper.ExecuteDataTable(conn, CommandType.Text, sql);

            return (attr.EntityHelper as EntityHelper<T>).DataTable2List(data);
        }

        public static List<T> GetAll<T>(string connection_string)
            where T : IEntity, new()
        {
            // IEntity entity = new T();
            EntityAttribute attr = GetEntityAttribute(typeof(T));
            string sql = string.Format("select * from [{0}]", attr.TableName);
            DataTable data = SqlHelper.ExecuteDataTable(connection_string, CommandType.Text, sql);

            return (attr.EntityHelper as EntityHelper<T>).DataTable2List(data);
        }

        public static List<T> GetAll<T>(string connection_string,string p_EmpID)
            where T : IEntity, new()
        {
            // IEntity entity = new T();
            EntityAttribute attr = GetEntityAttribute(typeof(T));
            string sp_Name = "usp_GetMenuByEmpID";
            System.Data.SqlClient.SqlParameter[] p_SP = new System.Data.SqlClient.SqlParameter[1];

            p_SP[0] = new System.Data.SqlClient.SqlParameter();
            p_SP[0].Direction = ParameterDirection.Input;
            p_SP[0].ParameterName = "@empID";
            p_SP[0].SqlDbType = SqlDbType.NVarChar;
            p_SP[0].Value = p_EmpID;

            DataTable data = SqlHelper.ExecuteDataTable(connection_string, CommandType.StoredProcedure, sp_Name, p_SP);

            return (attr.EntityHelper as EntityHelper<T>).DataTable2List(data);
        }

        #endregion

        #region List<T> GetListBySql<T>
        public static List<T> GetListBySql<T>(SqlTransaction trans, string sql) 
            where T: IEntity, new ()
        {
            EntityAttribute attr = GetEntityAttribute(typeof(T));
            DataTable data = SqlHelper.ExecuteDataTable(trans, CommandType.Text, sql);
            return (attr.EntityHelper as EntityHelper<T>).DataTable2List(data);
        }

        public static List<T> GetListBySql<T>(SqlConnection conn, string sql)
            where T : IEntity, new()
        {
            EntityAttribute attr = GetEntityAttribute(typeof(T));
            DataTable data = SqlHelper.ExecuteDataTable(conn, CommandType.Text, sql);
            return (attr.EntityHelper as EntityHelper<T>).DataTable2List(data);
        }

        public static List<T> GetListBySql<T>(string connection_string, string sql)
            where T : IEntity, new()
        {
            EntityAttribute attr = GetEntityAttribute(typeof(T));
            DataTable data = SqlHelper.ExecuteDataTable(connection_string, CommandType.Text, sql);
            return (attr.EntityHelper as EntityHelper<T>).DataTable2List(data);
        }


        public static List<T> GetListBySql<T>(SqlTransaction trans, string sql, SqlParameter[] param_list)
            where T : IEntity, new()
        {
            EntityAttribute attr = GetEntityAttribute(typeof(T));
            DataTable data = SqlHelper.ExecuteDataTable(trans, CommandType.Text, sql, param_list);
            return (attr.EntityHelper as EntityHelper<T>).DataTable2List(data);
        }

        public static List<T> GetListBySql<T>(SqlConnection conn, string sql, SqlParameter[] param_list)
            where T : IEntity, new()
        {
            EntityAttribute attr = GetEntityAttribute(typeof(T));
            DataTable data = SqlHelper.ExecuteDataTable(conn, CommandType.Text, sql, param_list);
            return (attr.EntityHelper as EntityHelper<T>).DataTable2List(data);
        }

        public static List<T> GetListBySql<T>(string connection_string, string sql, SqlParameter[] param_list)
            where T : IEntity, new()
        {
            EntityAttribute attr = GetEntityAttribute(typeof(T));            
            DataTable data = SqlHelper.ExecuteDataTable(connection_string, CommandType.Text, sql, param_list);
            return (attr.EntityHelper as EntityHelper<T>).DataTable2List(data);
        }
        #endregion 


        public static List<T> QueryTable<T>(string connection_string, ColumnFilterList filter_list)
            where T: IEntity, new ()
        {
            if (filter_list.Count > 0)
            {
                EntityAttribute attr = GetEntityAttribute(typeof(T));
                StringBuilder sb = new StringBuilder(100);
                ParameterBuilder paramlist = new ParameterBuilder(filter_list.Count);

                sb.Append(" select * from [");
                sb.Append(attr.TableName);
                sb.Append("] ");
                for (int i = 0; i < filter_list.Count; i++)
                {
                    sb.Append(i > 0 ? " and " : " where ");
                    string param_name = string.Format("@__{0}__", filter_list[i].Name);
                    sb.AppendFormat(" [{0}] = {1} ", filter_list[i].Name, param_name);
                    paramlist.Add(param_name, filter_list[i].Value);
                }

                return GetListBySql<T>(connection_string, sb.ToString(), paramlist.ToArray());
            }
            else
            {
                return GetAll<T>(connection_string);
            }
        }


        public static List<T> QueryTable<T>(SqlConnection connection, ColumnFilterList filter_list)
            where T : IEntity, new()
        {
            if (filter_list.Count > 0)
            {
                EntityAttribute attr = GetEntityAttribute(typeof(T));
                StringBuilder sb = new StringBuilder(100);
                ParameterBuilder paramlist = new ParameterBuilder(filter_list.Count);

                sb.Append(" select * from [");
                sb.Append(attr.TableName);
                sb.Append("] ");
                for (int i = 0; i < filter_list.Count; i++)
                {
                    sb.Append(i > 0 ? " and " : " where ");
                    string param_name = string.Format("@__{0}__", filter_list[i].Name);
                    sb.AppendFormat(" [{0}] = {1} ", filter_list[i].Name, param_name);
                    paramlist.Add(param_name, filter_list[i].Value);
                }

                return GetListBySql<T>(connection, sb.ToString(), paramlist.ToArray());
            }
            else
            {
                return GetAll<T>(connection);
            }
        }

        public static List<T> QueryTable<T>(SqlTransaction transaction, ColumnFilterList filter_list)
            where T : IEntity, new()
        {
            if (filter_list.Count > 0)
            {
                EntityAttribute attr = GetEntityAttribute(typeof(T));
                StringBuilder sb = new StringBuilder(100);
                ParameterBuilder paramlist = new ParameterBuilder(filter_list.Count);

                sb.Append(" select * from [");
                sb.Append(attr.TableName);
                sb.Append("] ");
                for (int i = 0; i < filter_list.Count; i++)
                {
                    sb.Append(i > 0 ? " and " : " where ");
                    string param_name = string.Format("@__{0}__", filter_list[i].Name);
                    sb.AppendFormat(" [{0}] = {1} ", filter_list[i].Name, param_name);
                    paramlist.Add(param_name, filter_list[i].Value);
                }

                return GetListBySql<T>(transaction, sb.ToString(), paramlist.ToArray());
            }
            else
            {
                return GetAll<T>(transaction);
            }
        }


        public static int DeleteTable<T>(SqlTransaction transaction, ColumnFilterList filter_list)
            where T : IEntity, new ()
        {            
            EntityAttribute attr = GetEntityAttribute(typeof(T));
            StringBuilder sb = new StringBuilder(100);
            ParameterBuilder paramlist = new ParameterBuilder(filter_list.Count);

            sb.Append(" delete from [");
            sb.Append(attr.TableName);
            sb.Append("] ");
            for (int i = 0; i < filter_list.Count; i++)
            {
                sb.Append(i > 0 ? " and " : " where ");
                string param_name = string.Format("@__{0}__", filter_list[i].Name);
                sb.AppendFormat(" [{0}] = {1} ", filter_list[i].Name, param_name);
                paramlist.Add(param_name, filter_list[i].Value);
            }

            // return GetListBySql<T>(transaction, sb.ToString(), paramlist.ToArray());
            return ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramlist.ToArray());
            
        }

        public static int DeleteTable<T>(SqlConnection connection, ColumnFilterList filter_list)
            where T : IEntity, new()
        {
            EntityAttribute attr = GetEntityAttribute(typeof(T));
            StringBuilder sb = new StringBuilder(100);
            ParameterBuilder paramlist = new ParameterBuilder(filter_list.Count);

            sb.Append(" delete from [");
            sb.Append(attr.TableName);
            sb.Append("] ");
            for (int i = 0; i < filter_list.Count; i++)
            {
                sb.Append(i > 0 ? " and " : " where ");
                string param_name = string.Format("@__{0}__", filter_list[i].Name);
                sb.AppendFormat(" [{0}] = {1} ", filter_list[i].Name, param_name);
                paramlist.Add(param_name, filter_list[i].Value);
            }

            // return GetListBySql<T>(transaction, sb.ToString(), paramlist.ToArray());
            return ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramlist.ToArray());

        }

        public static int DeleteTable<T>(string connection_string, ColumnFilterList filter_list)
            where T : IEntity, new()
        {
            EntityAttribute attr = GetEntityAttribute(typeof(T));
            StringBuilder sb = new StringBuilder(100);
            ParameterBuilder paramlist = new ParameterBuilder(filter_list.Count);

            sb.Append(" delete from [");
            sb.Append(attr.TableName);
            sb.Append("] ");
            for (int i = 0; i < filter_list.Count; i++)
            {
                sb.Append(i > 0 ? " and " : " where ");
                string param_name = string.Format("@__{0}__", filter_list[i].Name);
                sb.AppendFormat(" [{0}] = {1} ", filter_list[i].Name, param_name);
                paramlist.Add(param_name, filter_list[i].Value);
            }

            // return GetListBySql<T>(transaction, sb.ToString(), paramlist.ToArray());
            return ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramlist.ToArray());

        }

    }
}
