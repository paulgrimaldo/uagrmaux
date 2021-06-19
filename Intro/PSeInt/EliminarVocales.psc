Algoritmo EliminarVocales
	// Preparacion de la cadena
	Definir palabra,resultado Como Caracter
	Definir tamano,pos Como Entero
	Leer palabra
	tamano <- Longitud(palabra)
	Dimension letras[tamano]
	Para i<-1 Hasta tamano Hacer
		letras[i] <- Subcadena(palabra,i,i)
	FinPara
	// Aqui inicia mi algoritmo
	Para pos<-1 Hasta tamano Hacer
		Si letras[pos]<>'a' y letras[pos]<>'e'y letras[pos]<>'i' y letras[pos]<>'o' y letras[pos]<>'u' Entonces
			resultado <- Concatenar(resultado,letras[pos])
		FinSi
	FinPara
	Escribir resultado
FinAlgoritmo
