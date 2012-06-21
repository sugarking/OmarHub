<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>
<body>
    <p>Add Tag</p>
    <div class="Form" id="AddTagForm">
    <label>
    <em>Tag name:</em>
    <input type="text" class="" value="" tabindex="1"  id="tag_name" size="25"/>
     *
    </label>
    <br />
    <label>
    <em>Tag type:</em>
    <select tabindex="2" id="tag_type">
        <option value ="0">Field of Work</option>
        <option value ="1">Location of Work</option>
        <option value ="2">Target Population</option>
    </select>
     *
    </label>
    <br />
        <button tabindex="3" value="Confirm" type="submit" id="Addtagsubmit"  class="btn" >
            <span>Confirm</span>
        </button>
        <button tabindex="4" value="Cancel" type="submit" id="canceltagsubmit"  class="btn" >
            <span>Cancel</span>
        </button>
    </div>
<script src="Scripts/jquery-1.4.1.min.js" type="text/javascript"></script>
<script type="text/javascript">
    $("#Addtagsubmit").click(
        function() {

            var tag = {
                "tag_name": $("#tag_name").val(),
                "tag_type": $("#tag_type").val(),
            };
            
            $.post("Control/AddTag.ashx", tag,
                function(data, status) {
                    if (status == "success")
                    {
                        alert(data);
                    }
                }
                );
       });

</script>
</body>

</html>
