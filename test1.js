function getStatistics(marks) {
	var avgMark = 0;
	var highestMark = 0;
	var lowestMark = 5;
	var studentnamehighestMark;
	var studentnamelowestMark;
	
	for(let student of marks){
		avgMark = avgMark + student.avgMark;
		if(student.avgMark > highestMark){
			highestMark = student.avgMark;
			studentnamehighestMark = student.name;
		}
		if(student.avgMark < lowestMark){
			lowestMark = student.avgMark;
			studentnamelowestMark = student.name;
	}}
	return {avgMark:avgMark / marks.length, highestMark:studentnamehighestMark, lowestMark:studentnamelowestMark};		
} 
const testMarks = [{
name: 'Vasya',
avgMark: 3.75
}, {
name: 'Lena',
avgMark: 4.89
}]
console.log(getStatistics(testMarks)); 
