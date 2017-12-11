$(function () {
  
    var form = $(".form-signin");
    $('#submit-form').click(function (e) {
        form.validate({
            rules: {
                UserName: {
                    required: true,
                    //minlength: 3,
                },
                Password: {
                    required: true,
                    //minlength: 6,
                    //maxlength: 16
                }
            },
            messages: {
                UserName: {
                    required: 'Enter your username'
                },
                Password: {
                    required: 'Enter your password'
                }
            },
            errorPlacement: function (error, element) {
                error.insertAfter(element);
            }
        });
        e.preventDefault();
        if (form.valid()) {
            $(this).addClass('ladda-button');
            var l = Ladda.create(this);
            l.start();
            $.ajax({
                type: "POST",
                url: $("#hdnAppUrl").val()+"/Login/Index",
                data: form.serialize(),
                dataType: "json",
                success: function (response) {
                    if (response == 1) {
                        window.location.href = $("#hdnAppUrl").val() + "/Dashboard";
                        //ShowSuccess("Success", 'bottom')
                    }
                     else
                      {
                        ShowError("Invalid Username and Password", 'bottom')
                        }
                 },
                error: function (response) {
                    console.log(response.responseText);
                    //ShowError("Error", 'bottom')
                }
            });
        } else {
            $('body').addClass('boxed');
        }
    });
});