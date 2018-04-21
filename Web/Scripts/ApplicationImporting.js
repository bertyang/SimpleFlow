
function ShowDialog()
{
	 if ( document.all("InputAlertMessage").value != "")
	 {
		alert( document.all("InputAlertMessage").value);
		document.all("InputAlertMessage").value = "";		
		var GuidName = document.all("InputGuidName").value;
		var FileName = document.all("InputFileName").value;
		var Directory = document.all("InputDirectory").value;
		window.open("FileDownload.aspx?GuidName=" + GuidName + "&FileName=" + FileName + "&Directory=" + Directory, '_self');
		//window.open(document.all("InputErrorExcelName").value );
								
	}
	if ( document.all("InputMessage").value != "" && document.all("InputAlertMessage").value == "")
	{
		alert( document.all("InputMessage").value);
		document.all("InputMessage").value = "";		
	}
	
}

function CheckPatent()
{
	if ( CheckCounsel() == true && CheckUploadFile() == true)
	{
		return true;
	}
	else
	{
		return false;
	}
	
}

function CheckCost()
{
	
	//&& CheckCurrency()  == true
	if ( CheckCounsel() == true  && CheckCurrencyName()  == true && CheckUploadFile() == true )
	{
		return true;
	}
	else
	{
		return false;
	}			
	
}

function CheckCounsel()
{	
	var clientID = InformationControlClientID;
	
	var hint = InformationHint;	
	var divMain = document.getElementById("Main");	
	//var RadioButtonCounsels = document.getElementById("Group");
	var RadioButtonCounsels = divMain.getElementsByTagName("input");
	//var hint = InformationHint;
	for ( var i = 0; i < RadioButtonCounsels.length; i++)
	{
		if ( RadioButtonCounsels[i].checked == true)
		{
			
			return true;
		}
	}
	alert(hint[0]);
	return false;
}	

function CounselChanged()
{
	var arrayCurrencyName = ArrayCurrencyName;
	var arrayCurrencyID = ArrayCurrencyID;
	var currencyName = document.getElementById(InformationControlClientID[1]);
	var currencyID = document.getElementById(InformationControlClientID[2]);
	 
	var divMain = document.getElementById("Main");	
	var RadioButtonCounsels = divMain.getElementsByTagName("input");
	var previous = document.getElementById("InputPreviousRadio");
	
	for ( var i = 0; i < RadioButtonCounsels.length; i++)
	{
		if ( RadioButtonCounsels[i].checked == true)
		{					
			currencyName.value = arrayCurrencyName[i];
			currencyID.value = arrayCurrencyID[i];
			selectedChangeFlag = true;
			previous.value = RadioButtonCounsels[i].id;
			//alert(currencyID.value);
			//return;
			break;
		}
	}
}

function UploadBeforeChangeCounsel() {
	// add the prompt message when change the counsel to another
	var returnValue = false;
	var source = event.srcElement;
	var hidden = document.getElementById("InputPreviousRadio");
	if (hidden == null) {
		return;
	}
	
	var previousRadio = document.getElementById(hidden.value);
	//alert(source);
	if (previousRadio != null && previousRadio.id != source.id) {
		returnValue = confirm(InformationHint[3]);
		previousRadio.checked = !returnValue;
	}
	
	if (returnValue) {
		CounselChanged();
		var displayExport = document.getElementById(InformationControlClientID[3]);
		if (displayExport != null) {
			displayExport.style.display = "none";
		}
	}
}

function CheckUploadFile()
{ 

	var clientID = InformationControlClientID;
	
	var hint = InformationHint;	
	 		
	var uploadFile = document.getElementById(clientID[0]);
	
	if ( uploadFile.value == "")
	{
		alert(hint[1]);
		return false;
	}
		
	return true; 
}
function CheckCurrencyName()
{ 
	var clientID = InformationControlClientID;
	
	var hint = InformationHint;	
	 		
	var currencyName = document.getElementById(clientID[1]);
	
	if ( currencyName.value == "")
	{
		alert(hint[2]);
		return false;
	}
		
	return true; 
}
/*
function CheckCurrency()
{
	var clientID = InformationControlClientID;
	
    var hint = InformationHint;	
	var dropdownCurrency = document.getElementById(clientID[1]);
	if ( dropdownCurrency.selectedIndex == -1 || dropdownCurrency.selectedIndex == 0)
	{
		
		alert(hint[2]);
		dropdownCurrency.focus();
		return false;
	}
	return true;
}
*/

function SetFocus(controlClientID, message)
{	
	var e = document.getElementById(controlClientID);
	
	if (e != null )
	{
		e.focus();	
		alert(message);
	}	
}
/*---------   CostListArrayControl为DataGrid中所有可写空间的集合            ----------*/
/*-- 0:部门  1:构想编号  2:单据编号  3:服务费  4:规费  5:外国服务费  6:外国规费  7:币别
     8:费用原因  9:事务所  10:国家  11:备注  12:费用日期  --*/
function CheckBeforUpdate() {
	if (CostListArrayControl == null || CostListArrayControl.length == 0) {
		return false;
	}
	var control;
	//debugger;
	
	// check department
	control = document.getElementById(CostListArrayControl[0]);
	if (control != null && control.selectedIndex == 0) {
		control.focus();
		alert(DepartmentMessage[0]);
		return false;
	}
	
	// check serial no
	control = document.getElementById(CostListArrayControl[1]);
	if (control != null && Trim(control.value) == "") {
		control.focus();
		alert(SerialMessage[0]);
		return false;
	}

	// check cost no
	control = document.getElementById(CostListArrayControl[2]);
	if (control != null && Trim(control.value) == "") {
		control.focus();
		alert(CostNoMessage[0]);
		return false;
	}
	
	// check service fee; official fee; foreign service fee; foreign official fee
	for (var i = 0; i < 4; i++) {
		control = document.getElementById(CostListArrayControl[i + 3]);
		if (control != null) {
			if (Trim(control.value) > 99999999.99 || Trim(control.value) < -99999999.9) {
				control.focus();
				alert(NumberMessage[i]);
				return false;
			}
		}
	}
	
	// check currency
	var currency = document.getElementById(CostListArrayControl[7]);
	if (currency != null && currency.selectedIndex == 0) {
		currency.focus();
		alert(CurrencyMessage[0]);
		return false;
	}
	return true;
}

function InspectControlByType(control, tagName, message) {
	if (tagName == "select") {
		return CheckSelectOption(control, message);
	}
	else if (tagName == "input") {
		return CheckTextBoxValue(control, message);
	}
	return false;
}

function CheckSelectOption(control, message) {
	if (control.selectedIndex == 0) {
		control.focus();
		alert(message);
		return false;
	}
	return true;
}

function CheckTextBoxValue(control, message) {
	if (Trim(control.value) == "") {
		control.focus();
		alert(message);
		return false;
	}
	return true;
}

function SetDateControlValue(targetTextBox, targetImage) {
	try{		
		var textBox = window.document.getElementById(targetTextBox);		
		var image = window.document.getElementById(targetImage);		
		if(textBox != null && image != null) {
			image.onclick = function (){calendar(textBox)};
			image.style.cursor = "hand";
			textBox.onclick = function (){calendar(textBox)};
			textBox.style.cursor = "hand";
			textBox.style.backgroundColor = "#FFFFFF";
			
		}
	}
	catch(e) {
		alert(e.description);
	}
}