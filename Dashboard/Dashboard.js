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

function show() {
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
    var a = document.getElementById('logout');
    if(a.className == "Logout") {
        a.style.display = "block";
        a.className += " on";
    } else if(a.className == "Logout on") {
        a.style.display = "none";
        a.className = "Logout";
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