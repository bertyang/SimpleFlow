function fnRemoveBrank(sInput)
{
	try	{
		sInput = sInput.toString();
		sInput = sInput.replace(/(^\s*)|(\s*$)/g, "");
		return(sInput);
	}	catch(e)	{	alert(e.description);	}
}

//Radio event, set or unset calendar control enable 
function SetDateControlEnable(flag, targetTextBox, targetImage) {
	try{
		var textBox = window.document.getElementById(targetTextBox);
		var image = window.document.getElementById(targetImage);
		
		if(textBox != null && image != null) {
			if(flag) {
				image.onclick = function (){calendar(textBox)};
				image.style.cursor = "hand";
				textBox.onclick = function (){calendar(textBox)};
				textBox.style.cursor = "hand";
				textBox.style.backgroundColor = "#FFFFFF";
			}
			else{
				textBox.onclick = "";
				textBox.style.cursor = "";
				textBox.value = "";				
				image.onclick = "";
				image.style.cursor = "";
				textBox.style.backgroundColor = "#EEEEEE";
			}
		}
	}
	catch(e) {
		alert(e.description);
	}
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


//Radio event, set or unset textbox with image enable
function SetImageEnable(flag, targetTextBox, targetImage, hidden, transferType) {
	try{
		var textBox = window.document.getElementById(targetTextBox);
		var image = window.document.getElementById(targetImage);
		
		if(textBox != null && image != null) {
			if(flag) {
				image.disabled = false;
				image.style.cursor = "hand";
				image.onclick = function (){ShowDialog(targetTextBox, hidden, transferType)};
				textBox.style.cursor = "hand";
				textBox.onclick = function (){ShowDialog(targetTextBox, hidden, transferType)};
				textBox.style.backgroundColor = "#FFFFFF";
			}
			else{
				image.disabled = true;
				image.style.cursor = "";
				image.onclick = "";
				textBox.style.cursor = "";
				textBox.value = "";
				textBox.onclick = "";
				textBox.style.backgroundColor = "#EEEEEE";
			}
		}
	}
	catch(e) {
		alert(e.description);
	}
}

//Radio event, set or unset textbox enable
function SetTextBoxEnable(flag, targetControl) {
	try{
		var target = window.document.getElementById(targetControl);
		if(target != null) {
			if(flag) {
				target.readOnly = false;
				target.style.backgroundColor = "#FFFFFF";
			}
			else{
				target.value = "";
				target.readOnly = true;
				target.style.backgroundColor = "#EEEEEE";
			}
		}
	}
	catch(e) {
		alert(e.description);
	}
}

//Checkbox event, set or unset two textbox enable
function SetCheckBoxEnable(checkBoxID, targetTextBox, targetTextBox2) {
	try{
		var source = window.document.getElementById(checkBoxID);
		var target = window.document.getElementById(targetTextBox);
		var target2 = window.document.getElementById(targetTextBox2);
		if(source != null && target != null && target2 != null) {
			if(source.checked) {
				target.readOnly = false;
				target2.readOnly = false;
				target.style.backgroundColor = "#FFFFFF";
				target2.style.backgroundColor = "#FFFFFF";
			}
			else{
				target.value = "";
				target.readOnly = true;
				target2.value = "";
				target2.readOnly = true;
				target.style.backgroundColor = "#EEEEEE";
				target2.style.backgroundColor = "#EEEEEE";
			}
		}
	}
	catch(e) {
		alert(e.description);
	}
}

//Div show or hide
function SetDivCollapse(imageID, targetDiv) {
	try{
		var image = window.document.getElementById(imageID);
		var target = window.document.getElementById(targetDiv);
		if(image != null) {
			var ellapseType = image.getAttribute("EllapseType");
			//alert(ellapseType);
			switch(ellapseType.toUpperCase()) {
				case "COLLAPSE":
					image.src = "Images/shrink.GIF";
					image.EllapseType = "Ellapse";
					target.style.display = "none";
					break;
				case "ELLAPSE":
					image.src = "Images/spread.gif"
					image.EllapseType = "Collapse";
					target.style.display = "block";
					break;
				default:
					break;
			}
		}
	}
	catch(e) {
		alert(e.description);
	}
}

function SetDivsCollapse(imageID, targetDiv) {
	var image = window.document.getElementById(imageID);
		
	if(image != null) {
		var ellapseType = image.getAttribute("EllapseType");
		//alert(ellapseType);
		var display = "";
		switch(ellapseType.toUpperCase()) {
			case "COLLAPSE":
				image.src = "Images/shrink.GIF";
				image.EllapseType = "Ellapse";
				display = "none";
				break;
			case "ELLAPSE":
				image.src = "Images/spread.gif"
				image.EllapseType = "Collapse";
				display = "block";
				break;
			default:
				break;
		}
		
		var target = [];
	
		for (var i = 0; i < targetDiv.length; i++)
		{
			window.document.getElementById(targetDiv[i]).style.display = display;
		}

	}
}

//Add how many check box user checked on dropdownlist value
function SumSelfScore() {
	try{
		var count = 0;
		//debugger;
		if(document.getElementById(gridControlArray[0]) != null) {
			var oChildren = document.getElementById(gridControlArray[0]).all;
			if(oChildren != null) {
				var oCheckBoxes = oChildren.tags("input");
				var oLabelFooter = oChildren.tags("span");
				for(var i = 0; i < oCheckBoxes.length; i++){
					if (oCheckBoxes[i].type == "checkbox" && oCheckBoxes[i].checked) {
						count++;
					}
				}
				oLabelFooter[1].innerText = count;
			}
		}
		
		if(document.getElementById(gridControlArray[1]) != null 
		  && document.getElementById(gridControlArray[2]) != null) {
			var oDropDownList1 = document.getElementById(gridControlArray[1]).getElementsByTagName("select")[0];
			var oDropDownList2 = document.getElementById(gridControlArray[2]).getElementsByTagName("select")[0];
			if(oDropDownList1 != null && oDropDownList2 != null) {
				if(oDropDownList1.value != "") {
					count += parseInt(oDropDownList1.value);
				}
				if(oDropDownList2.value != "") {
					count += parseInt(oDropDownList2.value);
				}
			}
			var oLabel = document.getElementById(gridControlArray[3]);
			if(oLabel != null) {
				oLabel.innerText = count;
			}
		}
	}
	catch(e) {
		alert(e.description);
	}
}

//Show selectablelist through xml
function ShowDialog(textBoxID, hiddenControlID, type) {
	//debugger;
	var original = document.getElementById(textBoxID);
	var hidden = document.getElementById(hiddenControlID);
	
	var forward = "<Root><Text>" + SafeXML(original.value) + "</Text>";
		forward += "<Value>" + SafeXML(hidden.value) + "</Value></Root>";
		
	var features = "dialogWidth=345px;dialogHeight=250px;center=yes;help=no;status=no";
	var returnValue = window.showModalDialog("Selection.aspx?DATA_TYPE=" + type, forward, features);
	
	if(returnValue != null) {
		var xmlDocument = new ActiveXObject("Msxml2.DOMDocument");
		xmlDocument.loadXML(returnValue);

		var textNode = xmlDocument.selectSingleNode("/Root/Text");
		var valueNode = xmlDocument.selectSingleNode("/Root/Value");

		original.value = textNode.text;
		hidden.value = valueNode.text;
	//alert(returnValue);
	}
}

//Receive xml and parse
function InitSelectableList(listID) {
	var receive = window.dialogArguments;
	
	if(Trim(receive) == "") {
		return;
	}
	var xmlDocument = new ActiveXObject("Msxml2.DOMDocument");
	xmlDocument.loadXML(receive);

	var textNode = xmlDocument.selectSingleNode("/Root/Text");
	var valueNode = xmlDocument.selectSingleNode("/Root/Value");
	
	if(textNode.text != "" && valueNode.text != "") {
		var textArray = textNode.text.split(";");
		var valueArray = valueNode.text.split(";");
		
		var listBox = document.getElementById(listID);
		if(listBox != null) {
			for(var i = 0; i < textArray.length; i++) {
				var item = new Option(Trim(textArray[i]), Trim(valueArray[i]));
				listBox.add(item);
			}
		}
	}
}


// Page element inspect 
function CheckInput() {
    try
    {		
		var radioPublic = document.getElementById(radioControlArray[0]);
		var radioUncertain = document.getElementById(radioControlArray[1]);
		var radioStandard = document.getElementById(radioControlArray[2]);
		var radioStandardNo = document.getElementById(radioControlArray[3]);
    
		//debugger;		
		if(radioPublic != null && radioUncertain != null && radioStandard != null && radioStandardNo != null) {
			if(InspectRadioButton(radioPublic, radioUncertain, 0)) {
				if(InspectCheckBox()) {
					if(InspectTextArea()) {
						if(InspectRadioButton(radioStandard, radioStandardNo, 1)) {
							return true;
						}
					}
				}
			}
		}
    }
    catch (e) {
        alert(e.description);
    }
    return false;
}

//inspect radio and related textbox 
function InspectRadioButton(selected, unselected, type) {
	if(selected != null && unselected != null) {
		var j = parseInt(type) * 4;
		if(selected.checked == false && unselected.checked == false) {
			alert(noverltyPrompt[j]);
			if(type == "0") {
				unselected.focus();
			}
			else {
				selected.focus();
			}
			return false;
		}
		else if(selected.checked) {
			var i = parseInt(type) * 3;
			var length = i + 3;
			for(; i < length; i++) {
				var control = document.getElementById(textBoxControlArray[i]);
				if(!InspectTextBox(control, noverltyPrompt[j + 1])) {
					return false;
				}
				j++;
			}
		}
	}
	return true;
}

//Inspect checkbox for page 2
function InspectCheckBox() {
	var count = 0;
	var length = checkControlArray.length;
	var newStyle = document.getElementById(checkControlArray[length - 1]);
	if(newStyle.checked) {
		return true;
	}
	
	var flag = true;
	for(var i = 0; i < length - 1; i++) {
		var checkBox = document.getElementById(checkControlArray[i]);
		if(checkBox.checked && flag) {
			flag = InspectCheckBoxRelated(checkBox, i);
		}
		else {
			count++;
		}
	}
	if(count == 3) {
		alert(searchSitePrompt[0]);
		document.getElementById(checkControlArray[0]).focus();
		return false;
	}
	return flag;
}

function InspectCheckBoxRelated(validated, sequence) {
	var i = parseInt(sequence) * 2;
	var keyword = document.getElementById(searchSiteArray[i]);
	var patentNo = document.getElementById(searchSiteArray[i + 1]);
	
	if(InspectTextBox(keyword, searchSitePrompt[1])) {
		return InspectTextBox(patentNo, searchSitePrompt[2]);
	}
	return false;
}

//inspect textbox
function InspectTextBox(validated, errorMessage) {
    if(validated != null) {
        if(validated.value == "") {
            alert(errorMessage);
            validated.focus();
            return false;
        }
    }
    return true;
}

function InspectTextArea() {
	// if textarea control not registe, then unnecessary to inspect it's value is empty
	if (typeof(textAreaControl) == "undefined") {
		return true;
	}
	var textarea = document.getElementById(textAreaControl[0]);
	if(textarea != null) {
		if(textarea.value == "") {
			alert(descriptionPrompt[0]);
			textarea.focus();
			return false;
		}
	}
	return true;
}


//Page elements checkbox and dropdownlist inspect
function CheckElements() {
	try{
		//debugger;
		var flagDropDownList = false;
		var oChildren;
		if(gridControlArray[0] != ""){
			oChildren = document.getElementById(gridControlArray[0]).all;
		}
		var hidden = document.getElementById(gridControlArray[4]);
		if(oChildren != null && hidden != null) {
			var oCheckBoxes = oChildren.tags("input");
			for(var i = 0; i < oCheckBoxes.length; i++){
				if (oCheckBoxes[i].type == "checkbox" && oCheckBoxes[i].checked) {
					hidden.value += i + ";";
				}
			}
			if(hidden.value.length > 1) {
				hidden.value = hidden.value.substring(0, hidden.value.length - 1);
			}
		}

		var oDropDownList1 = document.getElementById(gridControlArray[1]).getElementsByTagName("select")[0];
		var oDropDownList2 = document.getElementById(gridControlArray[2]).getElementsByTagName("select")[0];
		if(oDropDownList1 != null && oDropDownList2 != null) {
			if(oDropDownList1.value == "") {
				alert(evaluationPrompt[0]);
				oDropDownList1.focus();
				return false;
			}
			if(oDropDownList2.value == "") {
				alert(evaluationPrompt[1]);
				oDropDownList2.focus();
				return false;
			}
		}
		return true;
	}
	catch(e) {
		alert(e.description);
	}
	return false;
}


function CheckTextArea(control, length){
	var copyBoard = fnRemoveBrank(window.clipboardData.getData('text'));
	if(control.value.length >= length) {
		window.event.keyCode = 0;
	}
	
	if(copyBoard.length >= length) {
		control.value = copyBoard.substring(0, length);
		window.event.cancelBubble = true;
		window.event.returnValue = false;
	}
}

function TextAreaKeyPress(control, length)
{ 
	 if (GetTextBoxLength(control) >= length)
	 {
		window.event.keyCode = 0
	 }
}

function TextAreaOnBlur(control, length) {
	if (control.value.length > length)
	{
		control.value = control.value.substring(0, length);
	}
}

function TextAreaKeyPaste(control, length)
{
	var copyBoard = window.clipboardData.getData("text");
	
	if(copyBoard != null) 
	{
		var textLength = GetTextBoxLength(control);
		if (copyBoard.length + textLength > length)
		{
			control.value += copyBoard.substring(0, length - textLength);
			window.event.cancelBubble = true;
			window.event.returnValue = false;
		}
	}
}

function GetTextBoxLength(obj)
{
	var startContent = "";
	var endContent = "";
	
	if (0 != GetCaretStart(obj))
	{
		var startContent = obj.value.substring(0, GetCaretStart(obj));
	}
	
	if (GetCaretEnd(obj) <= obj.value.length - 1)
	{
		var endContent = obj.value.substring(GetCaretEnd(obj), obj.value.length - 1);
	}
	
	var content = startContent + endContent;
	var length = content.length
	
	return length;
}

//Get the end position of the caret in the object. Note that the obj needs to be in focus first
function GetCaretEnd(obj){
	if(typeof obj.selectionEnd != "undefined")
	{
		return obj.selectionEnd;
	}
	else if(document.selection&&document.selection.createRange)
	{
		var M = document.selection.createRange();
		try
		{
			var Lp = M.duplicate();
			Lp.moveToElementText(obj);
		}
		catch(e)
		{
			var Lp = obj.createTextRange();
		}
		Lp.setEndPoint("EndToEnd",M);
		var rb = Lp.text.length;
		if(rb > obj.value.length)
		{
			return -1;
		}
		return rb;
	}
}
// Get the start position of the caret in the object
function GetCaretStart(obj)
{
	if(typeof obj.selectionStart != "undefined")
	{
		return obj.selectionStart;
	}
	else if(document.selection&&document.selection.createRange)
	{
		var M=document.selection.createRange();
		try
		{
			var Lp = M.duplicate();
			Lp.moveToElementText(obj);
		}
		catch(e)
		{
			var Lp = obj.createTextRange();
		}
		Lp.setEndPoint("EndToStart",M);
		var rb = Lp.text.length;
		if(rb > obj.value.length)
		{
			return -1;
		}
		return rb;
	}
}

//open modal dialog for attachment link
function Link_OnClick(serial, type, labelID) {   
	var features = "dialogWidth=660px;dialogHeight=340px;scrollbars=yes;help=no;resizable=no;status=no;center=yes";
    var returnValue = window.showModalDialog("FileList.aspx?Serial=" + serial + "&Type=" + type, "", features);
	var label = document.getElementById(labelID);
    if (returnValue != null) {
		label.innerHTML = "<nobr>" + returnValue + "</nobr>";
		if(returnValue == "") {
			label.innerHTML = "<nobr>&nbsp;</nobr>";
		}
    }
}

//prompt user next operation
function Delete_Check(confirmAlert) {
	return confirm(confirmAlert);
}

//check info for legal page
function InspectLegalBasicInfo() {
	var length = engineer.length;
	for(var i = 0; i < length; i++) {
		var textbox = document.getElementById(engineer[i]);
		if(textbox != null && textbox.value == "") {
			alert(engineerPrompt[i]);
			textbox.focus();
			return false;
		}
	}
	var lengthCheckBox = LegalStatusElement.length;
	var flag = false;
	//debugger;
	var j = 0;
	for (var i = 0; i < lengthCheckBox;){
		if (InspectLegalBasicInputDate(LegalStatusElement[i], LegalStatusElement[i + 1], LegalStatusMessage[j])) {
			flag = true;
		}
		else {
			flag = false;
		}
		i = i + 3;
		j++;
		if (flag == false) {
			return false;
		}
	}
	return flag;
}

//if check box checked, then textbox allow not null
function InspectLegalBasicInputDate(checkBox, textBox, message) {
	//debugger;
	var check = document.getElementById(checkBox);
	var date = document.getElementById(textBox);
	if (check != null && date != null) {
		if (check.checked && Trim(date.value) == "") {
			alert(message);
			date.focus();
			return false;
		}
		return true;
	}
	return false;
}

//check what bonus legal select
function InsepctApplyCountry() {
	var length = applyCountry.length;
	for(var i = 0; i < length; i++) {
		var select = document.getElementById(applyCountry[i]);
		var textbox = document.getElementById(applyCountryRelated[i]);
		if(select != null && textbox != null){
			if(!CheckSelected(select, textbox, bonusPrompt[i])){
				return false;
			}
		}
	}
	return true;
}

function DropDownListRelated(list, targetTextBox, targetImage) {
	var dropdownlist = document.getElementById(list);
	if(dropdownlist != null) {
		if(dropdownlist.value == fixedCode[0]) {
			SetDateControlEnable(true, targetTextBox, targetImage);
		}
		else {
			SetDateControlEnable(false, targetTextBox, targetImage);
		}
	}
}

function CheckSelected(selected, textbox, message) {
	if(selected.value == fixedCode[0] && textbox.value == "") {
		alert(message);
		textbox.focus();
		return false;
	}
	return true;
}

//common inspect checkbox for legal
function LegalCheckBox(checkBox, textBox, imageButton) {
	var	check = document.getElementById(checkBox);
	var	date = document.getElementById(textBox);
	var image = document.getElementById(imageButton);
	if(check != null && date != null) {
		if(check.checked) {
			date.value = DateDemo();
			image.onclick = function (){calendar(date)};
			image.style.cursor = "hand";
			date.onclick = function (){calendar(date)};
			date.style.cursor = "hand";
			date.className = "TextBoxDateSmallCss";
		}
		else {
			date.value = "";
			date.onclick = "";
			date.style.cursor = "";			
			image.onclick = "";
			image.style.cursor = "";
			date.className = "TextBoxDateSmallCssReadOnly";
		}
	}
}

//get today
function DateDemo(){
   var today = new Date();
   var time = "";     
   time += today.getYear() + "/";
   time += (today.getMonth() + 1) + "/";            
   time += today.getDate() ;                   
                       
   return(formatDateS(time));                               
}

function (){
	var checkBox;
	var date;
	for(var i = 0; i < checkBoxDate.length; i++) {
		checkBox = document.getElementById(checkBoxDate[i]);
		date = document.getElementById(textBoxDate[i]);
		if(checkBox != null && date != null) {
			LegalCheckBox(checkBox, date);
		}
	}
}

function OpenWebSite() {
	var url = "PatentWebSite.htm";
	OpenWindowBySize(url, 750, 300);
}