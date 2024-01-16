//problem1
var number = prompt("Enter a number:");
console.log("number = ", number);

//problem2
var number1 = prompt("Enter a number:");
if (number % 3 === 0 && number % 4 === 0) {
  console.log("Yes");
} else {
  console.log("No");
}

//problem3
var num1 = prompt("enter the first number:");
var num2 = prompt("enter the second number:");

if (num1 > num2) {
  console.log("maximum number is:", num1);
} else {
  console.log("maximum number is:", num2);
}

//problem4
var numberr = prompt("Enter a number:");
if (numberr < 0) {
  console.log("negative");
} else {
  console.log("positive");
}
//problem5
var Num6 = Number(window.prompt());
var Num7 = Number(window.prompt());
var Num8 = Number(window.prompt());
var max = 0;
var min = 0;
if ((Num6 >= Num7 && Num6 >= Num8))
{
   max = NumQ6;
}
else if ((Num7 >= Num6 && Num7 >= Num8))
{
   max = Num7;
}
else
{
   max = Num8;
}

if ((Num6 <= Num7 && Num6 <= Num8))
{
   min = Num6;
}
else if ((Num7 <= Num6 && Num7 <= Num8))
{
   min = Num7;
}
else
{
   min = Num8;
}
console.log("Max= " + max + ", Min= " + min);

//problem6
var num9 = Number(window.prompt());
var result = (num9 % 2 == 0) ?"Even" :"Odd";
console.log(result);

//probelm7
var char_vowel = window.prompt();   
if(char_vowel == 'a' || char_vowel == 'e' || char_vowel == 'i'|| char_vowel == 'o'|| char_vowel == 'u')
{
   console.log("vowel");
}
else
{
   console.log("consonant");
}

//problem8
var today = 2;

switch (today)
{
   case 1:
       console.log("saturday");
       break;
   case 2:
       console.log("sunday");
       break;
   case 3:
       console.log("monday");
       break;
   case 4:
       console.log("tuesday");
       break;
   case 5:
       console.log("wednesday");
       break;
   case 6:
       console.log("thursday");
       break;

   default:
       console.log("friday");
       break;
}