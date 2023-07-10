function BMI() {
    let h = document.getElementById('height').value;
    let w = document.getElementById('weight').value;
    let n = (h/100);
    let BMI=(n*n);
    document.getElementById('result').value =w/BMI;
    if (w == "") {
        alert("Weight must be filled out");
    }

}