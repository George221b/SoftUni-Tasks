function showView(viewName) {
    $('main > section').hide(); //Hide all views
    $('#' + viewName).show(); // Show the selected view only
}

function showHideMenuLInks() {
    $('#linkHome').show();
    if (sessionStorage.getItem('authToken') === null){ // No logged in user
        $('#linkLogin').show();
        $('#linkRegister').show();
        $('#linkListAds').hide();
        $('#linkCreateAd').hide();
        $('#linkLogout').hide();
        $('#loggedInUser').text('');
    } else {                          //Logged in user
        $('#linkLogin').hide();
        $('#linkRegister').hide();
        $('#linkListAds').show();
        $('#linkCreateAd').show();
        $('#linkLogout').show();
        $('#loggedInUser').text(`Welcome, ${sessionStorage.getItem('authToken')}`);
    }
}

function showHomeView() {
    showView('viewHome');
}
function showLoginView() {
    showView('viewLogin');
    $('#formLogin').trigger('reset');
}
function showRegisterView() {
    $('#formRegister').trigger('reset');
    showView('viewRegister');
}

function showCreateAdView() {
    $('#formCreateAd').trigger('reset');
    showView('viewCreateAd');
}
function showInfo(message) {
    let infoBox = $('#infoBox');
    infoBox.text(message);
    infoBox.show();
    setTimeout(function () {
        $('#infoBox').fadeOut();
    }, 3000);
}
function showError(errorMsg) {
    let errorBox = $('#errorBox');
    errorBox.text('Error: ' + errorMsg);
    errorBox.show();
}