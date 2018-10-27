//2018.10.12, JavaScript code that is related to "L4_2.html"

/**
 * Get the current local time in real-time.
 */
function getCurrentLocalTime()
{
    var time = new Date();
    var year = time.getFullYear(), month = time.getMonth() + 1, date = time.getDate(), hour = time.getHours(), minute = time.getMinutes(), second = time.getSeconds();

    /**
     * Add a zero if the value is less than 10.
     */
    function ChangeTimeFormat( value )
    {
        if( value < 10 )
            return "0" + value;
        else
            return value;
    } //end local function UpdateTime

    month = ChangeTimeFormat( month ); //call the specified function to add a zero if "month" is less than 10
    date = ChangeTimeFormat( date ); //call the specified function to add a zero if "date" is less than 10
    hour = ChangeTimeFormat( hour ); //call the specified function to add a zero if "hour" is less than 10
    minute = ChangeTimeFormat( minute ); //call the specified function to add a zero if "minute" is less than 10
    second = ChangeTimeFormat( second ); //call the specified function to add a zero if "second" is less than 10
    document.getElementById( "currentLocalTime" ).innerHTML = "Current local time: " + year + "/" + month + "/" + date + "  " + hour + ":" + minute + ":" + second;
    setTimeout( "getCurrentLocalTime()", 500 );
} //end function getCurrentTime