Algoritmo ContarCantidadEspacios
	// Preparacion de la cadena
	Definir palabra Como Caracter
	Definir tamano,pos,cantidad Como Entero
	Leer palabra
	tamano <- Longitud(palabra)
	Dimension letras[tamano]
	Para i<-1 Hasta tamano Hacer
		letras[i] <- Subcadena(palabra,i,i)
	FinPara
	// Aqui inicia mi algoritmo
	Para pos<-1 Hasta tamano Hacer
		Si letras[pos]=' ' Entonces
			cantidad <- cantidad+1
		FinSi
	FinPara
	Escribir "Cantidad espacios: ", cantidad
FinAlgoritmo
