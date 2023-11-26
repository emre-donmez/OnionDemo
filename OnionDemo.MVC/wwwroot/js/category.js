var modal = document.getElementById("formModal");
var actionButtons = document.querySelectorAll(".actionBtn");
var span = document.getElementsByClassName("close")[0];

var idInput = document.getElementById("Id");
var createdInput = document.getElementById("Created");
var descriptionInput = document.getElementById("Description");
var nameInput = document.getElementById("Name");
var url = document.getElementById("Url");

actionButtons.forEach(function (button) {
    button.addEventListener("click", function () {
        var dataId = this.getAttribute("data-id");

        idInput.value = dataId;
        nameInput.value = this.getAttribute("data-name");
        descriptionInput.value = this.getAttribute("data-description");
        createdInput.value = this.getAttribute("data-created");

        if (dataId == null)
            url.value = document.getElementById("CreateUrl").value;
        else
            url.value = document.getElementById("UpdateUrl").value;

        modal.style.display = "block";
    });
});

span.onclick = function () {
    modal.style.display = "none";
}

window.onclick = function (event) {
    if (event.target == modal) {
        modal.style.display = "none";
    }
}

$('#btnForm').click(function (e) {
    e.preventDefault();

    var id = $('#Id').val();
    var name = $('#Name').val();
    var description = $('#Description').val();
    var created = $('#Created').val();

    var categoryData = {
        Id: id,
        Name: name,
        Description: description,
        Created: new Date(created)
    };

    var url = $('#Url').val();

    $.ajax({
        type: 'POST',
        url: url,
        data: JSON.stringify(categoryData),
        contentType: 'application/json',
        "crossDomain": true,
        "Access-Control-Allow-Origin": "*",

        success: function (response) {
            window.location.reload();
        },
        error: function (error) {
            console.log(error);
        }
    });
});