//problem1
var size = Number(window.prompt());
var sum = 0;
var averageNumbers = [];
while(size > 0){
    var num = Number(window.prompt());
    averageNumbers.push(num)
size--;
}
for(var i = 0 ; i < averageNumbers.length ; i++){
    sum+=averageNumbers[i];
}

console.log("The Average is "+ sum / averageNumbers.length);

//problem2
var size = Number(window.prompt());
var fact = 1;
var factorialNumbers = [];
while(size> 0){
    var num2 = Number(window.prompt());
    factorialNumbers.push(num2);
    size--;
}
for(var i = 0 ; i < factorialNumbers.length ; i++){
    fact= 1;
    for (let j = 1; j <= factorialNumbers[i]; j++) {
        fact*=j;
        
    }
    factorialNumbers[i] = fact;

}
console.log(factorialNumbers);

//problem3
var sizeOfArray = Number(window.prompt());
var divisor = [];
while(sizeOfArray > 0){
    var num3 = Number(window.prompt());
    divisor.push(num3);
    sizeOfArray--;
}
var flag = 0;
for (let i = 0; i < divisor.length; i++) {
    flag = 0;
    for (let j = 0; j < divisor.length; j++) {
        if(divisor[j] % divisor[i] == 0){
            flag++;
        }
        
    }
    if(flag == divisor.length){
        flag = divisor[i];
        break;
    }
}
if(flag > 1){
    console.log(flag);
}else{
    console.log("no number");
}

// 4- Reverse Array
var sizeOfReversedArray = Number(window.prompt());
var reversedNumbers = [];
while(sizeOfReversedArray > 0){
    var num4 = Number(window.prompt());
    reversedNumbers.push(num4);
    sizeOfReversedArray--;
}
for(var i = reversedNumbers.length -1 ; i >= 0; i-- ){
    console.log(reversedNumbers[i]);
}