using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using SimpleFlow.SystemFramework;

namespace SimpleFlow.DBFramework.SQLServer
{
    
    public interface IEntityHelper
    {
        void Insert(SqlTransaction transaction, IEntity entity);
        void Insert(SqlConnection connection, IEntity entity);
        void Insert(string connection_string, IEntity entity);

        void Update(SqlTransaction transaction, IEntity entity);
        void Update(SqlConnection connection, IEntity entity);
        void Update(string connection_string, IEntity entity);

        void Delete(SqlTransaction transaction, IEntity entity);
        void Delete(SqlConnection connection, IEntity entity);
        void Delete(string connection_string, IEntity entity);

        object Row2Object(DataRow row);

        object Retrieve(SqlTransaction transaction, IEntity entity);
        object Retrieve(SqlConnection connection, IEntity entity);
        object Retrieve(string connection_string, IEntity entity);
    }


    public interface IEntityHelper<T> : IEntityHelper
        where T: IEntity, new()
    {
        void Insert(SqlTransaction transaction, T entity);
        void Update(SqlTransaction transaction, T entity);
        void Delete(SqlTransaction transaction, T entity);

        void Insert(SqlConnection connection, T entity);
        void Update(SqlConnection connection, T entity);
        void Delete(SqlConnection connection, T entity);

        void Insert(string connection_string, T entity);
        void Update(string connection_string, T entity);
        void Delete(string connection_string, T entity);

        T Retrieve(SqlTransaction transaction, T entity);
        T Retrieve(SqlConnection connection, T entity);
        T Retrieve(string connection_string, T entity);

        T Row2Entity(DataRow row);
    }    

}
