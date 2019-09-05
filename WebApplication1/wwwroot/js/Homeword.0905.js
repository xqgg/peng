//将之前“找出素数”的代码封装成一个函数findPrime(max)，可以打印出max以内的所有素数。
//function findPrimeNumber(max) {
//    for (var i = 2; i < (max + 1); i++) {
//        for (var j = 2; j < i; j++) {
//            if (i % j == 0) {
//                //console.log(i + "不是质数");
//                break;
//            } else {
//                if (j === i - 1) {
//                    console.log(i + "是质数");
//                    //break;
//                }
//            }
//        }
//    }
//}
//findPrimeNumber(100);

//自行设计参数，将之前“累加求和”的代码封装成一个函数Sum()，可以计算任意起始位置、
//任意步长（如：1, 3, 5……或者0, 5, 10, 15……）的等差数列之和。

function arithmeticSum(start, end, difference) {
    var sum = 0;
    for (var i = start; i < (end + 1); i += difference) {
        sum += i;
    }
    alert("等差数列和：" + sum);
    return (sum);
}
arithmeticSum(1, 100, 5);