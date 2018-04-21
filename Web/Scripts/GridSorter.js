function SortBy(table, direction, orderCell)
{
	//debugger;
	//var source = event.srcElement;
	//var table = source;
	var i, j, k;
	
	//i = source.cellIndex;
	//display tooltip when mouseover
	//source.title = (source.title == "asc" ? "desc" : "asc");
	//direction = (direction.toLowerCase() == "asc" ? "desc" : "asc");
	//get the nearest table, at click event occur
	while (table.tagName.toUpperCase() != "TABLE") table = table.parentElement;
	var length = table.rows.length;
	var rows = table.rows;
	//if there are one row and one title then return
	if (length < 3) return true;
	//main loop
	if (direction == "asc") {
		SortAsc(rows, length, orderCell);
	}
	else {
		SortDesc(rows, length, orderCell);
	}
}

function SortAsc(rows, length, orderCell) {
	for (j = 1; j < length; j++) {
		var subRows = rows[j];
		for (k = j + 1; k < length; k++) {
			var next = Trim(rows[k].cells[orderCell].innerText);
			var previous = Trim(subRows.cells[orderCell].innerText);
			if (next.toLowerCase() < previous.toLowerCase())
				subRows.swapNode(rows[k]);
		}
	}	
}

function SortDesc(rows, length, orderCell) {
	for (j = 1; j < length; j++) {
		var subRows = rows[j];
		for (k = j + 1; k < length; k++) {
			var next = Trim(rows[k].cells[orderCell].innerText);
			var previous = Trim(subRows.cells[orderCell].innerText);
			if (next.toLowerCase() > previous.toLowerCase())
				subRows.swapNode(rows[k]);
		}
	}	
}