//случайное число между 0 и 1 
document.write(Math.random() + "<br />"); 
 
//случайное число между 0 и 10 
document.write(Math.floor(Math.random()*11)); 
 
// автоматическое обновление страницы в браузере 
// через 1000 миллисекунд (1 секунду) 
setTimeout(function(){     
	location.reload(); 
}, 1000); 