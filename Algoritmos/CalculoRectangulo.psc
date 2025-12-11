Algoritmo CalculoRectangulo
	// Definición de variables (double pasa a ser Real)
	Definir altura, ancho, area, perimetro Como Real
	
	// Entradas
	Escribir "Dame la altura: "
	Leer altura
	
	Escribir "Dame el ancho: "
	Leer ancho
	
	// Procesos
	area <- altura * ancho
	// Se debe poner explícitamente el * antes del paréntesis
	perimetro <- 2 * (altura + ancho) 
	
	// Salidas
	Escribir "El area es: ", area
	Escribir "El perímetro es: ", perimetro
	
FinAlgoritmo