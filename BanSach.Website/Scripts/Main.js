$(document).ready(function () {
    $("#btnDangNhap").click(function () {

        $.ajax({
            url: "/Account/Login",
            method: "post",
            data: {
                User: $("#User").val(),
                Password: $("#Password").val()
            },
            dataType: "json",
            beforeSend: function () {
                $("#loading-wrapper").show();
            },
            success: function (res) {
                if (res.StatusCode !== 200) {
                    toastr.error(res.ErrorMessage, 'Thông báo !');
                    return;
                }
                window.location.href = "/Admin/HomeAdmin/Index";
                
            },
            error: function (err) {

            },
            complete: function () {
                $("#loading-wrapper").hide();
            }
        });
    });
});