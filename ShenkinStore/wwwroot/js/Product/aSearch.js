﻿

$(function () {
    var form = $("#myForm2")
    var url = form.attr('action')

    $("#myForm2").on('change',function () {
        $.ajax({
            url: url,
            data: form.serialize(),
            success: function (data) {
                $("tbody").html(data);
            }
        });
    });
});
