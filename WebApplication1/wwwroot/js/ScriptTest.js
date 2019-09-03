//9.2
//将源栈同学姓名 / 昵称装入数组，再根据该数组输出所有同学，以及共有多少位同学
var students = ["彭志强", "薛明林", "王新", "于维谦", "杨进文", "幸龙泰", "陈晨", "陈小丁"];
console.log(students);
console.log("以上"+students.length + "位同学");

//利用循环，计算出2+4+6+8+...+100=?
var sum = 0;
for (var i = 2; i <= 100; i += 2) {
	sum = sum + i
	
}
console.log("2+4+6+8+...+100="+sum);

//独立完成“冒泡排序”算法
var scorse = [67, 11, 1, 0.8, 73, 77, 83, 94, 63];
for (var i = 0; i < scorse.length-1; i++) {
	if (scorse[i] > scorse[i + 1]) {
		var temp = scorse[i];
		scorse[i] = scorse[i + 1];
		scorse[i + 1] = temp;
		for (var j = 0; j < length; j++) {
			if (scorse[j - 1] < scorse[j - 2]) {
				scorse[j] = scorse[j - 1];
				scorse[j - 1] = temp;
			} else {
				break
			}
		};
	} else {
	};
};
console.log("数组排序：" + scorse)