document.onkeydown = function (e) {
    e = e || window.event;
    if (e.keyCode == 40) {
        SetFocusDown();
    }
}

var tabIndex = 1;

function SetFocusDown() {
    var bodyForm = document.getElementById("form1");
    var activeElement = document.activeElement.tabIndex;

    if (activeElement < 0) {
        document.getElementById(tabIndex).focus();
        
    }
    else {
        
        tabIndex = document.activeElement.tabIndex;
        document.getElementById(tabIndex).focused = false;
            tabIndex = tabIndex + 1;
        
        var k = document.getElementById(tabIndex);
        k.focus();
        
    }

}