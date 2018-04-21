#!/usr/bin/python
# Filename: mssql_datamodel.py

import os
import pymssql
import unittest
from types import *


def singleton(class_type):
    if not class_type._instance:
        class_type._instance = class_type()
    return class_type._instance

def __select_one(condition, value_1, value_2):
    if condition == True :
        return value_1
    else :
        return value_2

class connection_string:
    def __init__(self, host, user, password, database):
        self.host = host
        self.user = user
        self.password = password
        self.database = database
        

class mssql_data_type:
    ''' static const values '''
    Const_BigInt = 127
    Const_Binary = 173
    Const_Bit = 104
    Const_Char = 175
    Const_DateTime = 61
    Const_Decimal = 106
    Const_Float = 62
    Const_Image = 34
    Const_Int = 56
    Const_Money = 60
    Const_NChar = 239
    Const_NText = 99
    Const_Numeric = 108
    Const_NVarChar = 231
    Const_Real = 59
    Const_SmallDateTime = 58
    Const_SmallInt = 52
    Const_SmallMoney = 122
    Const_SqlVariant = 98
    Const_SysName = 256
    Const_Text = 35
    Const_TimeStamp = 189
    Const_TinyInt = 48
    Const_UniqueIdentifier = 36
    Const_VarBinary = 165
    Const_VarChar = 167        

    @staticmethod
    def parse(type_id):
        if type_id == mssql_data_type.Const_BigInt:
            return singleton(mssql_bigint)
        if type_id == mssql_data_type.Const_Binary:
            return singleton(mssql_binary)
        if type_id == mssql_data_type.Const_Bit:
            return singleton(mssql_bit)
        if type_id == mssql_data_type.Const_Char:
            return singleton(mssql_char)
        if type_id == mssql_data_type.Const_DateTime:
            return singleton(mssql_datetime)
        if type_id == mssql_data_type.Const_Decimal:
            return singleton(mssql_decimal)
        if type_id == mssql_data_type.Const_Float:
            return singleton(mssql_float)
        if type_id == mssql_data_type.Const_Image:
            return singleton(mssql_image)
        if type_id == mssql_data_type.Const_Int:
            return singleton(mssql_int)
        if type_id == mssql_data_type.Const_Money:
            return singleton(mssql_money)
        if type_id == mssql_data_type.Const_NChar:
            return singleton(mssql_nchar)
        if type_id == mssql_data_type.Const_NText:
            return singleton(mssql_ntext)
        if type_id == mssql_data_type.Const_Numeric:
            return singleton(mssql_numeric)
        if type_id == mssql_data_type.Const_NVarChar:
            return singleton(mssql_nvarchar)
        if type_id == mssql_data_type.Const_Real:   
            return singleton(mssql_real)
        if type_id == mssql_data_type.Const_SmallDateTime:
            return singleton(mssql_smalldatetime)
        if type_id == mssql_data_type.Const_SmallInt:
            return singleton(mssql_smallint)
        if type_id == mssql_data_type.Const_SmallMoney:
            return singleton(mssql_smallmoney)
        if type_id == mssql_data_type.Const_SqlVariant:
            return singleton(mssql_sqlvariant)
        if type_id == mssql_data_type.Const_Text:
            return mssql_text()
        if type_id == mssql_data_type.Const_TimeStamp:
            return mssql_timestamp()
        if type_id == mssql_data_type.Const_TinyInt:
            return mssql_tinyint()
        if type_id == mssql_data_type.Const_UniqueIdentifier:
            return mssql_uniqueidentifier()
        if type_id == mssql_data_type.Const_VarBinary:
            return mssql_varbinary()
        if type_id == mssql_data_type.Const_VarChar:
            return mssql_varchar()

    def __init__(self):
        self.is_fixed_length = False
        self.fixed_length = 0
        self.max_length = 0
        

    def convert_row_data_to_csharp_code(self, column_name):
        return 'row["' + column_name + '"]'        

    def get_csharp_type_string(self, length, scale):
        return ''

    def get_default_value_string(self, length, scale):
        return ''

    def convert_data_to_sql(self, data, column_name):
        return ''

