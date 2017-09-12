<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AutoComboBox.aspx.cs" Inherits="WebApplication1.AutoComboBox" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="Content/easyUI/themes/default/easyui.css" rel="stylesheet" />
    <link href="Content/easyUI/themes/icon.css" rel="stylesheet" />
    <script src="Content/easyUI/jquery.min.js"></script>
    <script src="Content/easyUI/jquery.easyui.min.js"></script>
    <script src="Content/easyUI/locale/easyui-lang-zh_CN.js"></script>
    <script>
        $(function(){
            InitAutoLanguage();
        })
        function InitAutoLanguage()
        {
            $('#language').combobox({
                url: '/Ashx/comboboxData.ashx?options=list',
                valueField: 'id',
                textField: 'text'
            });
        }
        function submitForm(){
            $('#ff').form('submit', {    
                url: '/Ashx/comboboxData.ashx?options=Add',
                onSubmit: function(){    
                    // do some check    
                    // return false to prevent submit;    
                },    
                success: function (data) {
                    var json = JSON.parse(data);
                    $.messager.alert("系统提示", json.Msg);
                    InitAutoLanguage();
                }    
            }); 
        }
       
        function clearForm(){
            $('#ff').form('clear');
        }
    </script>
</head>
<body>
<div class="easyui-panel" title="" style="width:100%;max-width:400px;padding:30px 60px;">
        <form id="ff" method="post">
            <div style="margin-bottom:20px">
                <input class="easyui-combobox" id="language" name="language" label="Language" style="width:100%"/>
            </div>
        </form>
        <div style="text-align:center;padding:5px 0">
            <a href="javascript:void(0)" class="easyui-linkbutton" onclick="submitForm()" style="width:80px">Submit</a>
            <a href="javascript:void(0)" class="easyui-linkbutton" onclick="clearForm()" style="width:80px">Clear</a>
        </div>
    </div>
    
</body>
</html>
