// JScript File


function ShowDate2(target_id)
{
    var target = document.getElementById(target_id);
	var sPosition =";dialogLeft:" + window.event.clientX + ";dialogTop:" + window.event.clientY;
	var surl = "../../../GeneralPage/Calendar.aspx?select_date=" + target.value;
	alert(surl);
	var sfeature = "status:no;resizable:1;dialogWidth:350px;dialogHeight:330px" + sPosition;
	var sDate = window.showModalDialog(surl, "", sfeature);
	
	target.value = sDate;

}


