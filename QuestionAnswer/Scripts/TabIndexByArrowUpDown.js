document.onkeydown = function (e) {
    e = e || window.event;
    if (e.keyCode == 40) {
        SetFocusDown();
    }
    if (e.keyCode == 38) {
        SetFocusUp();
    }
}


function SetFocusDown() {
    var tabIndex = 1;

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

function SetFocusUp() {
    var tabIndex = 1;
    var activeElement = document.activeElement.tabIndex;

    if (activeElement < 0) {
        document.getElementById(tabIndex).focus();
    }
    else {
        tabIndex = document.activeElement.tabIndex;
        if (tabIndex == 1) return;
        tabIndex = tabIndex - 1;
        document.getElementById(tabIndex).focus();
    }
}