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

