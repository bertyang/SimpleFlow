using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFlow.BusinessRules
{	public class Approver
	{
		public Approver()
		{
			m_strApproveRole = "";
			m_strApproverName = "";
			//
			// TODO: Add constructor logic here
			//
		}
		public Approver(string p_strApproverId,string p_strApproverName,string p_strApproveRole,int p_intSequenceNo)
		{
			m_strApproverId = p_strApproverId;
			m_strApproverName = p_strApproverName;
			m_strApproveRole = p_strApproveRole;
			m_intSequenceNo = p_intSequenceNo;
		}
		string m_strApproverId;

		string m_strApproverName;

		string m_strApproveRole;

		int m_intSequenceNo;

		public string ApproverId
		{
			get
			{
				return m_strApproverId;
			}
			set
			{
				if(m_strApproverId != value)
					m_strApproverId = value;
			}
		}

		public string ApproverName
		{
			get
			{
				return m_strApproverName;
			}
			set
			{
				if(m_strApproverName != value)
					m_strApproverName = value;
			}
		}

		public string ApproveRole
		{
			get
			{
				return m_strApproveRole;
			}
			set
			{
				if(m_strApproveRole != value)
					m_strApproveRole = value;
				if(value == null)
					m_strApproveRole = "";
			}
		}

		public int SequenceNo
		{
			get
			{
				return m_intSequenceNo;
			}
			set
			{
				if(m_intSequenceNo != value)
					m_intSequenceNo = value;
			}
		}
	}
}

