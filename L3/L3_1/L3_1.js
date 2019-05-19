// JavaScript code that is related to "L3_1.html"

/**
 * Control the "textTel" status according to the "radioStatus".
 */
function ChangeTextStatus()
{
    var radioStatus = document.getElementById("enabled");
    var textTel = document.getElementById("tel");
    if (radioStatus.checked) {
        textTel.disabled = "";
    } else {
        textTel.value = "";
        textTel.disabled = "disabled";
    } // end if...else
} // end function ChangeTextStatus