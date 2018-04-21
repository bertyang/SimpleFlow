using System.Data.Common;
using System.Collections.Generic;

using SimpleFlow.Entity;
using SimpleFlow.DataAccess;

namespace SimpleFlow.BusinessRules
{
    public class FormApproveList : List<FormApprove>
    {
        public FormApproveList():base()
        {
        }

        public FormApproveList(int FormId,int FormNo)
        {
            List<FormApproveInfo> listFormApproveInfo = FormApproveDataAccess.GetAll(FormId, FormNo);

            foreach (FormApproveInfo formApprove in listFormApproveInfo)
            {
                FormApprove fa = new FormApprove();

                fa.FormApproveId = formApprove.FormApproveId;
                fa.AppActor = formApprove.AppActor;
                fa.AppAssigner = formApprove.AppAssigner;
                fa.AppContent = formApprove.AppContent;
                fa.AppEmpId = formApprove.AppEmpId;
                fa.AppName = formApprove.AppName;
                fa.AppRole = formApprove.AppRole;
                fa.AppSerial = formApprove.AppSerial;
                fa.AppStatus = formApprove.AppStatus;
                fa.AppType = formApprove.AppType;
                fa.AppValue = formApprove.AppValue;
                fa.AssignReason = formApprove.AssignReason;
                fa.BeginDate = formApprove.BeginDate;
                fa.FormId = formApprove.FormId;
                fa.FormNo = formApprove.FormNo;
                fa.AppActor = formApprove.AppActor;

                this.Add(fa);
            }
        }

        public int GetMaxSerial()
        {
            if (this.Count == 0)
                return 0;

            int intCount = this.Count;
            int intMaxSerial = 0;

            for (int i = 0; i < intCount; i++)
            {
                FormApprove formApprove = this[i];

                if (formApprove == null)
                    continue;

                if (formApprove.AppSerial > intMaxSerial)
                    intMaxSerial = formApprove.AppSerial;
            }
            return intMaxSerial;
        }

        public int GetMinSerial()
        {
            if (this.Count == 0)
                return 0;

            int intCount = this.Count;
            int intMinSerial = this[0].AppSerial;

            for (int i = 0; i < intCount; i++)
            {
                FormApprove formApprove = this[i];

                if (formApprove == null)
                    continue;

                if (formApprove.AppSerial < intMinSerial)
                    intMinSerial = formApprove.AppSerial;
            }
            return intMinSerial;
        }

        public void Insert(DbTransaction trans)
        {
            for (int i = 0; i < this.Count; i++)
            {
                FormApprove formApprove = this[i];

                if (formApprove == null)
                    continue;

                formApprove.Insert(trans);
            }
        }


    }
}
