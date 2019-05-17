
//Below click event is triggered to 
function onSubmit(form) {

    $('#response').empty();

    var html = "";
    var valid = false;
    var txtDollarNumber = $("#txtDollarNumber").val();
    var txtName = $("#txtName").val();
    var txtCentNumber = $("#txtCentNumber").val();

    $('#numericvaluetoword').validate({
        errorPlacement: function (error, element) {
            /*here we add the error label to the div that is after the br tag 
            using the next method provided by jquery to navigate on the DOM*/
            if (element.is('#txtDollarNumber'))
                error.appendTo('#dollarError');
            else if (element.is('#txtCentNumber'))
                error.appendTo('#dollarError');
            else
                error.insertAfter(element);
        }
    });

    if ($("#numericvaluetoword").valid()) {

        var webServiceUrl = document.location.origin + "/WebService/NumericValueToWord.asmx/ConvertNumericValueToWord";
        var obj = {
            name: txtName, dollarNumber: txtDollarNumber, centNumber: txtCentNumber
        };

        $.ajax({
            type: "POST",
            dataType: "json",
            contentType: "application/json; charset=utf-8",
            url: webServiceUrl,
            data: JSON.stringify(obj),
            success: function (result) {
                if (result.d) {
                    if (result.d.indexOf("Error") >= 0) {
                        html += "<i>" + result.d + "</i>";
                    }
                    else {
                        var resultJsonObj = JSON.parse(result.d);
                        html += "<h4>Output:</h4><span id='jsonNameResponse'>" + resultJsonObj.Name + "</span>";
                        html += "<br><span id='jsonWordResponse'><b>" + resultJsonObj.Word.toUpperCase() + "</b></span>";
                    }
                }
                else {

                    html += "<i>There was some error. Please try again</i>";
                }
                $('#response').append(html);
            },
            error: function (result) {
                html = 'There was some error. Please try again later';
                $('#response').append(html);
            }
        });
    }
    else {
        html += "<i>There are some errors on the form. Please fix the errors and try again.</i>";
        $('#response').append(html);
    }
    return false;
}

function getFormData($form) {
    var unindexed_array = $form.serializeArray();
    var indexed_array = {};

    $.map(unindexed_array, function (n, i) {
        indexed_array[n['name']] = n['value'];
    });

    return indexed_array;
}