'use strict';

class ServerCalc {
    constructor(url) {
        this.url = url;
    }

    Calculate(num1, num2, opr) {
        if (opr === "+") { opr = "plus"; }
        var req = "num1=" + num1 + "&num2=" + num2 + "&opr=" + opr;
        var rr = new XMLHttpRequest();
        rr.open('GET', this.url + req, false);
        rr.send(null);
        if (rr.status == 200)
            return rr.responseText;
        else
            return rr.status;
    }
};

var aStr;
var opStr;
var sCalc = new ServerCalc('http://localhost:8370/?');

function fNum(p) {
    aTxt.value += p.value;
}
function fOp(p) {
    if (p.value == '=') {
        var aNum = aStr;
        var bNum = aTxt.value;
        var res = sCalc.Calculate(aNum, bNum, opStr);
        aTxt.value = res;
    }
    else {
        aStr = aTxt.value;
        aTxt.value = "";
        opStr = p.value;
    }
}
