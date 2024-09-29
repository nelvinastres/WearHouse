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

function showw() {
    var a = document.getElementById('logout');
    if(a.className == "Logout") {
        a.style.display = "block";
        a.className += " on";
    } else if(a.className == "Logout on") {
        a.style.display = "none";
        a.className = "Logout";
    }
}

function show() {
    document.getElementById("popup").style.display = "block";
}

var closebutt = document.getElementsByClassName("closebutt")[0];
closebutt.onclick = function() {
    document.getElementById("popup").style.display = "none";
}

function show2() {
    document.getElementById("popup2").style.display = "block";
}

var closebutt2 = document.getElementsByClassName("closebutt2")[0];
closebutt2.onclick = function() {
    document.getElementById("popup2").style.display = "none";
}

function show3() {
    document.getElementById("popup3").style.display = "block";
}

var closebutt3 = document.getElementsByClassName("closebutt3")[0];
closebutt3.onclick = function() {
    document.getElementById("popup3").style.display = "none";
}

window.onclick = function(event) {
    if(event.target == document.getElementById("popup")) {
        document.getElementById("popup").style.display = "none";
    } else if(event.target == document.getElementById("popup2")) {
        document.getElementById("popup2").style.display = "none";
    } else if(event.target == document.getElementById("popup3")) {
        document.getElementById("popup3").style.display = "none";
    }
}

var newCategory = document.getElementById("addCategory");
var categoryName = newCategory.value;

function addCategory(categoryName) {
    const body = {
        categoryName: categoryName
    };
    fetch('https://localhost:7217/api/Category', {
        method: 'POST',
        body: JSON.stringify(body),
        headers: {
            "content-type": "application/json"
        }
    })
    .then(response => {
        if(response.status === 200) {
            alert("Category berhasil ditambahkan!");
            const table = document.getElementById("categoryTable");
            const newRow = table.insertRow();
            const cell1 = newRow.insertCell(0);
            const cell2 = newRow.insertCell(1);
            const cell3 = newRow.insertCell(2);

            cell1.innerHTML = table.rows.length;
            cell2.innerHTML = newCategory;
            cell3.innerHTML = table.rows[table.rows.length - 1].cells[2].innerHTML;
        } else {
            alert("Category gagal ditambahkan.");
        }
    });
    // .catch(document.getElementById("popup").style.display = "block");
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

