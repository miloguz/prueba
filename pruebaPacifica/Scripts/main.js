
var parroquiaActive = 'false';
$('#parroquiaCheck').click(function () {
if (parroquiaActive == true) {
    $('.hidde').css('display', 'none');
    parroquiaActive = false;
}
else{
    $('.hidde').css('display', 'block');
    parroquiaActive = true;
}
});


function getDepartament() {

    $.ajax({
        url: 'http://localhost:3413/api/person',
        type: 'POST',
        dataType: 'json',
        data: person,
        success: function (data, textStatus, xhr) {
            console.log(data);
        },
        error: function (xhr, textStatus, errorThrown) {
            console.log('Error in Operation');
        }
    });
    // repositorio de YisusW
    // GITHUB
    // agregar como colaborador
    // please!
}