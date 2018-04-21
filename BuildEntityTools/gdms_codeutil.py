#!/usr/bin/python
# Filename: mssql_codeutil.py


from mssql_datamodel import *


class code_util:
    @staticmethod
    def convert_to_identifier ( s ):
        if len(s) <= 0 :
            return s        
        s1 = s.title()
        s2 = s1.replace(' ', '')
        s3 = s2.replace('_', '')
        return s3

    @staticmethod
    def table_name_to_class_name(table_name):
        if len(table_name) <= 0 :
            return table_name
        prefix = "TBL_"
        prefix_length = len(prefix)
        if table_name.upper().startswith(prefix):
            table_name = table_name[prefix_length : len(table_name) - prefix_length]
        return code_util.convert_to_identifier( table_name )


    @staticmethod
    def column_name_to_property_name(column_name):
        return code_util.convert_to_identifier(column_name)

    @staticmethod
    def get_method_param_name(column):
        assert isinstance(column, sql_column)
        column_name = column.column_name
        return column_name[0].lower().join(column_name[1: len(column_name)-1])
        
    
class csharp_file_writer:
    def __init__(self, file_path):
        #assert isinstance(file_path, string)
        #assert os.path.exists(file_path)
        self.__file = file(file_path, 'w')

        self.__max_length = 256
        self.__indent_blank = "    "
        self.__indent_times = 0

    def __del__(self):
        self.__file.close()

    def close(self):
        self.__file.close()

    def add_indent(self):
        self.__indent_times = self.__indent_times + 1

    def dec_indent(self):
        self.__indent_times = self.__indent_times - 1

    def write_indent(self):
        for i in range(0, self.__indent_times):
            self.__file.write(self.__indent_blank)

    def write(self, *args):
        for s in args:
            self.__file.write(s)

    def write_using(self, name_space):
        self.write_indent()
        self.__file.write('using ')
        self.__file.write(name_space)
        self.__file.write(';')
        self.new_line()

    def write_indent_line(self, *args):
        self.write_indent()
        for s in args:
            self.__file.write(s)
        self.new_line()

    def new_line(self, num=1):
        for i in range(0, num):
            self.__file.write('\n')

    def start_segment(self):
        self.write_indent_line('{')
        self.add_indent()

    def end_segment(self):
        self.dec_indent()   
        self.write_indent_line('}')

    def write_summary_note(self, *summary_list):
        self.write_indent_line('/// <summary>')
        #todo: string must process < and >, else note are error
        for summary_item in summary_list:
            self.write_indent_line('/// ', summary_item)
        self.write_indent_line('/// </summary>')

    def write_remarks_note(self, remarks):
        self.write_indent_line('/// <remarks>%s</remarks>'%(remarks))

    def write_param_note(self, param_name, param_desc):
        self.write_indent_line('''/// <param name="%s">%s</param>'''%(param_name, param_desc))

    def write_returns_note(self, returns) :
        self.write_indent_line('''/// <returns>%s</returns>'''%(returns))
    
        

class entity_class_builder:
    def __init__(self, table):
        self.table = table
        self.entity_class_name = self.table.csharp_class_name
        self.helper_class_name = self.entity_class_name + 'InfoHelper'
        
        
    #write file with unicode
    def build_to_file(self, file_path, name_space=''):
        #assert isinstance(file_path, string)
        writer = csharp_file_writer(file_path)
        try:
            self.__build_code(writer, name_space)
        finally:
            writer.close()

    def __build_code(self, writer, name_space=''):
        # write using list
        print self.table.data_model.model_name
        #for s in self.table.data_model.using_list:
        #    writer.write_using(s)
        writer.write_using('System')
        writer.write_using('System.Text')
        writer.write_using('System.Collections')
        writer.write_using('System.Collections.Generic')
        writer.write_using('System.Collections.Specialized')
        writer.write_using('SimpleFlow.DBFramework.SQLServer')
        writer.new_line()
        if name_space == '' :
            name_space = self.table.data_model.name_space
        writer.write_indent_line('namespace ', name_space)
        writer.start_segment()
        writer.write_summary_note(self.table.table_name)

        #write attribute
        writer.write_indent_line("""[SimpleFlow.DBFramework.SQLServer.Entity("%s", typeof(%s))]"""%(self.table.table_name,
                                                                                      self.helper_class_name))
        
        writer.write_indent_line('public class %sInfo : SimpleFlow.SystemFramework.IEntity'%(self.entity_class_name))
        writer.start_segment()

        self.__build_constructor_1(writer)
        self.__build_constructor_2(writer)

        for column in self.table.column_list:
            self.__build_property_code(writer, column)
        writer.end_segment()
        writer.end_segment()

    def __build_property_code(self, writer, column):
        assert isinstance(column, sql_column)
        writer.new_line()
        property_name = column.csharp_property_name
        field_name = 'm_' + column.csharp_property_name
        data_type = column.data_type.get_csharp_type_string(column.length, column.scale)
        writer.write_indent_line('private ', data_type, ' ', field_name, ';')

        writer.new_line()
        
        writer.write_summary_note(column.column_name)
        writer.write_indent_line('public ', data_type, ' ', property_name)
        writer.start_segment()
        writer.write_indent_line('get')
        writer.start_segment()
        writer.write_indent_line('return ', field_name, ';')
        writer.end_segment()
        writer.write_indent_line('set')
        writer.start_segment()
        writer.write_indent_line(field_name, ' = value;')
        writer.end_segment()
        writer.end_segment()
    def __build_constructor_1(self, writer):
        writer.write_indent_line("public %sInfo()"%(self.entity_class_name))
        writer.start_segment()
        writer.end_segment()
    def __build_constructor_2(self, writer):
        writer.write_indent();
        writer.write("public %sInfo("%(self.entity_class_name))
        pk_list = self.table.get_primary_keys()
        for i in range(len(pk_list)):
            if i > 0 :                
                writer.write(",")
            column = pk_list[i]
            writer.write(column.data_type.get_csharp_type_string(column.length, column.scale))
            writer.write(' _%s'%(column.csharp_property_name))
        writer.write(")")
        writer.new_line()
        writer.start_segment()
        for column in pk_list :
            writer.write_indent_line('m_%s = _%s;'%(column.csharp_property_name, column.csharp_property_name))
        writer.end_segment()