class mssql_bigint(mssql_data_type):
    _instance = None
    def __init__(self):
        mssql_data_type.__init__()
        self.is_fixed_length = True
        self.fixed_length = 8 #byte
        self.max_length = 8
    def get_csharp_type_string(self, length, scale):
        return 'System.Int64'
    def get_default_value_string(self, length, scale):
        return '0'
class mssql_binary(mssql_data_type):
    _instance = None
    def __init__(self):
        mssql_data_type.__init__()
        self.is_fixed_length = False
        self.fixed_length = 0 
        self.max_length = 8000 #byte
    def get_csharp_type_string(self, length, scale):
        return 'byte[]'
    def get_default_value_string(self, length, scale):
        return 'new byte[0]'
class mssql_bit(mssql_data_type):
    _instance = None
    def get_csharp_type_string(self, length, scale):
        return 'bool'
    def get_default_value_string(self, length, scale):
        return 'false'
class mssql_char(mssql_data_type):
    _instance = None
    def get_csharp_type_string(self, length, scale):
        return 'string'
    def get_default_value_string(self, length, scale):
        return 'string.Empty'
class mssql_datetime(mssql_data_type):
    _instance = None
    def get_csharp_type_string(self, length, scale):
        return 'System.DateTime'
    def get_default_value_string(self, length, scale):
        return ''
class mssql_decimal(mssql_data_type):
    _instance = None
    def get_csharp_type_string(self, length, scale):
        return 'decimal'
    def get_default_value_string(self, length, scale):
        return '0M'
class mssql_float(mssql_data_type):
    _instance = None
    def get_csharp_type_string(self, length, scale):
        return 'double'
    def get_default_value_string(self, length, scale):
        return '0.0'
class mssql_image(mssql_data_type):
    _instance = None
    def get_csharp_type_string(self, length, scale):
        return 'byte[]'
    def get_default_value_string(self, length, scale):
        return 'new byte[0]'
class mssql_int(mssql_data_type):
    _instance = None
    def get_csharp_type_string(self, length, scale):
        return 'int'
    def get_default_value_string(self, length, scale):
        return '0'
class mssql_money(mssql_data_type):
    _instance = None
    def get_csharp_type_string(self, length, scale):
        return 'decimal'    
    def get_default_value_string(self, length, scale):
        return '0M'
class mssql_nchar(mssql_data_type):
    _instance = None
    def get_csharp_type_string(self, length, scale):
        return 'string'    
    def get_default_value_string(self, length, scale):
        return 'string.Empty'
class mssql_ntext(mssql_data_type):
    _instance = None
    def get_csharp_type_string(self, length, scale):
        return 'string'
class mssql_numeric(mssql_data_type):
    _instance = None
    def get_csharp_type_string(self, length, scale):
        return 'decimal'
    def get_default_value_string(self, length, scale):
        return '0M'
class mssql_nvarchar(mssql_data_type):
    _instance = None
    def get_csharp_type_string(self, length, scale):
        return 'string'
    def get_default_value_string(self, length, scale):
        return 'string.Empty'
class mssql_real(mssql_data_type):
    _instance = None
    def get_csharp_type_string(self, length, scale):
        return 'System.Single'
    def get_default_value_string(self, length, scale):
        return '0'     
class mssql_smalldatetime(mssql_data_type):
    _instance = None
    def get_csharp_type_string(self, length, scale):
        return 'System.DateTime'  
    def get_default_value_string(self, length, scale):
        return ''
class mssql_smallint(mssql_data_type):
    _instance = None
    def get_csharp_type_string(self, length, scale):
        return 'System.Int16'  
    def get_default_value_string(self, length, scale):
        return '0'
class mssql_smallmoney(mssql_data_type):
    _instance = None
    def get_csharp_type_string(self, length, scale):
        return 'decimal' 
    def get_default_value_string(self, length, scale):
        return '0M'
class mssql_sqlvariant(mssql_data_type):
    _instance = None
    def get_csharp_type_string(self, length, scale):
        return 'object' 
    def get_default_value_string(self, length, scale):
        return 'new object()'
class mssql_text(mssql_data_type):
    _instance = None
    def get_csharp_type_string(self, length, scale):
        return 'string' 
    def get_default_value_string(self, length, scale):
        return 'string.Empty'
