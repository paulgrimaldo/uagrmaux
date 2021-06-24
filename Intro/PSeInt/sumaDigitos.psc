Algoritmo sumaDigitos
	Definir n, d, s Como Entero;
	
	Leer n;
	
	Mientras n>0 Hacer
		d<- n mod 10;
		n<-trunc(n/10);
		
		s<-s+d;
	FinMientras
	
	Escribir "Suma digitos: ", s;
	
FinAlgoritmo
