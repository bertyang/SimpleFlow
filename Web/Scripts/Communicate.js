function DataCommunicate(sXML, action){
	var xmlDoc = new ActiveXObject("MSXML.DOMDocument");
	xmlDoc.async=false;
	sXML = "<Root>" + sXML + "</Root>";
	var httpObj = new ActiveXObject("Microsoft.XMLHTTP");
	if (xmlDoc.loadXML(sXML)){
		httpObj.open ("POST", action, false);
		httpObj.send (xmlDoc);
		if (xmlDoc.loadXML(httpObj.responseText) == false){
			throw (xmlDoc.parseError.reason)
		}
		else{
			return xmlDoc;
		}
	}
}

