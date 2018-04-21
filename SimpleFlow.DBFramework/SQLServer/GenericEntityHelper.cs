using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using SimpleFlow.SystemFramework;

namespace SimpleFlow.DBFramework.SQLServer
{
    public abstract class EntityHelper<T> : IEntityHelper<T>
        where T : IEntity, new()
    {
        public abstract void Insert(SqlTransaction transaction, T entity);

        public abstract void Insert(SqlConnection connection, T entity);

        public abstract void Insert(string connection_string, T entity);

        public abstract void Update(SqlTransaction transaction, T entity);

        public abstract void Update(SqlConnection connection, T entity);

        public abstract void Update(string connection_string, T entity);

        public abstract void Delete(SqlTransaction transaction, T entity);

        public abstract void Delete(SqlConnection connection, T entity);

        public abstract void Delete(string connection_string, T entity);

        public abstract T Row2Entity(DataRow row);

        public abstract T Retrieve(SqlTransaction transaction, T entity);

        public abstract T Retrieve(SqlConnection connection, T entity);

        public abstract T Retrieve(string connection_string, T entity);

        public List<T> DataTable2List(DataTable data)
        {
            List<T> list = new List<T>(data.Rows.Count);
            foreach (DataRow row in data.Rows)
            {
                list.Add(Row2Entity(row));
            }
            return list;
        }



        #region IEntityHelper<T> Members

        void IEntityHelper<T>.Insert(SqlTransaction transaction, T entity)
        {
            this.Insert(transaction, entity);
        }

        void IEntityHelper<T>.Update(SqlTransaction transaction, T entity)
        {
            this.Update(transaction, entity);
        }

        void IEntityHelper<T>.Delete(SqlTransaction transaction, T entity)
        {
            this.Delete(transaction, entity);
        }

        void IEntityHelper<T>.Insert(SqlConnection connection, T entity)
        {
            this.Insert(connection, entity);
        }

        void IEntityHelper<T>.Update(SqlConnection connection, T entity)
        {
            this.Update(connection, entity);
        }

        void IEntityHelper<T>.Delete(SqlConnection connection, T entity)
        {
            this.Delete(connection, entity);
        }

        void IEntityHelper<T>.Insert(string connection_string, T entity)
        {
            this.Insert(connection_string, entity);
        }

        void IEntityHelper<T>.Update(string connection_string, T entity)
        {
            this.Update(connection_string, entity);
        }

        void IEntityHelper<T>.Delete(string connection_string, T entity)
        {
            this.Delete(connection_string, entity);
        }

        T IEntityHelper<T>.Row2Entity(DataRow row)
        {
            return this.Row2Entity(row);
        }

        T IEntityHelper<T>.Retrieve(SqlTransaction transaction, T entity)
        {
            return this.Retrieve(transaction, entity);
        }

        T IEntityHelper<T>.Retrieve(SqlConnection connection, T entity)
        {
            return this.Retrieve(connection, entity);
        }

        T IEntityHelper<T>.Retrieve(string connection_string, T entity)
        {
            return this.Retrieve(connection_string, entity);
        }


        #endregion

        #region IEntityHelper Members

        void IEntityHelper.Insert(SqlTransaction transaction, IEntity entity)
        {
            this.Insert(transaction, (T)entity);
        }

        void IEntityHelper.Insert(SqlConnection connection, IEntity entity)
        {
            this.Insert(connection, (T)entity);
        }

        void IEntityHelper.Insert(string connection_string, IEntity entity)
        {
            this.Insert(connection_string, (T)entity);
        }

        void IEntityHelper.Update(SqlTransaction transaction, IEntity entity)
        {
            this.Update(transaction, (T)entity);
        }

        void IEntityHelper.Update(SqlConnection connection, IEntity entity)
        {
            this.Update(connection, (T)entity);
        }

        void IEntityHelper.Update(string connection_string, IEntity entity)
        {
            this.Update(connection_string, (T)entity);
        }

        void IEntityHelper.Delete(SqlTransaction transaction, IEntity entity)
        {
            this.Delete(transaction, (T)entity);
        }

        void IEntityHelper.Delete(SqlConnection connection, IEntity entity)
        {
            this.Delete(connection, (T)entity);
        }

        void IEntityHelper.Delete(string connection_string, IEntity entity)
        {
            this.Delete(connection_string, (T)entity);
        }

        object IEntityHelper.Row2Object(DataRow row)
        {
            return this.Row2Entity(row);
        }

        object IEntityHelper.Retrieve(SqlTransaction transaction, IEntity entity)
        {
            return this.Retrieve(transaction, (T)entity);
        }

        object IEntityHelper.Retrieve(SqlConnection connection, IEntity entity)
        {
            return this.Retrieve(connection, (T)entity);
        }

        object IEntityHelper.Retrieve(string connection_string, IEntity entity)
        {
            return this.Retrieve(connection_string, (T)entity);
        }

        #endregion
    }
}
