function changcolorfunction(specialstate) {
    console.log(specialstate)
    let fieldValue = document.getElementById("specialstate").textContent;
    console.log(fieldValue.trim())

    if (fieldValue.trim() === "متاح للعمل") {
        console.log(fieldValue)

        document.getElementById(specialstate).style.backgroundColor = "red";
    } else {
        console.log(fieldValue)

        document.getElementById(specialstate).style.backgroundColor = "green";
    }
    }