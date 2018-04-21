using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

using SimpleFlow.Entity;
using SimpleFlow.SystemFramework;
using SimpleFlow.DBFramework.SQLServer;

namespace SimpleFlow.DataAccess
{
    public class FormApproveDataAccess
    {
        public static List<FormApproveInfo> GetAll(int formId, int formNo)
        {
            ColumnFilterList cfl = new ColumnFilterList();

            cfl.Add(new ColumnFilter("form_Id", formId));

            cfl.Add(new ColumnFilter("form_no", formNo));

            return SqlHelper.QueryTable<FormApproveInfo>(Config.ConnectionString, cfl);
        }

        public static FormApproveInfo GetFormApprove(string formApproveId)
        {
            return SqlHelper.Retrieve<FormApproveInfo>(Config.ConnectionString, new FormApproveInfo(formApproveId));
        }

        public static void Update(DbTransaction tran, FormApproveInfo fa)
        {
            SqlHelper.Update((SqlTransaction)tran, fa);
        }

        public static void Insert(DbTransaction tran, FormApproveInfo fa)
        {
            SqlHelper.Insert((SqlTransaction)tran, fa);
        }

        public static List<FormApproveInfo> QueryApprovePage(int page_size, ref int page_index,
            string user_id, string form_no, out int page_count)
        {
            bool form_no_is_null = IsNullOrTrimedEmpty(form_no);

            StringBuilder from_sb = new StringBuilder(300);
            ParameterBuilder pb = new ParameterBuilder(3);

            from_sb.Append("  from [form_header],[form_approve]");

            from_sb.Append(" where form_header.form_Id=form_approve.form_Id ");
            from_sb.Append(" and form_header.form_no= form_approve.form_no ");
            from_sb.Append(" and form_approve.app_emp_id = @approverId ");
            pb.Add("@approverId", user_id);


            if (!form_no_is_null)
            {
                int int_form_no = int.Parse(form_no);
                from_sb.Append(" and form_header.form_no = @form_no ");
                pb.Add("@form_no", int_form_no);
            }

            from_sb.Append(" and form_header.form_status <> 'DE' and form_approve.app_status='U' ");

            StringBuilder count_sb = new StringBuilder(from_sb.Length + 20);
            count_sb.Append("select count(*) ");
            count_sb.Append(from_sb.ToString());

            int row_count = (int)SqlHelper.ExecuteScalar(Config.ConnectionString, CommandType.Text,
                count_sb.ToString(), pb.ToArray());

            page_count = row_count / page_size;
            if (row_count % page_size > 0)
            {
                page_count += 1;
            }

            if (page_index > page_count)
            {
                page_index = page_count;
            }
            if (page_index <= 0) page_index = 1;

            List<FormApproveInfo> list = new List<FormApproveInfo>(page_size);

            if (page_count > 0)
            {
                if (page_index == 0) page_index = 1;
                int max_row_count = page_size * page_index;

                StringBuilder data_sb = new StringBuilder(from_sb.Length + 20);
                data_sb.AppendFormat(" select top {0} form_approve.* ", max_row_count);
                data_sb.Append(from_sb.ToString());
                data_sb.Append(" order by form_header.form_Id asc, form_header.form_no desc ");

                DataTable data = SqlHelper.ExecuteDataTableBySql(Config.ConnectionString,
                    data_sb.ToString(), pb.ToArray());


                for (int row_index = max_row_count - page_size;
                    row_index < max_row_count; row_index++)
                {
                    if ((row_index >= 0) && (row_index < data.Rows.Count))
                    {
                        DataRow row = data.Rows[row_index];
                        list.Add((new FormApproveInfoHelper()).Row2Entity(row));
                    }
                    else if (row_index >= data.Rows.Count)
                    {
                        break;
                    }
                }
            }

            return list;
        }

        private static bool IsNullOrTrimedEmpty(string s)
        {
            if (s == null)
            {
                return true;
            }
            if (s.Length == 0)
            {
                return true;
            }
            if (s.Trim().Length == 0)
            {
                return true;
            }
            return false;
        }
    }
}
