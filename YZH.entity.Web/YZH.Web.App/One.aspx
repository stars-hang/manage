<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="One.aspx.cs" Inherits="YZH.Web.App.One" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <script src="jquery-2.1.1.min.js"></script>
    <script type="text/javascript">
        $(function () {
            $(".tabbox li").click(function () {
                //获取点击的元素给其添加样式，讲其兄弟元素的样式移除
                $(this).addClass("active").siblings().removeClass("active");
                //获取选中元素的下标
                var index = $(this).index();
                //alert(index);
                $(this).parent().siblings().children().eq(index).addClass("active")
                    .siblings().removeClass("active");
            });
            $("#Button1").click(function () {
                var index = $("ul li.active").index();
                if (index > 0) {
                    $("ul li.active").removeClass().prev().addClass("active");
                    $("div.active").removeClass("active").prev().addClass("active");
                } 
            });
            $("#Button2").click(function () {
                var index = $("ul li.active").index();
                var aa = $(this).index();
                if (index < aa) {
                $("ul li.active").removeClass().next().addClass("active");
                    $("div.active").removeClass("active").next().addClass("active");
                }
            });
        });

    </script>
    <style type="text/css">
             * {
                 margin: 0px;
                 padding: 0px;
             }

             .tabbox {
                 margin: 10px;
             }

            .tabbox ul {
                list-style: none;
                display: table;
            }

            .tabbox ul li {
                float: left;
                width: 100px;
                line-height: 30px;
                padding-left: 8px;
                border: 1px solid #aaccff;
                margin-right: -1px;
                cursor: pointer;
            }

            .tabbox ul li.active {
                background-color: #e73839;
                color: white;
                font-weight: bold;
            }

            .tabbox .content {
                border: 1px solid #aaccff;
                padding: 10px;
            }

            .tabbox .content > div {
                display: none;
            }

            .tabbox .content > div.active {
                display: block;
            }
    </style>
</head>
<body>

    <div class="tabbox">
        <ul>
            <li class="active">选项卡一</li>
            <li>选项卡二</li>
            <li>选项卡三</li>
            <li>选项卡四</li>
        </ul>
        <div class="content">
            <div class="active">
                <div>111111111111</div>
            </div>
            <div>
                <div>2222222222</div>
            </div>
            <div>33333333333</div>
            <div>44444444</div>
        </div>
        <input id="Button1" type="button" value="上一页" />
        <input id="Button2" type="button" value="下一页" />
    </div>
    
</body>
</html>
