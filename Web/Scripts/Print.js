	function HideButton()
    {
		//隐藏按钮
		document.all("tdPrint").style.visibility = 'hidden';
	
		return false;
    }
    function SetPrinter(serial)
    {
		factory.printing.header = serial + "&b&b &p/&P";
		//factory.printing.header = serial + "&b&b Page &p/Pages &P";
		factory.printing.footer = "";
		factory.printing.topMargin = 0.8;
		factory.printing.bottomMargin = 0.8;
		factory.printing.leftMargin = 0.5;
		factory.printing.rightMargin = 0.6;	
    }
    function Print(serial)
	{
		try
		{
			SetPrinter(serial);
			//隐藏按钮
			document.all("tdPrint").style.visibility = 'hidden';
			document.all("trInformation1").style.visibility = 'hidden';
			document.all("trInformation2").style.visibility = 'hidden';
			document.all("trInformation1").style.height = '0';
			document.all("trInformation2").style.height = '0';
			document.all("trInformation3").style.height = '0';
			
			//页眉页脚边距设置
			SetPrinter(serial);
			
			//打印机页面设置
			//factory.printing.PageSetup();
			//true时弹出打印对话框，false直接打印
			factory.DoPrint(true);
			//显示按钮
			document.all("tdPrint").style.visibility = 'visible';
			document.all("trInformation1").style.visibility = 'visible';
			document.all("trInformation2").style.visibility = 'visible';
			document.all("trInformation1").style.height = '19';
			document.all("trInformation2").style.height = '10';
			document.all("trInformation3").style.height = '19';
		}
		catch(e)
		{
			alert("No printer installed.")
		}		
	
		return false;
	}
	//保持checkBox的狀態
	function KeepCheckBoxStatus( checkBox, value)
    {
		var checkBox = document.getElementById(checkBox);
		if ( value == "True")
		{
			checkBox.checked = true;
		}
		else
		{
			checkBox.checked = false;
		}
			
    }
    function SetTRPublicVisible()
    {
        document.all("TRPublicMethod").style.visibility = 'visible';
        document.all("TRPublicCountry").style.visibility = 'visible'; 
        
    }