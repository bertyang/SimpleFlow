using System.Data.Common;

using SimpleFlow.Entity;
using SimpleFlow.DataAccess;

namespace SimpleFlow.BusinessRules
{
    public class FormApprove : FormApproveInfo
    {
        public FormApprove()
        { 
        }

        public FormApprove(string formApproveId)
        {
            this.FormApproveId = formApproveId;

            FormApproveInfo formApprove = FormApproveDataAccess.GetFormApprove(formApproveId);
   
            this.AppActor=formApprove.AppActor;
            this.AppAssigner = formApprove.AppAssigner;
            this.AppContent = formApprove.AppContent;
            this.AppEmpId = formApprove.AppEmpId;
            this.AppName = formApprove.AppName;
            this.AppRole = formApprove.AppRole;
            this.AppSerial = formApprove.AppSerial;
            this.AppStatus = formApprove.AppStatus;
            this.AppType = formApprove.AppType;
            this.AppValue = formApprove.AppValue;
            this.AssignReason = formApprove.AssignReason;
            this.BeginDate = formApprove.BeginDate;
            this.EndDate = this.EndDate;
            this.FormId = formApprove.FormId;
            this.FormNo = formApprove.FormNo;
            this.AppActor = formApprove.AppActor;
        }

        public void Insert(DbTransaction trans)
        {
            FormApproveDataAccess.Insert(trans, GetFormApproveInfo());
        }

        public void Update(DbTransaction trans)
        {
            FormApproveDataAccess.Update(trans, GetFormApproveInfo());
        }

        private FormApproveInfo GetFormApproveInfo()
        {
            FormApproveInfo fa = new FormApproveInfo();

            fa.FormApproveId = this.FormApproveId;
            fa.AppActor = this.AppActor;
            fa.AppAssigner = this.AppAssigner;
            fa.AppContent = this.AppContent;
            fa.AppEmpId = this.AppEmpId;
            fa.AppName = this.AppName;
            fa.AppRole = this.AppRole;
            fa.AppSerial = this.AppSerial;
            fa.AppStatus = this.AppStatus;
            fa.AppType = this.AppType;
            fa.AppValue = this.AppValue;
            fa.AssignReason = this.AssignReason;
            fa.BeginDate = this.BeginDate;
            fa.EndDate = this.EndDate;
            fa.FormId = this.FormId;
            fa.FormNo = this.FormNo;
            fa.AppActor = this.AppActor;

            return fa;
        }

    }
}
