var SearchKey = "";
var LastSearchTime = Date.parse(Date());
var IntervalLimit = 2000;    

function MatchItem()
{
	var SourceElement;
	var CurrentTime;
	var ItemCount;
	
	SourceElement = event.srcElement;
	CurrentTime=Date.parse(Date());
	ItemCount = SourceElement.length;

	if(CurrentTime - LastSearchTime > IntervalLimit)
	{
		SearchKey = "";
	}
	LastSearchTime = CurrentTime;
	SearchKey = SearchKey + String.fromCharCode(window.event.keyCode); 
	
	for(i = 0; i < ItemCount; i++)
	{		
		var ItemText = SourceElement.options[i].text.toLowerCase();		
		var MatchedIndex = ItemText.indexOf(SearchKey);
		
		if (MatchedIndex == 0)
		{
			SourceElement.options[i].selected = true;
			window.event.returnValue = false;
			return;
		}   
	} 
}

