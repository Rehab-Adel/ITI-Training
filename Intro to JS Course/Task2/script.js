//problem1
var num1 = Number(window.prompt());
var counter = 1;
while (num1 >= counter)
{
    console.log(counter);
    counter++;
}

//problem2
var num2 = Number(window.prompt());
for (var i = 1; i <= 12; i++)
{
    console.log(i * num2 + " ");
}

//problem3
var sum = 0;
var num3;
do
{
    num3 = Number(window.prompt());

    if (num3 >= 0)
    {
        sum += num3;
    }
    else
    {
        console.log(sum);
    }
} while (num3 >= 0);

//problem4
var max = 0;
var num4;
do
{
    num4 = Number(window.prompt());
    if (num4 >= max)
    {
        max = num4;
    }

} while (num4 >= 0);
console.log(max);

//problem5
var num5 = Number(window.prompt());

for (var i = 2; i <= num5; i += 2)
{
    console.log(i);
}

//problem6
var num6 = Number(window.prompt());
for (var i = 1; i <= num6; i++)
{
    if (num6 % i == 0)
    {
        console.log(i);
    }
    else
    {
        continue;
    }
}

//problem7
var num7 = Number(window.prompt());
var power = Number(window.prompt());
var result = 1;
for (var i = 1; i <= power; i++)
{
    result *= num7;
}
console.log(result);

//problem8
var num8 = Number(window.prompt());
var num9 = Number(window.prompt());

for (var number = num8; number <= num9; number++)
{
    var isPrime = true;

    if (number <= 1)
    {
        isPrime = false;
    }
    else
    {
        for (var j = 2; j * j <= number; j++)
        {
            if (number % j == 0)
            {
                isPrime = false;
                break;
            }
        }
    }

    if (isPrime)
    {
        console.log(number);
    }
}

//problem9
var width = Number(window.prompt());
var height = Number(window.prompt());
for (var i = 0; i < width; i++)
{
    for (var j = 0; j < height; j++)
    {
        console.log("* ");
    }
    console.log("");
}

//problem10
var num10 = Number(window.prompt());;
var max = 0;
while (num10 > 0)
{
    var digit = num10 % 10;
    if (digit > max)
    {
        max = parseInt(digit);
    }
    num10 /= 10;
    parseInt(num10);
}
console.log(max);

//problem11
var num11 = Number(window.prompt());
var reversenum = "";
while (num11 > 0)
{
    var digit = parseInt(num11 % 10);
    reversenum += digit
    num11 /= 10;
   num11 = parseInt(num11);
}
console.log(reversenum);

//problem12
var height2 = Number(window.prompt());

for (var i = 1; i <= height2; i++)
{
    for (var j = 1; j <= height2 - i; j++)
    {
        console.log(" ");
    }
    for (var j = 1; j <= i; j++)
    {
        console.log("* ");
    }
    console.log(""+"\n");
}