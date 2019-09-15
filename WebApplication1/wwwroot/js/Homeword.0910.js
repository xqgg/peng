//1.使用setTimeout() （不是setInterval() ）实现每隔1秒钟依次显示：第n周，源栈同学random人。
//（n逐次递增，random随机）
//测试结果为：每隔一秒显示：第n周，源栈同学random人。到第20周停止,random!>10，学生人数不等于0。
//var counter = 1
//function greet() {
//    if (counter < 21) {
//        setTimeout(function () {
//            console.log("第" + counter + "周，源栈同学" +
//                Math.ceil(Math.random() * 10) + "人");
//            counter++
//            greet();
//        }, 1000)
//    } else {
//        //end
//    }
//}
//greet()
//Math.ceil

//完成猜数字的游戏：
//弹出游戏玩法说明，等待用户点击“确认”，开始游戏；
//在说明下点击取消直接结束游戏
//浏览器生成一个不大于1000的随机正整数；
//在猜测过程中点击取消直接结束游戏
//用户输入猜测；
//如果用户输入非规范的值，对用户做出相应提示
//如果用户没有猜对，浏览器比较后告知结果：“大了”或者“小了”。如果用户：
//只用了不到6次就猜到，弹出：碉堡了！
//只用了不到8次就猜到，弹出：666！
//用了8 - 10次猜到，弹出：猜到了。
//用了10次都还没猜对，弹出：^ (*￣(oo) ￣)^

var bingo = Math.ceil(Math.random() * 1000);
if (confirm(
    `浏览器生成一个不大于1000的随机正整数；
    用户输入猜测；
    如果用户没有猜对，浏览器比较后告知结果：“大了”或者“小了”。如果用户：
    只用了不到6次就猜到，弹出：碉堡了！
    只用了不到8次就猜到，弹出：666！
    用了8 - 10次猜到，弹出：猜到了。
    用了10次都还没猜对，弹出：^ (*￣(oo) ￣) ^`)) {
    bingoGame()
} else {
    //取消
}
function bingoGame() {
    for (var i = 0; i < 100; i++) {
        if (i >= 10) {
            alert("^ (*￣(oo) ￣)^");
            break;
        }
        var word = prompt("请输入您的猜测：", "");
        if (word === null) {
            break;
        }
        if (isNaN(word)) {
            alert("您输入的不是一个数字，请输入一个正整数");
            continue;
        }
        if (word < 1) {
            alert("您输入的不是一个正数，请输入一个正整数");
            continue;
        }
        if (word.indexOf(".") > -1) {
            alert("您输入的不是一个整数，请输入一个正整数");
            continue;
        }
        if (+word > bingo) {
            alert("大了");
        } else if (+word < bingo) {
            alert("小了");
        } else if (i < 6) {
            alert("碉堡了！");
            break;
        } else if (i < 8) {
            alert("666！");
            break;
        } else {
            alert("猜到了！");
            break;
        }
    }
}