class collection_class_builder:
    def __init__(self, table):
        self.table = table
    def __build_constructor(self, writer):
        writer.new_line()
        writer.write_indent_line('public ', self.table.csharp_class_name, 'Collection() : base()')
        writer.start_segment()        
        writer.end_segment()
    def __build_constructor2(self, writer):
        writer.new_line()
        writer.write_indent_line('public ', self.table.csharp_class_name, 'Collection(int capacity) : base(capacity)')
        writer.start_segment()        
        writer.end_segment()
    def __build_constructor3(self, writer):
        '''writer.new_line()
        writer.write_indent_line('internal %sCollection(System.Data.DataTable data)'%(self.table.csharp_class_name))
        writer.start_segment()
        writer.write_indent_line('foreach(System.Data.DataRow row in data.Rows)')
        writer.start_segment()
        writer.write_indent_line('this.List.Add(new %s(row));'%(self.table.csharp_class_name))
        writer.end_segment()
        writer.end_segment()'''
        pass

    def __build_add(self, writer):
        writer.new_line()
        writer.write_indent_line('public void Add(%s item)'%(self.table.csharp_class_name))
        writer.start_segment()
        writer.write_indent_line('this.List.Add(item);')
        writer.end_segment()
    def __build_remove(self, writer):
        writer.new_line()
        writer.write_indent_line('public void Remove(%s item)'%(self.table.csharp_class_name))
        writer.start_segment()
        writer.write_indent_line('this.List.Remove(item);')
        writer.end_segment()
    def __build_enumerator(self, writer):
        writer.new_line()
        writer.write_indent_line('public %s this[int index]'%(self.table.csharp_class_name))
        writer.start_segment()
        writer.write_indent_line('get')
        writer.start_segment()
        writer.write_indent_line('return (%s)this.List[index];'%(self.table.csharp_class_name))
        writer.end_segment()
        writer.write_indent_line('set')
        writer.start_segment()
        writer.write_indent_line('this.List[index] = value;')
        writer.end_segment()
        writer.end_segment()

    def __build_contains(self, writer):
        writer.new_line()
        writer.write_indent_line('public bool Contains(%s item)'%(self.table.csharp_class_name))
        writer.start_segment()
        writer.write_indent_line('return this.List.Contains(item);')
        writer.end_segment()

    def __build_copyto(self, writer):
        writer.new_line()
        writer.write_indent_line('public void CopyTo(%s[] array, int index)'%(self.table.csharp_class_name))
        writer.start_segment()
        writer.write_indent_line('this.List.CopyTo(array, index);')
        writer.end_segment()

    def __build_insert(self, writer):
        writer.new_line()
        writer.write_indent_line('public void Insert(int index, %s item)'%(self.table.csharp_class_name))
        writer.start_segment()
        writer.write_indent_line('this.List.Insert(index, item);')
        writer.end_segment()

    def __build_code(self, writer, name_space=''):
        if name_space == '' :
            name_space = self.table.data_model.name_space
        class_name = self.table.csharp_class_name
        writer.write_using('System')
        writer.write_using('System.Text')
        writer.write_using('System.Data')
        writer.write_using('System.Collections')

        writer.new_line()
        writer.write_indent_line('namespace ', name_space)
        writer.start_segment()
        writer.write_summary_note(self.table.description)
        writer.write_indent_line('public class %sCollection : System.Collections.CollectionBase'%(class_name))
        writer.start_segment()

        self.__build_constructor(writer)
        self.__build_constructor2(writer)
        self.__build_constructor3(writer)
        self.__build_add(writer)
        self.__build_remove(writer)
        self.__build_enumerator(writer)
        self.__build_contains(writer)
        self.__build_copyto(writer)
        self.__build_insert(writer)
        writer.end_segment()
        writer.end_segment()

    def build_to_file(self, file_path, name_space=''):
        writer = csharp_file_writer(file_path)
        try:
            self.__build_code(writer, name_space)
        finally:
            writer.close()


