function NumericKeyWithPoint(e)
{ 
    var keyChar = String.fromCharCode(window.event.keyCode); 
    var reg = /[\d\.]/; 
    var regPoint = /[\.]/;
    
    if (keyChar.search(reg) == -1 || (keyChar.search(regPoint) > -1 && e.value.search(regPoint) > -1))
    { 
        window.event.keyCode = 0; 
    } 
    else
    { 
        return keyChar.charAt(0); 
    } 
}

function FloatKey(e)
{
	var keyChar = String.fromCharCode(window.event.keyCode); 
    var reg = /[\d\.\-]/; 
    var regPoint = /[\.]/;
    var regMinus = /[\-]/;
    var floatNumber = GetTextBoxContentOnFloatKey(e, keyChar);
   
    //debugger;
    
    if (keyChar.search(reg) == -1 || (keyChar.search(regPoint) > -1 && e.value.search(regPoint) > -1)
		|| (keyChar.search(regMinus) > -1 && e.value.search(regMinus) > -1)
		|| CheckFloat(floatNumber) == false)
    { 
        window.event.keyCode = 0; 
    } 
    else
    { 
        return keyChar.charAt(0); 
    } 
}

function GetTextBoxContentOnFloatKey(obj, keyChar)
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
	
	var content = startContent + keyChar + endContent;
	
	return content;
}

function CheckFloat(floatNumber)
{
	var number = floatNumber;
	
	var defaultValue = parseFloat(number);
	
	if(number.length==0 || number == "-")
	{
		return true;
	}

	if (number != defaultValue)
	{
		return false;
	}
	
	return true;
}

function NumericKeyWithoutPoint()
{ 
    var keyChar = String.fromCharCode(window.event.keyCode); 
    var reg = /[\d]/; 

    if (keyChar.search(reg) == -1)
    { 
        window.event.keyCode = 0; 
    } 
    else
    { 
        return keyChar.charAt(0); 
    } 
}

function FloatNumericOnPaste(obj)
{
	var number = GetTextBoxContentOnPaste(obj);
	
	var defaultValue = parseFloat(number);
	
	if(number.length==0)
	{
		return true;
	}

	if (number != defaultValue || defaultValue < 0)
	{
		return false;
	}
	
	return true;
}

function IntNumericOnPaste(obj)
{
	var number = GetTextBoxContentOnPaste(obj);
	
	var defaultValue = parseInt(number);
	
	if(number.length==0)
	{
		return true;
	}

	if (number != defaultValue || defaultValue < 0)
	{
		return false;
	}
	
	return true;
}


function FloatOnPaste(obj)
{
	var number = GetTextBoxContentOnPaste(obj);
	
	var defaultValue = parseFloat(number);
	
	if(number.length==0)
	{
		return true;
	}

	if (number != defaultValue)
	{
		return false;
	}
	
	return true;
}

function GetTextBoxContentOnPaste(obj)
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
	
	var content = startContent + window.clipboardData.getData("Text") + endContent;
	
	return content;
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



