/* 
<form>
    Operand 1: <input id="operand1" type="text">
    Operand 2: <input id="operand2" type="text">
    Operator :
    <select id="operator">
        <option value="add">Add</option>
        <option value="min">Minus</option>
        <option value="mul">Multiply</option>
        <option value="div">Divide</option>
    </select>
    <button type="button" onclick="calc()">Calculate</button>
</form>

<hr>

<div id="result" style="font-size: 20em;"></div>
*/

function calc() {
    let o1 = parseInt(document.querySelector("#operand1").value);
    let o2 = parseInt(document.querySelector("#operand2").value);
    let op = document.querySelector("#operator").value;
    let calculate;

    switch (op) {
        case "add":
            calculate = o1 + o2;
            break;
        case "min":
            calculate = o1 - o2;
            break;
        case "mul":
            calculate = o1 * o2;
            break;
        case "div":
            calculate = o1 / o2;
            break;
        default:
            calculate = null;
            break;
    }

    document.querySelector("#result").innerHTML = calculate;
}