class helper_class_builder :
    def __init__(self, table):
        self.table = table
        self.entity_class_name = self.table.csharp_class_name
        self.helper_class_name = self.entity_class_name + 'InfoHelper'

    """
    def __build_private_fields(self, writer):
        #writer.write_indent_line('private string m_ConnectionString;')
        writer.write_indent_line('private static %s __instance = null;'%(self.helper_class_name))
        writer.new_line()
    """

    def __build_constructor(self, writer):
        #writer.write_indent_line('public %s(string connectionString)'%(self.helper_class_name))
        #writer.start_segment()
        #writer.write_indent_line('m_ConnectionString = connectionString;')
        #writer.end_segment()
        
        writer.write_indent_line('public %s()'%(self.helper_class_name))
        writer.start_segment()
        writer.end_segment()

    """
    def __build_singleton_property(self, writer):
        writer.write_indent_line('public %s Instance'%(self.helper_class_name))
        writer.start_segment()
        writer.write_indent_line('get')
        writer.start_segment()
        writer.write_indent_line('if (__instance == null)')
        writer.start_segment()
        writer.write_indent_line('__instance = new %s();'%(self.helper_class_name))
        writer.end_segment()
        writer.write_indent_line('return __instance;')
        writer.end_segment()
        writer.end_segment()
    """        

    def __build_insert_internal(self, writer, conn_param_type, conn_param_name):
        writer.new_line()
        writer.write_summary_note(''' insert one %s to database '''%(self.entity_class_name))
        writer.write_indent_line('''public override void Insert(%s %s, %sInfo entity)'''%(
            conn_param_type, conn_param_name, self.entity_class_name))
        writer.start_segment()
        
        writer.write_indent_line('System.Text.StringBuilder sb = new System.Text.StringBuilder(200);')
        writer.write_indent_line('''sb.Append("insert into [%s] (");'''%(self.table.table_name))


        pk_list = self.table.get_primary_keys()
        
        if self.table.column_list.count == 0 :
            raise StandardError()
        for i in range(0, len(self.table.column_list)):
            column = self.table.column_list[i]
            if i < len(self.table.column_list) - 1 :
                writer.write_indent_line('''sb.Append("[%s],");'''%(column.column_name))
            else:
                writer.write_indent_line('''sb.Append("[%s] ");'''%(column.column_name))

        writer.write_indent_line('''sb.Append(" ) values ( ");''')
        for i in range(0, len(self.table.column_list)):
            column = self.table.column_list[i]
            if i < len(self.table.column_list) - 1:
                writer.write_indent_line('''sb.Append("@%s,");'''%(column.csharp_property_name))
            else:
                writer.write_indent_line('''sb.Append("@%s ) ");'''%(column.csharp_property_name))

        writer.new_line()
        writer.write_indent_line('''ParameterBuilder paramList = new ParameterBuilder(%d);'''%(len(self.table.column_list)))
        for i in range(0, len(self.table.column_list)):
            column = self.table.column_list[i]
            writer.write_indent_line('''paramList.Add("@%s", entity.%s);'''
                                     %(column.csharp_property_name, column.csharp_property_name))
        writer.new_line()
        
        writer.write_indent_line(
            '''SqlHelper.ExecuteNonQuery(%s, CommandType.Text, sb.ToString(), paramList.ToArray());'''%(conn_param_name))
        writer.end_segment()

    def __build_insert_1(self, writer):
        self.__build_insert_internal(writer, 'string', 'connection_string')

    def __build_insert_2(self, writer):
        self.__build_insert_internal(writer, 'SqlConnection', 'connection')

    def __build_insert_3(self, writer):
        self.__build_insert_internal(writer, 'SqlTransaction', 'transaction')

    def __build_update_internal(self, writer, conn_param_type, conn_param_name):
        
        class_name = self.table.csharp_class_name
        writer.new_line()
        
        pk_list = self.table.get_primary_keys()
        
        writer.write_indent_line('/// <summary>')
        writer.write_indent_line('/// update by the primary key, ')
        writer.write_indent()
        writer.write('/// the primary key is :')
        for pk_column in pk_list :
            writer.write( pk_column.column_name, '/' )
        writer.new_line()
        writer.write_indent_line('/// </summary>')
        
        writer.write_indent_line('public override void Update(%s %s, %sInfo entity)'%
                                 (conn_param_type, conn_param_name, class_name))
        writer.start_segment()

        need_build = True
        
        if len(self.table.column_list) == 0 :
            writer.write_indent_line('''// no any columns defined in the table.''');
            need_build = False

        
        if len(pk_list) == 0 :
            writer.write_indent_line('''// no primary keys defined in the table.''');
            need_build = False
        
        if len(self.table.column_list) <= len(pk_list): #do not need update method
            writer.write_indent_line('''// all column is primary key, need do nothing ''');
            need_build = False


        if need_build :
                            
            writer.write_indent_line('System.Text.StringBuilder sb = new System.Text.StringBuilder(200);')
            writer.write_indent_line('''sb.Append("update [%s] set ");'''%(self.table.table_name))

            col_list = self.table.get_non_primary_keys()
            for i in range(0, len(col_list)):
                column = col_list[i]
                if i < len(col_list) - 1:
                    writer.write_indent_line('''sb.Append("[%s] = @%s, ");'''%(column.column_name, column.csharp_property_name))
                else :
                    writer.write_indent_line('''sb.Append("[%s] = @%s ");'''%(column.column_name, column.csharp_property_name))

            pk_list = self.table.get_primary_keys() 
            for i in range(0, len(pk_list)):
                column = pk_list[i]            
                where_or_and = 'where'
                if i > 0 : where_or_and = 'and'
                writer.write_indent_line('''sb.Append("%s [%s] = @%s ");'''%
                                         (where_or_and,
                                          column.column_name,
                                          column.csharp_property_name))

            
            writer.write_indent_line('''ParameterBuilder paramList = new ParameterBuilder(%d);'''%(len(self.table.column_list)))
            col_index = 0
            for column in col_list:
                writer.write_indent_line('''paramList.Add("@%s", entity.%s);'''
                                         %(column.csharp_property_name, column.csharp_property_name))
                col_index = col_index + 1
            for column in pk_list :
                writer.write_indent_line('''paramList.Add("@%s", entity.%s);'''
                                         %(column.csharp_property_name, column.csharp_property_name))            
                col_index = col_index + 1
                pass

            writer.new_line()
            writer.write_indent_line('''SqlHelper.ExecuteNonQuery(%s, CommandType.Text, sb.ToString(), paramList.ToArray());'''%
                                     (conn_param_name))
            pass  # end need_build
        
        writer.end_segment()



    def __build_update_1(self, writer):        
        self.__build_update_internal(writer, 'string', 'connection_string')
        
    def __build_update_2(self, writer):
        self.__build_update_internal(writer, 'SqlConnection', 'connection')
        
        
    def __build_update_3(self, writer):
        self.__build_update_internal(writer, 'SqlTransaction', 'transaction')
        

    def __build_delete_internal(self, writer, conn_param_type, conn_param_name):
        class_name = self.table.csharp_class_name
        
        writer.new_line()
                
        pk_list = self.table.get_primary_keys()
        
        writer.write_indent_line('/// <summary>')
        writer.write_indent_line('/// delete by the primary key, ')
        writer.write_indent()
        writer.write('/// the primary key is :')
        for pk_column in pk_list :
            writer.write( pk_column.column_name, '/' )
        writer.new_line()
        writer.write_indent_line('/// </summary>')
        
        writer.write_indent_line('public override void Delete(%s %s, %sInfo entity)'%
                                 (conn_param_type, conn_param_name, class_name))
        writer.start_segment()

        need_build = True
        
        if len(self.table.column_list) == 0 :
            writer.write_indent_line('''// no any columns defined in the table.''');
            need_build = False

        if len(pk_list) == 0 :
            writer.write_indent_line('''// no primary keys defined in the table.''');
            need_build = False
        
        #if len(self.table.column_list) <= len(pk_list): #do not need update method
        #    writer.write_indent_line('''// all column is primary key, need do nothing ''');
        #    need_build = False


        if need_build :
                            
            writer.write_indent_line('System.Text.StringBuilder sb = new System.Text.StringBuilder(200);')
            writer.write_indent_line('''sb.Append("delete from [%s] ");'''%(self.table.table_name))            

            pk_list = self.table.get_primary_keys() 
            for i in range(0, len(pk_list)):
                column = pk_list[i]            
                where_or_and = 'where'
                if i > 0 : where_or_and = 'and'
                writer.write_indent_line('''sb.Append("%s [%s] = @%s ");'''%
                                         (where_or_and,
                                          column.column_name,
                                          column.csharp_property_name))

            
            writer.write_indent_line('''ParameterBuilder paramList = new ParameterBuilder(%d);'''%(len(pk_list)))
            col_index = 0
            for column in pk_list:
                writer.write_indent_line('''paramList.Add("@%s", entity.%s);'''
                                         %(column.csharp_property_name, column.csharp_property_name))
                col_index = col_index + 1            

            writer.new_line()
            writer.write_indent_line('''SqlHelper.ExecuteNonQuery(%s, CommandType.Text, sb.ToString(), paramList.ToArray());'''%
                                     (conn_param_name))
            pass  # end need_build
        
        writer.end_segment()
        
        pass
    def __build_delete_1(self, writer):        
        self.__build_delete_internal(writer, 'string', 'connection_string')
        
    def __build_delete_2(self, writer):
        self.__build_delete_internal(writer, 'SqlConnection', 'connection')
                
    def __build_delete_3(self, writer):
        self.__build_delete_internal(writer, 'SqlTransaction', 'transaction')
    def __build_fill_entity_by_row(self, writer):
        writer.new_line()
        writer.write_indent_line('/// <summary>')
        writer.write_indent_line('/// convert one row to %s'%(self.entity_class_name))
        writer.write_indent_line('/// warning: this row must include all the columns of table(%s)'%(self.table.table_name))
        writer.write_indent_line('/// </summary>')
        writer.write_param_note('row', 'a data row that include all the column of table(%s)'%(self.table.table_name))
        writer.write_returns_note('an entity of %s'%(self.entity_class_name))
        writer.write_indent_line('public void FillEntityByRow(%sInfo entity, System.Data.DataRow row)'%(self.entity_class_name))
        writer.start_segment()
        #writer.write_indent_line('%s entity = new %s();'%(self.entity_class_name, self.entity_class_name))
        column_list = self.table.column_list
        for column in column_list:
            writer.write_indent_line('''if (!row.IsNull("%s"))'''%(column.column_name))
            writer.start_segment()
            writer.write_indent_line(
                '''entity.%s = (%s)row["%s"];'''%(column.csharp_property_name,
                                                 column.data_type.get_csharp_type_string(column.length, column.scale),
                                                 column.column_name))
            writer.end_segment()
            writer.write_indent_line('else')            
            writer.start_segment()
            
            writer.end_segment()
        #writer.write_indent_line('return entity;')
        writer.end_segment()
        
    def __build_row_to_entity(self, writer):
        writer.new_line()
        writer.write_indent_line('/// <summary>')
        writer.write_indent_line('/// convert one row to %s'%(self.entity_class_name))
        writer.write_indent_line('/// warning: this row must include all the columns of table(%s)'%(self.table.table_name))
        writer.write_indent_line('/// </summary>')
        writer.write_param_note('row', 'a data row that include all the column of table(%s)'%(self.table.table_name))
        writer.write_returns_note('an entity of %s'%(self.entity_class_name))
        writer.write_indent_line('public override %sInfo Row2Entity(System.Data.DataRow row)'%(self.entity_class_name))
        writer.start_segment()
        writer.write_indent_line('%sInfo entity = new %sInfo();'%(self.entity_class_name, self.entity_class_name))
        writer.write_indent_line('FillEntityByRow(entity, row);')
        writer.write_indent_line('return entity;')
        writer.end_segment()
        
    def __build_retrieve_internal(self, writer, conn_param_type, conn_param_name):
        writer.new_line()
        writer.write_indent_line('/// <summary>')
        writer.write_indent_line('/// ')
        writer.write_indent_line('/// </summary>')
        writer.write_indent_line('public override %sInfo Retrieve(%s %s, %sInfo entity)'%(
            self.entity_class_name, conn_param_type, conn_param_name, self.entity_class_name))
        writer.start_segment()
        writer.write_indent_line('System.Text.StringBuilder sb = new System.Text.StringBuilder(200);')
        writer.write_indent_line('''sb.Append("select * from [%s] ");'''%(self.table.table_name))            

        pk_list = self.table.get_primary_keys() 
        for i in range(0, len(pk_list)):
            column = pk_list[i]            
            where_or_and = 'where'
            if i > 0 : where_or_and = 'and'
            writer.write_indent_line('''sb.Append("%s [%s] = @%s ");'''%
                                     (where_or_and,
                                      column.column_name,
                                      column.csharp_property_name))

        
        writer.write_indent_line('''ParameterBuilder paramList = new ParameterBuilder(%d);'''%(len(pk_list)))
        col_index = 0
        for column in pk_list:
            writer.write_indent_line('''paramList.Add("@%s", entity.%s);'''
                                     %(column.csharp_property_name, column.csharp_property_name))
            col_index = col_index + 1            

        writer.new_line()
        writer.write_indent_line('''DataTable data = SqlHelper.ExecuteDataTableBySql(%s, sb.ToString(), paramList.ToArray());'''%
                                 (conn_param_name))
        writer.write_indent_line('if (data.Rows.Count > 0)')
        writer.start_segment()
        writer.write_indent_line('FillEntityByRow(entity, data.Rows[0]);')
        writer.write_indent_line('return entity;')
        writer.end_segment()

        writer.write_indent_line('return null;')
        writer.end_segment()
    def __build_retrieve_1(self, writer):
        self.__build_retrieve_internal(writer, 'SqlTransaction', 'transaction')
    def __build_retrieve_2(self, writer):
        self.__build_retrieve_internal(writer, 'SqlConnection', 'connection')
    def __build_retrieve_3(self, writer):
        self.__build_retrieve_internal(writer, 'string', 'connection_string')
    

    def __build_code(self, writer, name_space=''):
        writer.write_using('System')
        writer.write_using('System.Collections')
        writer.write_using('System.Collections.Generic')
        writer.write_using('System.Text')
        writer.write_using('System.Data')
        writer.write_using('System.Data.SqlClient')
        writer.write_using('SimpleFlow.DBFramework.SQLServer')
        #writer.write_using('Microsoft.ApplicationBlocks.Data')
        writer.new_line()

        if name_space == '' :
            name_space = self.table.data_model.name_space            
        writer.write_indent_line('namespace ', name_space)
        writer.start_segment()
        writer.write_indent_line('public class %s : SimpleFlow.DBFramework.SQLServer.EntityHelper<%sInfo>'%(self.helper_class_name,
                                                                                         self.entity_class_name))
        writer.start_segment()
        #self.__build_private_fields(writer)
        #self.__build_singleton_property(writer)
        self.__build_constructor(writer)
        self.__build_insert_1(writer)
        self.__build_insert_2(writer)
        self.__build_insert_3(writer)

        self.__build_update_1(writer)
        self.__build_update_2(writer)
        self.__build_update_3(writer)

        self.__build_delete_1(writer)
        self.__build_delete_2(writer)
        self.__build_delete_3(writer)

        self.__build_fill_entity_by_row(writer)
        self.__build_row_to_entity(writer)
        self.__build_retrieve_1(writer)
        self.__build_retrieve_2(writer)
        self.__build_retrieve_3(writer)
        
        writer.end_segment()
        writer.end_segment()

    def build_to_file(self, file_path, name_space=''):
        writer = csharp_file_writer(file_path)
        try:
            self.__build_code(writer, name_space)
        finally:
            writer.close()



        # command
        #writer.end_segment()

