function calculateTotal() {
    let rows = document.querySelectorAll("#medicineTable tr");
    let subTotal = 0;

    rows.forEach((row) => {
        let cost = parseFloat(row.querySelector(".cost").value) || 0;
        let discount = parseFloat(row.querySelector(".discount").value) || 0;
        let qty = parseInt(row.querySelector(".qty").value) || 0;

        if (discount > cost) {
            alert("Discount cannot be greater than cost!");
            row.querySelector(".discount").value = 0;
            discount = 0;
        }

        let total = qty * (cost - discount);
        row.querySelector(".totalAmount").innerText = total;
        subTotal += total;
    });

    document.getElementById("subTotal").innerText = subTotal;
    let gst = subTotal * 0.18;
    document.getElementById("gst").innerText = gst;
    document.getElementById("grandTotal").innerText = subTotal + gst;
}

function showBill() {
    document.getElementById("displayPatient").innerText = document.getElementById("patientName").value;
    document.getElementById("displayDoctor").innerText = document.getElementById("doctorName").value;

    let rows = document.querySelectorAll("#medicineTable tr");
    let billTable = document.getElementById("billTable");
    billTable.innerHTML = "";

    rows.forEach((row, index) => {
        let medicine = row.querySelector(".medicine").value;
        let cost = row.querySelector(".cost").value;
        let discount = row.querySelector(".discount").value;
        let qty = row.querySelector(".qty").value;
        let total = row.querySelector(".totalAmount").innerText;

        if (medicine && cost && qty) {
            billTable.innerHTML += `
                <tr>
                    <td>${index + 1}</td>
                    <td>${medicine}</td>
                    <td>${cost}</td>
                    <td>${discount}</td>
                    <td>${qty}</td>
                    <td>${total}</td>
                </tr>
            `;
        }
    });

    document.getElementById("billSection").style.display = "block";
}