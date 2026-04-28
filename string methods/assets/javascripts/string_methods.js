// let str = "salam";
// console.log(str.length)






// let str = "salam";
// let herf = "l";
// console.log(str.indexOf(herf) + 1)





// let str = "salam"
// let herf = "l"
// console.log(str.charCodeAt(str.indexOf(herf)))






// let str = "salam"
// console.log(str.toUpperCase())






// let str = "saLAm";
// console.log(str.toLowerCase())







// let str = " salam "
// console.log(str.trim())






// let str = "Azerbaycan Respublikasi";
// console.log(str.replace("Respublikasi", "Olkesi"))







// let str = "salam";
// let arr = str.split("");
// let reversed = arr.reverse();
// let result = reversed.join("");
// console.log(result)








// let str = "SaLaMLa";
// let arr = str.split("");
// let yeni = arr.map(function(herf) {
//     if (herf === herf.toUpperCase()) {
//         return herf.toLowerCase()
//     } else {
//         return herf.toUpperCase()
//     }
// })
// let result = yeni.join("");
// console.log(result)







// let a = "sl12sfa2321sfafa";
// let yeni = a.split("");
// let yeni2 = yeni.map(function(simvol) {
//     if (isNaN(simvol)) {
//         return simvol;
//     } else {
//         return "";
//     }
// })
// let result = yeni2.join("");
// console.log(result)






// let str = "sALAm necesen nEvar"
// let words = str.split(" ")
// let resultArr = words.map(function(word) {
//     return word[0].toUpperCase() + word.slice(1).toLowerCase();
// })
// let result = resultArr.join(" ")
// console.log(result)






// let str = "sl124asdfa23";
// let letters = 0;
// let numbers = 0;
// str.split("").forEach(function(simvol) {
//     if (isNaN(simvol)) {
//         letters++
//     } else {
//         numbers++
//     }
// })
// console.log("herf-" + letters + " reqem-" + numbers)





// function removeSpaces(str) {
//     return str.replaceAll(" ", "");
// }
// console.log(removeSpaces("menIm aDim qurBandir"));





// function word(str) {
//     let words = str.split(" ")

//     let first = words[0]
//     let last = words[words.length - 1]

//     words[0] = last
//     words[words.length - 1] = first

//     return words.join(" ")
// }
// console.log(word("menIm aDim qurBandir"))
