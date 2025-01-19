document.addEventListener("DOMContentLoaded", function () {
    var successMessage = document.getElementById("successMessage");

    // Preveri, ali element obstaja
    if (successMessage) {
        setTimeout(function () {
            successMessage.style.display = "none"; // Skrijemo element
        }, 4000); 
    }
});