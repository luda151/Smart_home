// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

//vypsani textu a provedeni funkci
  function myFunction() {
  var checkBox = document.getElementById("myCheck");
  var text = document.getElementById("text");
  if (checkBox.checked == true){
        //todo zavolej zhasni svetlo
        text.style.display = "block";
  } else {
        //todo zavolej rosvit svetlo
        text.style.display = "none";
 }
}

//jezdici tlacitko a vypsani hodnoty
var slider = document.getElementById("myRange");
var output = document.getElementById("demo");
output.innerHTML = slider.value;

slider.oninput = function () {
    output.innerHTML = this.value;
}