class mssql_timestamp(mssql_data_type):
    _instance = None
    def get_csharp_type_string(self, length, scale):
        return 'System.DateTime'
    def get_default_value_string(self, length, scale):
        return '0'
class mssql_tinyint(mssql_data_type):
    _instance = None
    def get_csharp_type_string(self, length, scale):
        return 'byte'
    def get_default_value_string(self, length, scale):
        return '0'
class mssql_uniqueidentifier(mssql_data_type):
    _instance = None
    def get_csharp_type_string(self, length, scale):
        return 'System.Guid'
    def get_default_value_string(self, length, scale):
        return 'System.Guid.Empty'
class mssql_varbinary(mssql_data_type):
    _instance = None
    def get_csharp_type_string(self, length, scale):
        return 'byte[]'
    def get_default_value_string(self, length, scale):
        return 'new byte[0]'
class mssql_varchar(mssql_data_type):
    _instance = None
    def get_csharp_type_string(self, length, scale):
        return 'string'   
    def get_default_value_string(self, length, scale):
        return 'string.Empty' 

class sql_column:
    def __init__(self, table):
        assert isinstance(table, sql_table)
        self.table_id = table.table_id
        self.table = table
        self.column_id = 0
        self.column_name = ''        
        self.data_type = mssql_nvarchar()
        self.is_nullable = False
        self.length = 0
        self.scale = 0
        self.description = ''
        self.csharp_property_name = ''
        self.is_primary_key = False
        self.is_identity = False
        
class sql_table:
    def __init__(self, data_model):
        assert isinstance(data_model, sql_data_model)
        self.data_model = data_model
        self.table_name = ''
        self.table_id = 0
        self.description = ''
        self.column_list = []
        self.csharp_class_name = ''
        self.manager_class_name = ''        


    def get_primary_keys(self):
        pk_column_list = []
        for column in self.column_list:
            if column.is_primary_key:
                pk_column_list.append(column)
        return pk_column_list

    def get_non_primary_keys(self):
        col_list = []
        for column in self.column_list:
            if not column.is_primary_key:
                col_list.append(column)
        return col_list
    

class sql_data_model:
    def __init__(self, model_name):
        self.database_name = model_name
        self.name_space = model_name
        self.model_name = model_name
        self.table_list = []
        self.using_list = ('System',
                           'System.Text',
                           'System.Collections',
                           'System.Collections.Generic',
                           'System.Collections.Specialized')

