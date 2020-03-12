document.querySelector(".sweet-confirm").onclick = function() {
    swal({
        title: "Are you sure to delete ?",
        text: "You will not be able to recover this imaginary file !!",
        type: "warning",
        showCancelButton: !0,
        confirmButtonColor: "#DD6B55",
        confirmButtonText: "Yes, delete it !!",
        closeOnConfirm: !1
    }, function () {
        $.ajax({
            url: "~/Controller/Contoh/InputMasterItemStock",
            type: "post",
            data: JSON.stringify(dto),
            dataType: "json",
            contentType: "application/json;charset=utf-8",
            success: function (data) {
                swal("Deleted !!", "Hey, your imaginary file has been deleted !!", "success")
            }
        });
    })
};