using System;
using System.Data.Common;
using System.Collections.Generic;

using SimpleFlow.Entity;
using SimpleFlow.DataAccess;

namespace SimpleFlow.BusinessRules
{
    public class FormHeader : FormHeaderInfo
    {
        public FormHeader()
        {
        }
      
        public FormHeader(string _FormHeaderId)
        {
            FormHeaderId = _FormHeaderId;

            FormHeaderInfo formHeader = FormHeaderDataAccess.GetFormHeader(_FormHeaderId);

            this.Applyer=formHeader.Applyer;
            this.BeginDate = formHeader.BeginDate;
            this.EndDate = formHeader.EndDate;
            this.Filler = formHeader.Filler;
            this.FormId = formHeader.FormId;
            this.FormNo = formHeader.FormNo;
            this.FormStatus = formHeader.FormStatus;
        }

        public FormHeader(int formId, int formNo)
        {
            this.FormId = formId;
            this.FormNo = formNo;

            List<FormHeaderInfo> listFormHeader = FormHeaderDataAccess.GetFormHeader(formId,formNo);

            if (listFormHeader.Count > 0)
            {
                this.Applyer = listFormHeader[0].Applyer;
                this.BeginDate = listFormHeader[0].BeginDate;
                this.EndDate = listFormHeader[0].EndDate;
                this.Filler = listFormHeader[0].Filler;
                this.FormHeaderId = listFormHeader[0].FormHeaderId;
                this.FormStatus = listFormHeader[0].FormStatus;
            }
            else
            {
                this.FormHeaderId = Guid.NewGuid().ToString("D").ToUpper();
                this.BeginDate = DateTime.Now;
                this.EndDate = DateTime.MaxValue;
                this.FormStatus = "UA";
            }
        }

        public void Insert(DbTransaction trans)
        {
            FormHeaderDataAccess.Insert(trans, GetFormHeaderInfo());
        }

        public void Update(DbTransaction trans)
        {

            FormHeaderDataAccess.Update(trans, GetFormHeaderInfo());
        }

        private FormHeaderInfo GetFormHeaderInfo()
        {
            FormHeaderInfo fh = new FormHeaderInfo();

            fh.FormHeaderId = this.FormHeaderId;
            fh.Applyer = this.Applyer;
            fh.BeginDate = this.BeginDate;
            fh.EndDate = this.EndDate;
            fh.Filler = this.Filler;
            fh.FormId = this.FormId;
            fh.FormNo = this.FormNo;
            fh.FormStatus = this.FormStatus;

            return fh;
        }

    }
}
