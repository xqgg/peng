//1.构建一个函数has9(number) ，可以判断number中是否带有数字9；
//构建一个函数has8(number) ，可以判断number中是否带有数字8；
//构建一个函数has6(number) ，可以判断number中是否带有数字6；

/*测试：
 * 输入hasX(9,999)=true;
 * 输入hasX(9,119)=true;
 * 输入hasX(9,-119)=请输入正整数;
 * 输入hasX(5,-5.5)=请输入正整数;
 * 输入hasX(5,NaN)=请输入正整数;
 */

function hasX(x, number) {
    if (typeof (number) === 'number' && number > 0 && String(number)[1] != ".") {
        var parameter = String(number);
        var find = String(x);
        return parameter.indexOf(find) >= 0;
    } else {
        console.log("请输入正整数");
    }
}

function has9(number) {
    return hasX(9, number);
}
function has8(number) {
    return hasX(8, number);
}
function has6(number) {
    return hasX(6, number);
}

//2.使用上述函数，找出10000以内有多少个数字包含：9或者8或者6。
/*测试：
 * 输入has(10)=3
 * 输入has(16)=4
 * 输入has(18)=5
 */
//function has(max) {
//    var result = 0;
//    for (var i = 1; i < max + 1; i++) {
//        if (has9(i) || has6(i) || has8(i)) {
//            result++;
//        } else {
//            //nothing
//        }
//    }
//    console.log(max + "以内有" + result + "个数包含9或者8或者6")
//}

//3.使用“模拟名称空间”技术，构建一个函数函数yz.fei.get986(number)；
var yz = {};
yz.fei = {};
yz.fei.get986 = function (nunmber) {
    var result = 0;
    for (var i = 1; i < nunmber + 1; i++) {
        if (has9(i) || has6(i) || has8(i)) {
            result++;
        } else {
            //nothing
        }
    }
    console.log(max + "以内有" + result + "个数包含9或者8或者6")

}