class Sql2000DatabaseManager:
    def __init__(self, conn_str):
        print conn_str
        if (type(conn_str) is TupleType) or (type(conn_str) is ListType) :
            self._host = conn_str[0]
            self._user = conn_str[1]
            self._password = conn_str[2]
            self._database = conn_str[3]
        elif type(conn_str) is DictType :
            self._host = conn_str['host']
            self._user = conn_str['user']
            self._password = conn_str['password']
            self._database = conn_str['database']
        else :
            self.connection_string = conn_str
            self._host = conn_str.host
            self._user = conn_str.user
            self._password = conn_str.password
            self._database = conn_str.database
        
    def get_database_name(self):
        conn = pymssql.connect(host=self._host,
                               user=self._user,
                               password=self._password,
                               database=self._database)
        cur = conn.cursor()
        sql = ' select db_name() '                                
        cur.execute(sql)
        result = cur.fetchone()
        database_name = result[0]
        conn.close()
        return database_name


    def __get_table_primary_keys(self, cur, table):
        sql = """select b.column_name 
            from information_schema.table_constraints a 
            inner join information_schema.constraint_column_usage b 
            on a.constraint_name = b.constraint_name 
            where a.constraint_type = 'PRIMARY KEY' 
            and a.table_name = %(table_name)s """

        cur.execute(sql, {'table_name' : table.table_name})
        result = cur.fetchall()
        column_list = []
        for record in result:
            column_list.append(record[0])

        return column_list
        

    def __fill_columns(self, cur, table):
        pk_list = self.__get_table_primary_keys(cur, table)
        column_sql = """ select 
            syscolumns.colid, syscolumns.name, sysproperties.value as column_description,
            syscolumns.xtype,
            syscolumns.isnullable, syscolumns.length, syscolumns.scale 
            from syscolumns 
            left outer join sysobjects on syscolumns.id = sysobjects.id 
            left outer join sysproperties 
            on syscolumns.id = sysproperties.id 
            and syscolumns.colid = sysproperties.smallid 
            where syscolumns.id = %(table_id)d 
            order by syscolumns.colid asc """
        cur.execute(column_sql, {'table_id' : table.table_id })
        column_result = cur.fetchall()
        for column_record in column_result:
            c = sql_column(table)
            c.column_id = column_record[0]
            c.column_name = column_record[1]
            c.description = column_record[2]            
            c.data_type = mssql_data_type.parse(column_record[3])
            if c.data_type == None :
                print '--' + str(column_record[3])
                print 'column = ' + c.column_name
                print 'table = ' + table.table_name
            c.is_nullable = column_record[4]
            c.length = column_record[5]
            c.scale = column_record[6]
            
            c.csharp_property_name = c.column_name
            
            #c.is_primary_key = False #pk_list.index(c.column_name) >= 0
            c.is_primary_key = c.column_name in pk_list
            table.column_list.append(c)
    

    def get_data_model(self):
        dm = sql_data_model(self._database)
        
        conn = pymssql.connect(host=self._host,
                               user=self._user,
                               password=self._password,
                               database=self._database)
        try:
            cur = conn.cursor()
            sql = """ select  
                sysobjects.[id], sysobjects.name,
                sysproperties.value as table_description  
                from dbo.sysobjects 
                left outer join sysproperties 
                on sysobjects.id = sysproperties.id 
                and sysproperties.smallid = 0 
                where OBJECTPROPERTY(sysobjects.id, N'IsUserTable') = 1  
                and sysobjects.name <> 'dtproperties' """
                        
            cur.execute(sql)

            result = cur.fetchall()
            for record in result:
                t = sql_table(dm)
                t.table_id = record[0]
                t.table_name = record[1]
                t.description = record[2]
                dm.table_list.append(t)
                self.__fill_columns(cur, t)
        finally:
            conn.close()
        return dm;
        
    def table_exists(self, table_name):
        conn = pymssql.connect(host=self._host,
                               user=self._user,
                               password=self._password,
                               database=self._database)
        try:
            cur = conn.cursor()            
            sql = """ select count(*) from dbo.sysobjects 
                where OBJECTPROPERTY(sysobjects.id, N'IsUserTable') = 1
                and sysobjects.name = %(table_name)s                 
                and sysobjects.name <> 'dtproperties'  """
            cur.execute(sql, {'table_name':table_name})
            result = cur.fetchone()
            return result[0] > 0
        finally:
            conn.close()


# ------------------------------------------------------------------------------
# ------  unit test
# ------------------------------------------------------------------------------

class case_test_table_exists(unittest.TestCase):
    def test_table_exists(self):
        mgr = Sql2000DatabaseManager({'host':'hi0-ibmsv614', 'user':'sa', 'password':'123456', 'database':'Northwind'})
        self.assert_(mgr.table_exists('Customers'))                     
        pass

    def test_table_not_exists(self):
        mgr = Sql2000DatabaseManager({'host':'hi0-ibmsv614', 'user':'sa', 'password':'123456', 'database':'Northwind'})
        self.assertEqual(mgr.table_exists('Customers2'), False)
    def test_table_not_exists_2(self):
        mgr = Sql2000DatabaseManager({'host':'hi0-ibmsv614', 'user':'sa', 'password':'123456', 'database':'Northwind'})
        self.assertEqual(mgr.table_exists("'Customers2' or (1=1) "), False)

    def test_table_not_exists_3(self):
        mgr = Sql2000DatabaseManager({'host':'hi0-ibmsv614', 'user':'sa', 'password':'123456', 'database':'Northwind'})
        self.assertEqual(mgr.table_exists("'Customers' and (1=0) "), False)                             

if __name__ == '__main__' :
    mgr = Sql2000DatabaseManager(('hi0-ibmsv614', 'sa', '123456', 'Northwind'))
    mgr.get_data_model()
    unittest.main()
        
    
