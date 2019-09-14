//1.使用setTimeout() （不是setInterval() ）实现每隔1秒钟依次显示：第n周，源栈同学random人。
//（n逐次递增，random随机）
//测试结果为：每隔一秒显示：第n周，源栈同学random人。到第20周停止,random!>10，学生人数不等于0。
var counter = 1
function greet() {
    if (counter < 21) {
        setTimeout(function () {
            console.log("第" + counter + "周，源栈同学" +
                Math.ceil(Math.random() * 10) + "人");
            counter++
            greet();
        }, 1000)
    } else {
        //end
    }
}
greet()
Math.ceil