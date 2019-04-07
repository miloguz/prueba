
$(document).ready(function () {

    $("#departament").change(function(){
        $('#distritoId').html('<option name="distrito_id" value="" >Distrito</option>');
        getProvince();
    });

    $("#province").change(function(){
        getDistrite();
    });
    $('.btnVerReporte').click(function () {
        $('.hidde').css('display', 'block');
    })

});

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


function getProvince() {

    var departamentId = $("#departament").val() 

    $.ajax({
        url: '/Home/provinciasFiltro',
        type: 'GET',
        contentType: 'application/json',
        dataType: 'json',
        data: {
            "departament": departamentId
           
        },
        success: function (data, textStatus, xhr) {
            console.log(data);

            if (data.status == 1 || data.length > 0) {
                printSelect("#province", data);
            } else {
                console.log("datos no encontrados")
            }
        },
        error: function (xhr, textStatus, errorThrown) {
            console.log('Error in Operation');
        }
    });

}

function getDistrite() {

    provinceId = $("#province").val()
    
    $.ajax({
        url: 'Home/distritoFiltro',
        type: 'GET',
        contentType: 'application/json',
        dataType: 'json',
        data: { "province": provinceId },
        success: function (data, textStatus, xhr) {
            console.log(data);

            if (data.status == 1 || data.length > 0) {
                printSelect("#distritoId" , data);
            } else {
                console.log("datos no encontrados")
            }
        },
        error: function (xhr, textStatus, errorThrown) {
            console.log('Error in Operation');
        }
    });        
}

function printSelect(select, data) {
   
    var aux = "";
   
    $.each(data, function (index, val) {
        aux += "<option value=" + val.Id + "> " + val.nombre + "</option>";
    });

    $(select).html(aux);
   
}



// paso uno 

/** leer los datos que tellegan del post para luego filtrar las provincias
 * paso 2 retornarlos con el request sea como sea , tipo object o lo que sea
 * y el tres  ya esta hecho !
 * que es imprimir en el select
 * listo ahora  el front ya esta preparado para recibir los datos, y ya se sabe como comunicar el front con el
 *  ahora  falta  procesar la informacion en el back y comunicar  el back con el front LISTO ?
 *  esta  fcil una vez hecho eso ve haciendo la tabla que guarda  todo
 *  recuerda que la tabla  del id no lleva foreign key (clave forane pues)
 *  parse suerte thkx... voy a ponerme en eso ya chaito pues(Y)*/