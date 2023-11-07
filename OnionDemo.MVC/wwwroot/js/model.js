var modals = document.querySelectorAll(".modal");
var openButtons = document.querySelectorAll(".open-modal");
var closeButtons = document.querySelectorAll(".close");

openButtons.forEach(function (button) {
    button.addEventListener("click", function () {
        var modalId = button.getAttribute("data-modal-id");
        var modal = document.getElementById(modalId);
        if (modal) {
            modal.style.display = "block";
        }
    });
});

closeButtons.forEach(function (button) {
    button.addEventListener("click", function () {
        var modalId = button.getAttribute("data-modal-id");
        var modal = document.getElementById(modalId);
        if (modal) {
            modal.style.display = "none";
        }
    });
});

window.onclick = function (event) {
    modals.forEach(function (modal) {
        if (event.target == modal) {
            modal.style.display = "none";
        }
    });
};