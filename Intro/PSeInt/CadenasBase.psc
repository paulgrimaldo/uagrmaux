Algoritmo CadenasBase
	//Definir la palabra a tratar, su tamaño, las letras que tiene la palabra 
	Definir palabra Como Caracter;
	Definir tamano Como Entero;
	//Leer la palabra y calcular su tamaño 
	Leer palabra;
	tamano<- Longitud(palabra)
	//Defino la coleccion de caracteres de la palabra 
	Dimension letras[tamano];
	//Llenar la coleccion
	Para i<-1 Hasta tamano Con Paso 1 Hacer
		letras[i] <- Subcadena(palabra,i,i)
	FinPara
	
	
	Para j<-1 Hasta tamano Con Paso 1 Hacer
		Escribir letras[j]
	FinPara
	
FinAlgoritmo
