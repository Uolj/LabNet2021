//Lautaro Walsh TP6-Js
//----------------------

let nombreTxt = $("#nombreTxt");
let apellidoTxt = $("#apellidoTxt");
let edadTxt = $("#edadTxt");
let empresaTxt = $("#empresaTxt");

let submitBtn = $("#submitBtn").click(function () {
  if (nombreTxt.val() == "" || apellidoTxt.val() == "") {
    alert("Complete los campos obligatorios");
  } else {
    alert("informacion agregada con exito!");
  }
});

let reiniciarCamposBtn = $("#reiniciarCamposBtn").click(function () {
  nombreTxt.val("");
  apellidoTxt.val("");
  edadTxt.val("");
  empresaTxt.val("");
});
