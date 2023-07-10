function  billCalculation() {

 var vegadult = document.getElementById('VegAdult').value;
 var vegkids = document.getElementById('VegKids').value;
 var nonvegadult = document.getElementById('nonVegAdult').value;
 var nonvegkids = document.getElementById('nonVegKids').value;  

 var totalcost = (599 * vegadult) + (249 * vegkids) + (699 * nonvegadult) + (349 * nonvegkids);

 totalcost += totalcost * 0.12;

 totalcost = totalcost.toFixed(2);
 if((vegadult + vegkids + nonvegadult + nonvegkids) >= 10)
 {
    totalcost = totalcost * 0.9;
    totalcost = totalcost.toFixed(2);
 }

 var custname = document.getElementById('customerName').value;

 document.getElementById('result').innerHTML ='Hai ' + custname+', You have to pay Rs. '+totalcost +'. Thanks for coming!!!';
return false;
}