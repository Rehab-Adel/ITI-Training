//problem1
function printNumber(num) {
    console.log(num);
  }
  
  printNumber(5); 
//problem2
  function printAvrege(num1,num2,num3) {
      var avrege = (num1 + num2 + num3)/3
    console.log(avrege);
  }
  printAvrege(3,4,7)
//problem3
function isPrime(num3) {
    if (num3 <= 1) {
      return false;
    }
    for (let i = 2; i <= Math.sqrt(num3); i++) {
      if (num3 % i === 0) {
        return false;
      }
    }
    return true;
  }
  console.log(isPrime(7)); 
  console.log(isPrime(10));
//problem4
function reverseInteger(num4) {
var reversed = Number(num4.toString().split('').reverse().join(''));
    return reversed;
  }
  console.log(reverseInteger(12345)); 
//problem5
function sumArray (arr){
var sum = 0;
for (var i = 0; i<arr.length ; i++){
sum+= arr[i]
}
console.log(sum)
}
var arr= [1,2,1,5]
sumArray(arr)
//problem6
 function findMaxElement(arr) {
     var max =0 
    for (var i = 0; i<arr.length ; i++){
        if (arr[i]>max){
          max = arr[i]
        }
       
        }
    return max;
  }
  console.log(findMaxElement(arr))
//problem7
  function isVowel(char) {
    if ( char =='a'|| char == 'e'|| char ==  'i'|| char == 'o'|| char == 'u'){
        return true ;
    }else{
        return false ;
    }
  }
  console.log(isVowel('e'))
  console.log(isVowel('h'))
//problem8
function swapIntegers(a, b) {
    var temp = a;
    a = b;
    b = temp;
    return [a, b];
  }
  
  console.log(swapIntegers(5, 10)); 
//problem9
function findMaxElement(arr) {
    let max = arr[0][0];
    for (var i = 0; i < arr.length; i++) {
      for (var j = 0; j < arr[i].length; j++) {
        if (arr[i][j] > max) {
          max = arr[i][j];
        }
      }
    }
    return max;
  }
  var array = [
    [3, 7, 2],
    [8, 10, 5],
    [15, 2, 6]
  ];
  console.log(findMaxElement(array)); 
//problem10
var num10 = 16;
var sqrtResult = Math.sqrt(num10)
console.log(sqrtResult)