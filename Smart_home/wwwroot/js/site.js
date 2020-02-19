// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


    function myFunction() {
  var checkBox = document.getElementById("myCheck");
    var text = document.getElementById("text");
  if (checkBox.checked == true){
        text.style.display = "block";
  } else {
        text.style.display = "none";
 }
}