class manager_class_builder :
    def __init__(self, table):
        self.table = table

    def __build_private_fields(self, writer):
        writer.write_indent_line('private string m_ConnectionString;')
        writer.new_line()

    def __build_constructor(self, writer):
        writer.write_indent_line('public %sManager(string connectionString)'%(self.table.csharp_class_name))
        writer.start_segment()
        writer.write_indent_line('m_ConnectionString = connectionString;')
        writer.end_segment()

    def __build_insert_internal(self, writer):
        writer.write_indent_line('System.Text.StringBuilder sb = new System.Text.StringBuilder(200);')
        writer.write_indent_line('''sb.Append("insert into [%s] (");'''%(self.table.table_name))


        pk_list = self.table.get_primary_keys()
        
        if self.table.column_list.count == 0 :
            raise StandardError()
        for i in range(0, len(self.table.column_list)):
            column = self.table.column_list[i]
            if i < len(self.table.column_list) - 1 :
                writer.write_indent_line('''sb.Append("[%s],");'''%(column.column_name))
            else:
                writer.write_indent_line('''sb.Append("[%s] ");'''%(column.column_name))

        writer.write_indent_line('''sb.Append(" ) values ( ");''')
        for i in range(0, len(self.table.column_list)):
            column = self.table.column_list[i]
            if i < len(self.table.column_list):
                writer.write_indent_line('''sb.Append("@%s,");'''%(column.csharp_property_name))
            else:
                writer.write_indent_line('''sb.Append("%s ) ");'''%(column.csharp_property_name))

        writer.write_indent_line('''SqlParameter[] paramList = new SqlParameter[%d];'''%(len(self.table.column_list)))
        for i in range(0, len(self.table.column_list)):
            column = self.table.column_list[i]
            writer.write_indent_line('''paramList[%d] = new SqlParameter("@%s", entity.%s);'''
                                     %(i, column.csharp_property_name, column.csharp_property_name))

    def __build_insert_1(self, writer):
        class_name = self.table.csharp_class_name
        writer.write_indent_line('public static void Insert(string conn_str, %s entity)'%(class_name))
        writer.start_segment()
        self.__build_insert_internal(writer)
        writer.write_indent_line('''SqlHelper.ExecuteNonQuery(conn_str, CommandType.Text, sb.ToString(), paramList);''')
        writer.end_segment()

    def __build_insert_2(self, writer):
        class_name = self.table.csharp_class_name
        writer.write_indent_line('public static void Insert(SqlConnection conn, %s entity)'%(class_name))
        writer.start_segment()
        self.__build_insert_internal(writer)
        writer.write_indent_line('''SqlHelper.ExecuteNonQuery(conn, CommandType.Text, sb.ToString(), paramList);''')
        writer.end_segment()

    def __build_insert_3(self, writer):
        class_name = self.table.csharp_class_name
        writer.write_indent_line('public static void Insert(SqlTransaction trans, %s entity)'%(class_name))
        writer.start_segment()
        self.__build_insert_internal(writer)
        writer.write_indent_line('''SqlHelper.ExecuteNonQuery(trans, CommandType.Text, sb.ToString(), paramList);''')
        writer.end_segment()

    def __build_update_internal(self, writer, conn_param_type, conn_param_name):

        class_name = self.table.csharp_class_name
        writer.write_indent_line('public static void Update(%s %s, %s entity)'%
                                 (conn_param_type, conn_param_name, class_name))
        writer.start_segment()

        need_build = True
        
        if len(self.table.column_list) == 0 :
            writer.write_indent_line('''// no any columns defined in the table.''');
            need_build = False

        pk_list = self.table.get_primary_keys()
        if len(pk_list) == 0 :
            writer.write_indent_line('''// no primary keys defined in the table.''');
            need_build = False
        
        if len(self.table.column_list) <= len(pk_list): #do not need update method
            writer.write_indent_line('''// all column is primary key, need do nothing ''');
            need_build = False


        if need_build :
                            
            writer.write_indent_line('System.Text.StringBuilder sb = new System.Text.StringBuilder(200);')
            writer.write_indent_line('''sb.Append("update [%s] set ");'''%(self.table.table_name))

            col_list = self.table.get_non_primary_keys()
            for i in range(0, len(col_list)):
                column = col_list[i]
                if i < len(col_list) - 1:
                    writer.write_indent_line('''sb.Append("[%s] = @%s, ");'''%(column.column_name, column.csharp_property_name))
                else :
                    writer.write_indent_line('''sb.Append("[%s] = @%s ");'''%(column.column_name, column.csharp_property_name))

            pk_list = self.table.get_primary_keys() 
            for i in range(0, len(pk_list)):
                column = pk_list[i]            
                where_or_and = 'where'
                if i > 0 : where_or_and = 'and'
                writer.write_indent_line('''sb.Append("%s [%s] = @%s ");'''%
                                         (where_or_and,
                                          column.column_name,
                                          column.csharp_property_name))

            
            writer.write_indent_line('''SqlParameter[] paramList = new SqlParameter[%d];'''%(len(self.table.column_list)))
            col_index = 0
            for column in col_list:
                writer.write_indent_line('''paramList[%d] = new SqlParameter("@%s", entity.%s);'''
                                         %(col_index, column.csharp_property_name, column.csharp_property_name))
                col_index = col_index + 1
            for column in pk_list :
                writer.write_indent_line('''paramList[%d] = new SqlParameter("@%s", entity.%s);'''
                                         %(col_index, column.csharp_property_name, column.csharp_property_name))            
                col_index = col_index + 1
                pass

            writer.write_indent_line('''SqlHelper.ExecuteNonQuery(%s, CommandType.Text, sb.ToString(), paramList);'''%
                                     (conn_param_name))
            pass  # end need_build
        
        writer.end_segment()



    def __build_update_1(self, writer):        
        self.__build_update_internal(writer, 'string', 'conn_str')
        
    def __build_update_2(self, writer):
        self.__build_update_internal(writer, 'SqlConnection', 'conn')
        
        
    def __build_update_3(self, writer):
        self.__build_update_internal(writer, 'SqlTransaction', 'trans')
        

    def __build_delete_internal(self, writer, conn_param_type, conn_param_value):
        class_name = self.table.csharp_class_name
        writer.write_indent_line('public static void Delete(%s %s, %s entity)'%
                                 (conn_param_type, conn_param_name, class_name))
        writer.start_segment()

        need_build = True
        
        if len(self.table.column_list) == 0 :
            writer.write_indent_line('''// no any columns defined in the table.''');
            need_build = False

        pk_list = self.table.get_primary_keys()
        if len(pk_list) == 0 :
            writer.write_indent_line('''// no primary keys defined in the table.''');
            need_build = False
        
        if len(self.table.column_list) <= len(pk_list): #do not need update method
            writer.write_indent_line('''// all column is primary key, need do nothing ''');
            need_build = False


        if need_build :
                            
            writer.write_indent_line('System.Text.StringBuilder sb = new System.Text.StringBuilder(200);')
            writer.write_indent_line('''sb.Append("update [%s] set ");'''%(self.table.table_name))

            col_list = self.table.get_non_primary_keys()
            for i in range(0, len(col_list)):
                column = col_list[i]
                if i < len(col_list) - 1:
                    writer.write_indent_line('''sb.Append("[%s] = @%s, ");'''%(column.column_name, column.csharp_property_name))
                else :
                    writer.write_indent_line('''sb.Append("[%s] = @%s ");'''%(column.column_name, column.csharp_property_name))

            pk_list = self.table.get_primary_keys() 
            for i in range(0, len(pk_list)):
                column = pk_list[i]            
                where_or_and = 'where'
                if i > 0 : where_or_and = 'and'
                writer.write_indent_line('''sb.Append("%s [%s] = @%s ");'''%
                                         (where_or_and,
                                          column.column_name,
                                          column.csharp_property_name))

            
            writer.write_indent_line('''SqlParameter[] paramList = new SqlParameter[%d];'''%(len(self.table.column_list)))
            col_index = 0
            for column in col_list:
                writer.write_indent_line('''paramList[%d] = new SqlParameter("@%s", entity.%s);'''
                                         %(col_index, column.csharp_property_name, column.csharp_property_name))
                col_index = col_index + 1
            for column in pk_list :
                writer.write_indent_line('''paramList[%d] = new SqlParameter("@%s", entity.%s);'''
                                         %(col_index, column.csharp_property_name, column.csharp_property_name))            
                col_index = col_index + 1
                pass

            writer.write_indent_line('''SqlHelper.ExecuteNonQuery(%s, CommandType.Text, sb.ToString(), paramList);'''%
                                     (conn_param_name))
            pass  # end need_build
        
        writer.end_segment()
        pass
    def __build_delete_1(self, writer):        
        self.__build_delete_internal(writer, 'string', 'conn_str')
        
    def __build_delete_2(self, writer):
        self.__build_delete_internal(writer, 'SqlConnection', 'conn')
                
    def __build_delete_3(self, writer):
        self.__build_delete_internal(writer, 'SqlTransaction', 'trans')
    

    def __build_code(self, writer, name_space=''):
        writer.write_using('System')
        writer.write_using('System.Collections')
        writer.write_using('System.Collections.Generic')
        writer.write_using('System.Text')
        writer.write_using('System.Data')
        writer.write_using('System.Data.SqlClient')
        #writer.write_using('Microsoft.ApplicationBlocks.Data')
        writer.write_using('SimpleFlow.DBFramework.SQLServer')
        writer.new_line()

        if name_space == '' :
            name_space = self.table.data_model.name_space            
        writer.write_indent_line('namespace ', name_space)
        writer.start_segment()
        writer.write_indent_line('public class %sManager'%(self.table.csharp_class_name))
        writer.start_segment()
        self.__build_private_fields(writer)
        self.__build_constructor(writer)
        self.__build_insert_1(writer)
        self.__build_insert_2(writer)
        self.__build_insert_3(writer)

        self.__build_update_1(writer)
        self.__build_update_2(writer)
        self.__build_update_3(writer)

        self.__build_delete_1(writer)
        self.__build_delete_2(writer)
        self.__build_delete_3(writer)
        
        
        writer.end_segment()
        writer.end_segment()

    def build_to_file(self, file_path, name_space=''):
        writer = csharp_file_writer(file_path)
        try:
            self.__build_code(writer, name_space)
        finally:
            writer.close()
            
    

