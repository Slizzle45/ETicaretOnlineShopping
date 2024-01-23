document.addEventListener("DOMContentLoaded", function () {
    console.log('itemCard.js loaded');

    var itemCard = document.querySelectorAll('.card');

    function showSuccessAlert() {
        var alertElement = document.createElement('div');
        alertElement.className = 'alert alert-success custom-alert';
        alertElement.setAttribute('role', 'alert');
        alertElement.textContent = 'Ürün sepete eklendi';

        document.body.appendChild(alertElement);

        setTimeout(function () {
            alertElement.remove();
        }, 3000);
    }


    itemCard.forEach(function (item) {
        item.addEventListener('click', function () {
            window.location.href = '/Home/ItemDetails';
        });

        var cardFooter = item.querySelector('.card-footer');

        cardFooter.addEventListener('click', function (event) {

            event.stopPropagation();
            console.log('alert göster');
            showSuccessAlert();
        });


        item.addEventListener('mouseover', function () {
            item.style.cursor = 'pointer';
        });

        item.addEventListener('mouseout', function () {//mouse çıktığında eski haline döner
            item.style.cursor = 'auto';
        });
    });

});
