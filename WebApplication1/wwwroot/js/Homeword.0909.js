//1.构建一个函数has9(number) ，可以判断number中是否带有数字9；
function has9(number) {
    var parameter = String(number);
    for (var i = 0; i < parameter.length; i++) {
        if (parameter[i] === "9") {
            return true;
        } else {
            if (i === parameter.length - 1) {
                return false;
            }
        }
    }
}
var has = has9()



