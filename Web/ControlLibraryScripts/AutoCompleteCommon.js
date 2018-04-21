var SearchKey = "";
var LastSearchTime = Date.parse(Date());
var IntervalLimit = 2000;    
			 
function MatchSearchItem()
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
			// if next statement is remarked,this function will not run as wished, otherwise,  onchange event will not be fired.
			window.event.returnValue = false;    
			return;
		}   
	} 
}