function myheader() {
    var a = document.getElementById('responsive');
    if(a.className == "menu-respon") {
        a.style.display = "flex";
        a.className += " active";
    } else if(a.className == "menu-respon active") {
        a.style.display = "none";
        a.className = "menu-respon";
    }
}

function checkemail(email) {
    var regexp = /^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$/;
    return regexp.test(email);
}

var email, pass;
const loginbutt = document.getElementsByClassName('login');
const emailinput = document.getElementById('email');
const passinput = document.getElementById('pass');

function login(email, password) {
        const body = {
            email: email,
            password: password
        };
        fetch('https://localhost:7217/api/Login', {
            method: 'POST',
            body: JSON.stringify(body),
            headers: {
                "content-type": "application/json"
            }
        })
        .then(response => {
            if(response.status === 200) {
                window.open("../Dashboard/Dashboard.html", "_self");
            } else {
                document.getElementById("popup").style.display = "block";
            }
        });
    }

function validating() {
    email = document.getElementById("email").value;
    pass = document.getElementById("pass").value;

    if(email.length==0) {
        alert("Alamat email belum diisi");
    } else if(checkemail(email)==false) {
        alert("Alamat email yang Anda masukkan tidak sesuai");
    } else if(pass.length==0) {
        alert("Password belum diisi");
    } else {
        login(emailinput.value, passinput.value);
    }
}

var closebutt = document.getElementsByClassName("closebutt")[0];
closebutt.onclick = function() {
    document.getElementById("popup").style.display = "none";
}

window.onclick = function(event) {
    if(event.target == document.getElementById("popup")) {
        document.getElementById("popup").style.display = "none";
    }
}

function opentwitter() {
    window.open("https://twitter.com/?lang=id");
}

function openfb() {
    window.open("https://www.facebook.com/?locale=id_ID");
}

function openig() {
    window.open("https://www.instagram.com/");
}

// const loginbutt = document.getElementsByClassName('login');
// const emailinput = document.getElementById('email');
// const passinput = document.getElementById('pass');

// function login(email, password) {
//     const body = {
//         email: email,
//         password: password
//     };
//     fetch('https://localhost:7217/api/Login', {
//         method: 'POST',
//         body: JSON.stringify(body),
//         headers: {
//             "content-type": "application/json"
//         }
//     })
//     .then(data => data.json())
//     .then(response => console.log(response));
// }

// loginbutt.addEventListener('click', function() {
//     login(emailinput.value, passinput.value);
// })