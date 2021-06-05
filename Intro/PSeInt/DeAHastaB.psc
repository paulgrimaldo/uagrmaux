Algoritmo DeAHastaB
	Definir s,a, b , n, p Como Entero;
	p<-0;
	s<-0;
	Escribir "Introduzca n";
	Leer n;
	Escribir "Introduzca a";
	Leer a;
	Escribir "Introduzca b";
	Leer b;
	Mientras (n>0) Hacer
		s<- a + p;
		Mostrar s;
		p<-p+1;
		Si (s==b) Entonces
			s<-0;
			p<-0;
		FinSi
		n<-n-1;
	FinMientras
	
FinAlgoritmo
