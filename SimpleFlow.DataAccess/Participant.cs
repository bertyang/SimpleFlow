using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using SimpleFlow.Entity;
using SimpleFlow.SystemFramework;
using SimpleFlow.DBFramework.SQLServer;

namespace SimpleFlow.DataAccess
{
    public class ParticipantDataAccess
    {
        public static ParticipantInfo GetParticipant(string participantId)
        {
            return SqlHelper.Retrieve<ParticipantInfo>(Config.ConnectionString, new ParticipantInfo(participantId));
        }

        public static object GetParticipantField(string participantId, int formNo)
        {
            ParticipantFieldInfo mdField = SqlHelper.Retrieve<ParticipantFieldInfo>(Config.ConnectionString, new ParticipantFieldInfo(participantId));

            return CommonDataAccess.GetColomnValue(mdField.FieldName, mdField.TableName, formNo);
        }

        public static ParticipantOrgInfo GetParticipantOrg(string participantId)
        {
            return SqlHelper.Retrieve<ParticipantOrgInfo>(Config.ConnectionString, new ParticipantOrgInfo(participantId));
        }

        public static List<ParticipantInfo> GetParticipantByActive(string ActiveId)
        {
            ColumnFilterList cfl = new ColumnFilterList();

            cfl.Add(new ColumnFilter("active_id", ActiveId));

            return SqlHelper.QueryTable<ParticipantInfo>(Config.ConnectionString, cfl);
        }

        public static void UpdateParticipantOrg(ParticipantOrgInfo org)
        {
            SqlHelper.Update(Config.ConnectionString, org);
        }

        public static void InsertParticipantOrg(ParticipantOrgInfo org)
        {
            SqlHelper.Insert(Config.ConnectionString, org);
        }

    }
}
