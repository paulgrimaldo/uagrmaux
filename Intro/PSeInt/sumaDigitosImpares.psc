Algoritmo sumaDigitosImpares
	Definir n, d, s Como Entero;
	Leer n;
	
	Mientras n>0 Hacer
		d<-n mod 10;
		n<-trunc(n/10);
		
		Si (d mod 2) = 1 Entonces
			s<-s+d;
		FinSi
	FinMientras
	Escribir "Suma impares: ", s
	
FinAlgoritmo
