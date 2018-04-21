
function Trim(text){
	 return text.replace(/(^\s*)|(\s*$)/g, ""); 
}

function SafeXML(text){
	var sSafe = text.replace(/&/g,"&amp;");
	sSafe = sSafe.replace(/</g,"&lt;");
	sSafe = sSafe.replace(/>/g,"&gt;");
	return sSafe;
}