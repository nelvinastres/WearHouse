function myheader() {
    var a = document.getElementById('responsive');
    if(a.className == "menu") {
        a.style.display = "flex";
        a.className += " active";
    } else if(a.className == "menu active") {
        a.style.display = "none";
        a.className = "menu";
    }
}

function checkemail(email) {
    var regexp = /^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$/;
    return regexp.test(email);
}

function checkpass(pass) {
    var regex = /^(?=.*[A-Z])(?=.*[!@#\$%\^&\*])(?=.*[0-9])/;
    if(pass.length < 8) {
        return false;
    } else {
        return regex.test(pass);
    }
}

function checkconfirmpass(confirmpass, pass) {
    if(confirmpass.length == 0) {
        return false;
    } else if(confirmpass === pass) {
        return true;
    } else {
        return false;
    }
}

const registerbutt = document.getElementsByClassName('register');
const namainput = document.getElementById('nama');
const emailinput = document.getElementById('email');
const passinput = document.getElementById('pass');
const conpassinput = document.getElementById('confirmpass');

function login(name, email, password, confirmpassword) {
    const body = {
        name: name,
        email: email,
        password: password,
        confirmPassword: confirmpassword
    };
    fetch('https://localhost:7217/api/Register', {
        method: 'POST',
        body: JSON.stringify(body),
        headers: {
            "content-type": "application/json"
        }
    })
    .then(response => {
        if(response.status === 200) {
            window.open("../Dashboard/Dashboard.html", "_self");
        }
    });
    // .catch(document.getElementById("popup").style.display = "block");
}

function validating() {
    var nama = document.getElementById("nama").value;
    var email = document.getElementById("email").value;
    var pass = document.getElementById("pass").value;
    var confirmpass = document.getElementById("confirmpass").value;
    var checkbox = document.getElementById("agree");

    if(nama.length == 0) {
        alert("Nama harus diisi");
    } else if(email.length == 0) {
        alert("Email harus diisi");
    } else if(checkemail(email) == false) {
        alert("Email yang dimasukkan tidak sesuai");
    } else if(checkpass(pass) == false) {
        alert("Password yang dimasukkan tidak sesuai");
    } else if(checkconfirmpass(confirmpass, pass) == false) {
        alert("Password yang dimasukkan harus sama dengan sebelumnya");
    } else if(checkbox.checked == false) {
        alert("Syarat dan ketentuan harus dicentang");
    } else {
        login(namainput.value, emailinput.value, passinput.value, conpassinput.value);
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