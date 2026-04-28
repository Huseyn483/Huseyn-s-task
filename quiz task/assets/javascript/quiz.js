const students = [
  {
    id: 1,
    name: "Qurban",
    surname: "Qurbanzada",
    age: 20,
    gender: "male",
    username: "qurban123",
    password: "qqq123",
    average: 85,
    scholarship: 250,
    hobbies: ["book", "football", "coding"],
    hasFail: false,
    boyfriend: false,
    teachers: [
      { id: 1, name: "anar" },
      { id: 3, name: "leyla" }
    ]
  },
  {
    id: 2,
    name: "Aysel",
    surname: "Memmedova",
    age: 19,
    gender: "female",
    username: "aysel99",
    password: "ayselpass",
    average: 92,
    scholarship: 300,
    hobbies: ["music", "book"],
    hasFail: false,
    boyfriend: true,
    teachers: [
      { id: 2, name: "kamran" },
      { id: 3, name: "nigar" }
    ]
  },
  {
    id: 3,
    name: "Murad",
    surname: "Aliyev",
    age: 21,
    gender: "male",
    username: "murad_dev",
    password: "murad2024",
    average: 67,
    scholarship: 180,
    hobbies: ["gaming", "football", "movie", "book"],
    hasFail: true,
    boyfriend: false,
    teachers: [
      { id: 1, name: "anar" }
    ]
  },
  {
    id: 4,
    name: "Nigar",
    surname: "Huseynli",
    age: 20,
    gender: "female",
    username: "nigar_h",
    password: "nigar12345",
    average: 96,
    scholarship: 350,
    hobbies: ["drawing", "gaming", "travel"],
    hasFail: false,
    boyfriend: true,
    teachers: [
      { id: 3, name: "leyla" },
      { id: 4, name: "samir" }
    ]
  },
  {
    id: 5,
    name: "Elvin",
    surname: "Kerimli",
    age: 22,
    gender: "male",
    username: "elvin_k",
    password: "elvinpass",
    average: 74,
    scholarship: 200,
    hobbies: ["book", "chess"],
    hasFail: true,
    boyfriend: false,
    teachers: [
      { id: 2, name: "kamran" }
    ]
  },
  {
    id: 6,
    name: "Lale",
    surname: "Ismayilova",
    age: 20,
    gender: "female",
    username: "lale_20",
    password: "lale2026strong",
    average: 88,
    scholarship: 280,
    hobbies: ["music", "book", "gaming", "coding", "dance"],
    hasFail: false,
    boyfriend: true,
    teachers: [
      { id: 3, name: "nigar" },
      { id: 5, name: "elmar" }
    ]
  }
];


//1ci task
students.forEach(function (telebe) {
  console.log(telebe);
})


//2 ci task
students.forEach(function(telebe) {
  console.log(telebe.name)
})



//3cu task
students.forEach(function(telebe) {
  console.log(telebe.name + " " + telebe.surname)
})



//4cu task
students.forEach(function(telebe) {
  if (telebe.hasFail === true) {
    console.log(telebe.name + " " + telebe.surname)
  }
})



//5ci task
let mx = students[0]
students.forEach(function(telebe) {
  if (telebe.hobbies.length > mx.hobbies.length) {
    mx = telebe
  }
})
console.log(mx.name)
console.log(mx.hobbies)




//6ci task
let mx2 = students[0]
students.forEach(function(telebe) {
  if (telebe.average > mx2.average) {
    mx2 = telebe
  }
})
console.log(mx2.name + " " + mx2.surname)




//7ci task
let mx3 = students[0]
students.forEach(function(telebe) {
  if (telebe.password.length > mx3.password.length) {
    mx3 = telebe
  }
})
console.log(mx3.name + " " + mx3.surname)




//8ci task
students.forEach(function(telebe) {
  if (telebe.boyfriend === true) {
    console.log(telebe.name + " " + telebe.username)
  }
})




//9cu task(cetin)
students.forEach(function(telebe) {
  if (telebe.age === 20) {
    console.log(telebe.name)

    telebe.teachers.forEach(function(muellim) {
      console.log(muellim.name)
    })
  }
})




//10cu task
let kurs = 1.7;
students.forEach(function(telebe) {
  telebe.scholarship = (telebe.scholarship / kurs) + "$";
})



//11ci task
students.forEach(function(telebe) {
  telebe.teachers.forEach(function(muellim) {
    muellim.name = muellim.name.charAt(0).toUpperCase() + muellim.name.slice(1);
  });
});


//12ci task





//13-ci task
let netice = [];
students.forEach(function(telebe) {
  if (telebe.gender === "female") {
    telebe.teachers.forEach(function(muellim) {
      if (muellim.id === 3) {
        netice.push(muellim.name);
      }
    });
  }
});




//14cu task
students.forEach(function(telebe) {
  console.log(telebe.name + "  " + telebe.teachers.length);
})





//15ci task
let a = students.map(function(telebe) {
  return {
    name: telebe.name,
    username: telebe.username,
    password: telebe.password
  }
})
console.log(a)




//16ci task
students.forEach(function(telebe) {
  telebe.teachers.forEach(function(muellim) {
    muellim.name = muellim.name + " müəllim"
  })
})



//17ci task
students.forEach(function (telebe) {
  telebe.password = "   " + telebe.password;
});

console.log(students);





//18ci task






//19ci task
students.forEach(function (telebe) {
  let nameLength = telebe.name.length;
  let surname = telebe.surname;

  if (surname.length > nameLength) {
    telebe.surname = surname.slice(0,nameLength)
  }
});
console.log(students);






//20ci task
let cem = 0;
students.forEach(function (telebe) {
  cem += telebe.age;
});
console.log(cem);




//21ci task
let cem = 0
students.forEach(function (telebe) {
  cem += telebe.average
})

let orta = cem / students.length;
console.log(orta);


//22ci task
students.forEach(function (telebe) {
  if (telebe.hobbies.includes("book")) {
    console.log(telebe);
  }
});




//23cu task
let cem = 0
students.forEach(function (telebe) {
  cem += telebe.age
})

let orta = cem / students.length

console.log(orta)



//24cu task







//25ci task
let cem = 0;

students.forEach(function (telebe) {
  cem += telebe.name.length + telebe.surname.length;
});
console.log(cem);





//26ci task
students.forEach(function (telebe) {
  let ters = telebe.name.split("").reverse().join("");
  console.log(ters);
})

