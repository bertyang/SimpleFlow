// JScript File

/*
function upload_file_handler(upload_url, name_object_id, id_object_id)
{
    var result = window.showModalDialog(upload_url);
    // alert(result);
    if ((result != null) && (result.length > 0))
    {
        var item_array = result.split(';');
        if (item_array.length > 0)
        {
            var prop_array = item_array[0].split('=');
            if (prop_array.length >= 2)
            {
                var name_obj = document.getElementById(name_object_id);
                name_obj.value = unescape(prop_array[1]);
                // alert(name_obj.value);
                var id_obj = document.getElementById(id_object_id);
                id_obj.value = unescape(prop_array[0]);
                // alert(id_obj.value);
            }
        }
    }
}

*/

function Upload(batch_id)
{
	
	var str="../../GeneralPage/BatchUpload.aspx?batch_id="+batch_id;

	batch_id=window.showModalDialog(str,0,"status:no;dialogWidth:500px;dialogHeight:298px");
	
	return batch_id;	
}