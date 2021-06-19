Algoritmo EliminarEspaciosDerecha
	// Preparacion de la cadena
	Definir palabra,resultado Como Caracter
	Definir tamano,pos Como Entero
	Definir encontrado Como Logico
	Leer palabra
	tamano <- Longitud(palabra)
	Dimension letras[tamano]
	Para i<-1 Hasta tamano Hacer
		letras[i] <- Subcadena(palabra,i,i)
	FinPara
	//Aqui inicia mi algoritmo
	pos <- tamano
	encontrado <- Falso
	Mientras pos>=1 Y  NO encontrado Hacer
		Si letras[pos]<>' ' Entonces
			encontrado <- Verdadero
		SiNo
			pos <- pos-1
		FinSi
	FinMientras
	resultado <- Subcadena(palabra,1,pos)
	
	Escribir resultado
	Escribir "Pos: ", pos
FinAlgoritmo
