//function changeBackground(dropdown) {
//    var selectedValue = dropdown.value;
//    document.body.className = '';

//    if (selectedValue === "2") {
//        document.body.classList.add('green-bg');
//    } else if (selectedValue === '3') {
//        document.body.classList.add('yellow-bg');
//    } else if (selectedValue === '4') {
//        document.body.classList.add('blue-bg');
//    } else {
//        document.body.classList.add('default-bg');
//    }
//}



document.addEventListener('DOMContentLoaded', () => {
    const button = document.querySelector('.tooltip-btn');

    button.addEventListener('click', () => {
        document.getElementById('scrollTarget').scrollIntoView({ behavior: 'smooth' });
    });
});

function validateForm() {
    var isValid = true;

    // Validate TextBox
    var textBox = document.getElementById('<%= TextBox1.ClientID %>');
    var textBoxError = document.getElementById('TextBoxError');
    if (textBox.value.trim() === "") {
        textBoxError.style.display = 'block';
        isValid = false;
    } else {
        textBoxError.style.display = 'none';
    }

    // Validate DropDownList
    var dropDownList = document.getElementById('<%= DropDownList1.ClientID %>');
    var dropDownListError = document.getElementById('DropDownListError');
    if (dropDownList.value === "") {
        dropDownListError.style.display = 'block';
        isValid = false;
    } else {
        dropDownListError.style.display = 'none';
    }

    return isValid;
}
