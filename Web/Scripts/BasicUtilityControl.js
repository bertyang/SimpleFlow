function SwitchTreeViewStatus(o) {
	var root;
	
	if (typeof(CurrentRootSite) == "undefined") {
		// if this start up array does not registed, then give the default value to it
		root = "/CorpComm";
	}
	else {
		root = document.getElementById(CurrentRootSite[0]).value;
	}
	// alert('ok1');
	var treeView = document.getElementById("treeViewPanel");
	if (treeView == null){
		return;
	}
	var leftCookie = "Left_Panel_Cookie=";
	if (treeView.style.display == "block"){
		// document.getElementById("WelcomeName").style.display = "none";
		document.getElementById("menuPanel").style.width = "10px";
		treeView.style.display = "none";
		leftCookie += "block";
		// This global variable "ROOTSITE" may be lost, when frequence refresh the page
		//o.src = ROOTSITE + "/Images/Icon_appear.gif";
		o.src = root + "/Images/Icon_appear.gif";
	}
	else{
		document.getElementById("menuPanel").style.width = "190px";
		// document.getElementById("WelcomeName").style.display = "block";
		treeView.style.display = "block";
		leftCookie += "none";
		//o.src = ROOTSITE + "/Images/Icon_hide.gif";
		o.src = root + "/Images/Icon_hide.gif";
	}
	// alert('ok2');
	document.cookie = leftCookie;
	// ResizeWindow();
}

function SwitchBannerStatus(o) {
	var root;
	if (typeof(CurrentRootSite) == "undefined") {
		// if this start up array does not registed, then give the default value to it
		root = "/CorpComm";
	}
	else {
		root = document.getElementById(CurrentRootSite[0]).value;
	}
	
	var bannerPanel = document.getElementById("BannerSpacer");
	if (bannerPanel == null){
		return;
	}
	var topCookie = "Top_Panel_Cookie=";
	if (bannerPanel.style.display == "block"){
		bannerPanel.style.display = "none";
		topCookie += "block";
		o.style.backgroundImage = "url(" + root + "/Images/Icon_Banner_Appear.gif)";
		//o.style.backgroundImage = "url(" + ROOTSITE + "/Images/Icon_Banner_Appear.gif)";
	}
	else{
		bannerPanel.style.display = "block";
		topCookie += "none";
		o.style.backgroundImage = "url(" + root + "/Images/Icon_Banner_hide.gif)";
		//o.style.backgroundImage = "url(" + ROOTSITE + "/Images/Icon_Banner_hide.gif)";
	}
	document.cookie = topCookie;
	ResizeWindow();
}

function ResizeWindow(){
	try{
		if (document.readyState !="complete"){
			return;
		}
		ResizeHeight();
		ResizeWidth();
	}
	catch(e){}
}

function ResizeHeight(){
	var clientHeight = parseInt(document.body.clientHeight);
	var welcomeHeight = 30;
	var topSpace = ((document.getElementById("BannerSpacer").style.display == "block") ? 50 : 0) + welcomeHeight;
	var bottomSpace = 25;
	if (clientHeight > (topSpace + bottomSpace)){
		var height = clientHeight - (topSpace + bottomSpace);
		document.getElementById("Main").style.height = height;
		document.getElementById("TreeViewPanel").style.height = document.getElementById("Main").clientHeight;
	}
}

function ResizeWidth(){
	var leftSpace = ((document.getElementById("treeViewPanel").style.display == "block") ? 180 : 0) ;
	var width = document.getElementById("Main").clientWidth + 10 + leftSpace;
	var clientWidth = parseInt(document.body.clientWidth);
	if (width < clientWidth){
		width = clientWidth;
	}
	document.getElementById("Footer").style.width = width;
	document.getElementById("BannerSpacer").style.width = width;
	document.getElementById("BannerWelcome").style.width = width;
}

function ResetLeftMenuIcon() {
	var root;
	if (typeof(CurrentRootSite) == "undefined") {
		// if this start up array does not registed, then give the default value to it
		root = "/CorpComm";
	}
	else {
		root = document.getElementById(CurrentRootSite[0]).value;
	}

	var leftIcon = document.getElementById("ImgIcon");
	var treeView = document.getElementById("treeViewPanel");
	
	if (leftIcon != null && treeView != null) {
		// because this icon's display maybe empty string
		// so the reference standard is menu list, not the icon
		if (treeViewPanel.style.display == "none") {
			leftIcon.src = root +  "/Images/Icon_appear.gif";
		}
		else if (treeViewPanel.style.display == "block") {
			leftIcon.src = root +  "/Images/Icon_hide.gif";
		} 
	}
}

function CookieValue(cookie, key){
	var index = cookie.indexOf(key);
	var value = "";
	if (index > -1){
		var endIndex = cookie.indexOf(";", index);
		value = cookie.substr(index + key.length, endIndex - index - key.length);
	}
	return value;
}

function PanelDisplay() {
	try{
		var left = document.getElementById('ImgIcon');
		var up = document.getElementById('HideLogo');
		if (left != null && up != null) {
			var cookies = document.cookie + ";";
			var parsedValue = CookieValue(cookies, "Top_Panel_Cookie=");
			if (parsedValue.length > 0)
			{
				document.getElementById('BannerSpacer').style.display = parsedValue;
				SwitchBannerStatus(up);
			}
			
			parsedValue = CookieValue(cookies, "Left_Panel_Cookie=");
			if (parsedValue.length > 0)
			{
				document.getElementById('treeViewPanel').style.display = parsedValue;
				SwitchTreeViewStatus(left);
			}
		}
	}
	catch(e){}
}


function trim(str) {
    var k = 0;
    var m = 0;
    var i = 0;
    for (i = 0; i < str.length; i++) {
        if (str.charCodeAt(i) != 32) {
            k = i;
            break;
        }
    }
    if (i == str.length) { str = ""; return (str); }
    for (i = str.length - 1; i > -1; i--) {
        if (str.charCodeAt(i) != 32) {
            m = i;
            break;
        }
    }
    str = str.substring(k, m + 1);
    return (str);
} 
// window.document.onreadystatechange = ResizeWindow;
// window.document.body.onresize = ResizeWindow;
