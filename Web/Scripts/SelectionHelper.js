
function MoveSelection(src, dest){
	var oSrc = document.getElementById(src);
	var oDest = document.getElementById(dest);
	var nSelected = oSrc.selectedIndex;
	while (nSelected != -1){
		var oOpt = oSrc(nSelected);
		oSrc.remove (nSelected);
		oDest.add (oOpt);
		nSelected = oSrc.selectedIndex;
	}
}


function MoveAll(src,dest){
	var oSrc = document.getElementById(src);
	var oDest = document.getElementById(dest);
	var nUp = oSrc.length;
	for (var i = 0; i < nUp; i++){
		var oOpt = oSrc(0);
		oSrc.remove (0);
		oDest.add (oOpt);
	}
}

function MoveAndCollectValue(src,dest,attribute,separator){
	var oSrc = document.getElementById(src);
	var oDest = document.getElementById(dest);
	var nSelected = oSrc.selectedIndex;
	var sValue = "";
	while (nSelected != -1){
		var oOpt = oSrc(nSelected);
		sValue += separator + oOpt.getAttribute(attribute);
		oSrc.remove (nSelected);
		oDest.add (oOpt);
		nSelected = oSrc.selectedIndex;
	}
	sValue = sValue.replace(separator,"");
	return sValue;
}

function MoveAllAndCollectValue(src,dest,attribute,separator){
	var oSrc = document.getElementById(src);
	var oDest = document.getElementById(dest);
	var nUp = oSrc.length;
	var sValue = "";
	for (var i = 0; i < nUp; i++){
		var oOpt = oSrc(0);
		sValue += separator + oOpt.getAttribute(attribute);
		oSrc.remove (0);
		oDest.add (oOpt);
	}
	sValue = sValue.replace(separator,"");
	return sValue;
}


function CollectSelectionValue(id,attribute,separator){
	var oSel = 	document.getElementById(id);
	if (oSel == null){
		return "";
	}
	var sValue = "";
	var nSelected = oSel.selectedIndex;
	for (var i = 0; i < oSel.length; i++){
		if (oSel(i).selected == true){
			sValue += separator + oSel.item(i).getAttribute(attribute);
		}
	}
	sValue = sValue.replace(separator,"");
	return sValue;
}

function CollectAllSelectionValue(id,attribute,separator){
	var oSel = 	document.getElementById(id);
	if (oSel == null){
		return "";
	}
	var sValue = "";
	for (var i = 0; i < oSel.length; i++){
		sValue += separator + oSel.item(i).getAttribute(attribute);
	}
	Value = sValue.replace(separator,"");
	return sValue;
}


function MoveLeftToRight(source, target){
	var i = 0;
	var sourceObj = document.getElementById(source);
	var targetObj = document.getElementById(target);
	for(var j = 0; j < sourceObj.options.length; j++){
		if(sourceObj.options(j).selected == true){
			var listItem = new Option(sourceObj.options(j).text, sourceObj.options(j).value);
			var targetFlag = false;
			for(i = 0; i < targetObj.options.length; i++){
				if(targetObj.item(i).text == sourceObj.options(j).text){
					targetFlag = true;
				}
			}
			if(targetFlag == false){
				targetObj.add(listItem);
			}
		}
	}
}

function MoveRightToLeft(target){
	var targetObj = document.getElementById(target);
	for(var j = 0; j < targetObj.options.length; j++){
		if(targetObj.options(j).selected == true){
			targetObj.remove(j);
			j--;
		}
	}
}

function MoveLeftToRightAll(source, target){
	var sourceObj = document.getElementById(source);
	var targetObj = document.getElementById(target);
	for(var j = 0; j < sourceObj.options.length; j++){
		sourceObj.item(j).selected = true;
		if(sourceObj.item(j).selected == true){
			sourceObj.item(j).selected = false;
			for(var k = 0; k < targetObj.options.length; k++){
				if(sourceObj.item(j).text == targetObj.item(k).text){
					break;
				}
			}
			if(k >= targetObj.options.length){
				var listItem = new Option(sourceObj.item(j).text, sourceObj.item(j).value);
				targetObj.add(listItem);
			}
		}
	}
}

function MoveRightAll(target){
	var targetObj = document.getElementById(target);
	for(var j = targetObj.options.length; j >= 0; j--){
		targetObj.remove(j);
	}
}

function ButtonOKAndExit(listBoxID) {
	var selectedText = "";
	var selectedValue = "";
	var targetObj = document.getElementById(listBoxID);

	for(var i = 0; i < targetObj.options.length; i++) {
		selectedText = selectedText + targetObj.item(i).text + ";";
		selectedValue = selectedValue + targetObj.item(i).value + ";";
	}
	if(selectedText.length > 1 && selectedValue.length > 1) {
		selectedText = selectedText.substring(0, selectedText.length - 1);
		selectedValue = selectedValue.substring(0, selectedValue.length - 1);
	}

	var returnXml = "<Root><Text>" + SafeXML(selectedText) + "</Text>";
		returnXml += "<Value>" + SafeXML(selectedValue) +"</Value></Root>";
		
	window.returnValue = returnXml;
	window.close();
}

//selection for report
//begin
function MoveToRight(source, target){
	var i = 0;
	var sourceObj = document.getElementById(source);
	var targetObj = DynamicListBox_FindControl(target);
	for(var j = 0; j < sourceObj.options.length; j++){
		if(sourceObj.options(j).selected == true){
			var listItem = new Option(sourceObj.options(j).text, sourceObj.options(j).value);
			var targetFlag = false;
			for(i = 0; i < targetObj.options.length; i++){
				if(targetObj.item(i).value == sourceObj.options(j).value){
					targetFlag = true;
				}
			}
			if(targetFlag == false){
				targetObj.Add(listItem.value, listItem.text);
			}
		}
	}
}

function MoveToRightAll(source, target){
	var sourceObj = document.getElementById(source);
	var targetObj = DynamicListBox_FindControl(target);
	for(var j = 0; j < sourceObj.options.length; j++){
		sourceObj.item(j).selected = true;
		if(sourceObj.item(j).selected == true){
			sourceObj.item(j).selected = false;
			for(var k = 0; k < targetObj.options.length; k++){
				if(sourceObj.item(j).value == targetObj.item(k).value){
					break;
				}
			}
			if(k >= targetObj.options.length){
				targetObj.Add(sourceObj.item(j).value, sourceObj.item(j).text);
			}
		}
	}
}

function RemoveRight(target){
	var targetObj = DynamicListBox_FindControl(target);
	var keepLooking = true;
	var index = targetObj.options.selectedIndex;
	while ( keepLooking && index > -1) {
		targetObj.Remove( index );
		if ( targetObj.options.selectedIndex < 0 ) {
			keepLooking = false;
		}
	}
}

function RemoveRightAll(target){
	var targetObj = DynamicListBox_FindControl(target);
	for(var j = targetObj.options.length; j >= 0; j--){
		targetObj.Remove(j);
	}
}
//end for report