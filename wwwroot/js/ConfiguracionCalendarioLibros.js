// Obtener la fecha actual en formato YYYY-MM-DD
var fechaActual = new Date().toISOString().split('T')[0];
// Establecer la fecha actual como el m�ximo del campo de entrada
document.getElementById("fechaDePublicacion").setAttribute("max", fechaActual);