class builder_manager:
    def __init__(self, data_model):
        assert isinstance(data_model, sql_data_model)
        self.data_model = data_model

    def set_name_space(self, name_space):
        self.name_space = name_space

    def prepare_build(self):
        for table in self.data_model.table_list:
            table.csharp_class_name = code_util.table_name_to_class_name(table.table_name)
            if table.description == None :
                table.description = table.table_name
            for column in table.column_list:
                column.csharp_property_name = code_util.column_name_to_property_name(column.column_name)
        pass

    def build_to_directory(self, file_dir, name_space=''):
        assert os.path.exists(file_dir)
        for table in self.data_model.table_list:
            _file_name = table.csharp_class_name + "Info.cs"
            _file_dir = file_dir
            if file_dir.endswith(':') :
                _file_dir = file_dir + '\\'
            _file_path = os.path.join(_file_dir, _file_name)
            _builder = entity_class_builder(table)
            _builder.build_to_file(_file_path, name_space)

        """        
        for table in self.data_model.table_list:
            _file_name = table.csharp_class_name + "Collection.cs"
            _file_dir = file_dir
            if file_dir.endswith(':'):
                _file_dir = file_dir + '\\'
            _file_path = os.path.join(_file_dir, _file_name)
            _builder = collection_class_builder(table)
            _builder.build_to_file(_file_path, name_space)
        """
        
        """
        for table in self.data_model.table_list:
            _file_name = table.csharp_class_name + "Manager.cs"
            _file_dir = file_dir
            if file_dir.endswith(':'):
                _file_dir = file_dir + '\\'
            _file_path = os.path.join(_file_dir, _file_name)
            _builder = manager_class_builder(table)
            _builder.build_to_file(_file_path, name_space)
        """
        
        for table in self.data_model.table_list:
            _file_name = table.csharp_class_name + "InfoHelper.cs"
            _file_dir = file_dir
            if file_dir.endswith(':'):
                _file_dir = file_dir + '\\'
            _file_path = os.path.join(_file_dir, _file_name)
            _builder = helper_class_builder(table)
            _builder.build_to_file(_file_path, name_space)







if __name__ == '__main__' : 
    #mgr = Sql2000DatabaseManager(('hi0-ibmsv614', 'sa', '123456', 'Northwind'))
    #mgr.get_data_model()
    #unittest.main()
    
    #connStr = connection_string(host='.', user='sa', password='123', database='Northwind')
    connStr = connection_string(host='bert-yang', user='sa', password='1', database='gdmsnew')
    manager = Sql2000DatabaseManager(connStr)
    dm = manager.get_data_model()
    print len(dm.table_list)

    

    for t in dm.table_list:
        print t.table_name

    manager.get_database_name()        

    build_mgr = builder_manager(dm)
    build_mgr.prepare_build()
    #build_mgr.build_to_directory("""D:\\temp""", name_space='GDMSNew.Entity')
    build_mgr.build_to_directory("""e:\\My Documents\\Visual Studio 2008\\Projects\\SimpleFlow\\BuildEntityTools\\output""", name_space='SimpleFlow.Entity')

    print 'build ok'
