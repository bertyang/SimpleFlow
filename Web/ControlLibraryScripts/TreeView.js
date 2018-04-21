function EllapseTreeNode(childPanelID){
	var oChildPanel = document.getElementById(childPanelID);
	var panelStatus = oChildPanel.style.display;
	if (panelStatus == null || panelStatus == "none"){
		HideSiblingNodes(oChildPanel);
		oChildPanel.style.display = "block";
	}
}

function HideSiblingNodes(node){
	var oParent = node.parentNode;
	var directChidren = oParent.children.tags("div");
	if (directChidren != null){
		for(var i = 0; i < directChidren.length; i++){
			if (directChidren[i].style.display == "block"){
				directChidren[i].style.display = "none";
				return;
			}
		}
	}
}

function CollapseTreeView(nodeIDArray){
	
}