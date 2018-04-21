function DisallowAutoPostBack(){
	if (window.event.keyCode == 13){
		window.event.cancelBubble = true;
		window.event.returnValue = false;
	}
}

function ClientSubmit(id){
	if (window.event.keyCode == 13){
		document.getElementById(id).click();
		return false;
	}
}

var __nonMSDOMBrowser = (window.navigator.appName.toLowerCase().indexOf('explorer') == -1);
var __defaultFired = false;
function WebForm_FireDefaultButton(event, target) {
	//debugger;
    if (!__defaultFired && event.keyCode == 13 && !(event.srcElement && (event.srcElement.tagName.toLowerCase() == "textarea"))) {
        var defaultButton;
        if (__nonMSDOMBrowser) {
            defaultButton = document.getElementById(target);
        }
        else {
            defaultButton = document.all[target];
        }
        if (defaultButton && typeof(defaultButton.click) != "undefined") {
            //__defaultFired = true;
            defaultButton.click();
            //event.cancelBubble = true;
            //if (event.stopPropagation) event.stopPropagation();
            return false;
        }
    }
    return true;
}