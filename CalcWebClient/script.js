var aStr;
var opStr;

function fNum(p) {
    aTxt.value += p.value;
}
function fOp(p) {
    if (p.value == '=') {
        var aNum = aStr;
        var bNum = aTxt.value;
        var res = calcN(aNum, bNum, opStr);
        aTxt.value = res;
    }
    else {
        aStr = aTxt.value;
        aTxt.value = "";
        opStr = p.value;
    }
}
function calcN(a, b, op) {
    if (op === "+") { op = "plus"; }
    var req = "num1=" + a + "&num2=" + b + "&opr=" + op;
    var rr = new XMLHttpRequest();
    rr.open('GET', 'http://localhost:8080/?' + req, false);
    rr.send(null);
    if (rr.status == 200)
        return rr.responseText;
    else
        return rr.status;
}