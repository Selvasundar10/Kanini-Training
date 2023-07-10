function order() {
    var name = document.getElementById("name").value;
    var mail = document.getElementById("mail").value;
    var number = document.getElementById("number").value;
    var address = document.getElementById("address").value;

    var option1 = document.getElementById("option1");
    var option2 = document.getElementById("option2");
    var option3 = document.getElementById("option3");
    var option4 = document.getElementById("option4");
    var option5 = document.getElementById("option5")
    function validateEmail(mail) {
        const regex_pattern =      /^(([^<>()[\]\\.,;:\s@\"]+(\.[^<>()[\]\\.,;:\s@\"]+)*)|(\".+\"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
        
        if (mail.value.match(regex_pattern)) {
            return true
        }
        else {
            alert('The email address is not valid');
        }
    }
 
    if (option1.checked == true) {
        option1 = 799;
    }
    else {
        option1 = 0;
    }
    if (option2.checked == true) {
        option2 = 899;
    }
    else {
        option2 = 0;
    }
    if (option3.checked == true) {
        option3 = 1199;
    }
    else {
        option3 = 0;
    }

    if (option4.checked == true) {
        option4 = 299;
    }
    else {
        option4 = 0;
    }
    if (option5.checked == true) {
        option5 = 999;
    }
    else {
        option5 = 0;
    }
    var Total = option1 + option2 + option3 + option4 + option5
    if (Total > 2000) {
        var Price = (Total - (Total * 20) / 100)
    }
    else {
        Price = Total
    }
    document.getElementById('result').value = "Order has been placed successfull. You are requested to pay Rs." + Price + " on delivery"}


