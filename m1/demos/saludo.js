function saludar() {
  const nombre = document.getElementById('nombre').value;
  const saludo = document.getElementById('saludo');
  if (nombre.trim() !== '') {
    saludo.textContent = '¡Hola, ' + nombre + '!';
  } else {
    saludo.textContent = 'Por favor, ingresa tu nombre.';
  }
}
