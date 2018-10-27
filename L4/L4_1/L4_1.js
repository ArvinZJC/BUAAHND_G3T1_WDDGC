//2018.10.12, JavaScript code that is related to "L4_1.html"

/**
 * Clear text in the text boxes for output.
 */
function InitialOutput()
{
    document.getElementById( "output1" ).value = "";
    document.getElementById( "output2" ).value = "";
} //end function InitialOutput

/**
 * Get the total of 2 integers entered.
 */
function getTotal()
{
    var integer1 = parseInt( document.getElementById( "input1" ).value );
    var integer2 = parseInt( document.getElementById( "input2" ).value );

    document.getElementById( "output1" ).value = integer1 + integer2;
} //end function getTotal

/**
 * Get the max of 2 integers entered.
 */
function getMax()
{
    var integer1 = parseInt( document.getElementById( "input1" ).value );
    var integer2 = parseInt( document.getElementById( "input2" ).value );

    if( integer1 > integer2 )
        document.getElementById( "output2" ).value = integer1;
    else
        document.getElementById( "output2" ).value = integer2;
} //end function getMax