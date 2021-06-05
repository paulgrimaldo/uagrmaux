Algoritmo CeroHastaM
	Definir  s, n, m Como Entero;
	s<-0;
	Escribir "Introduzca n";
	Leer n;
	Escribir "Introduzca m";
	Leer m; 
	
	Mientras (n >0) Hacer
		Mostrar s;
		s<-s+1;
		Si (s>m) Entonces
			s<-0;
		FinSi
		n<-n-1;
	FinMientras
FinAlgoritmo
