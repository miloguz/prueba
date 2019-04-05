
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
