Algoritmo SumatoriaYSerieEj4
	Definir suma,termino Como Real
	Definir  s1, s2, n, a,b,c Como Entero
	
	a<--1;
	b<-1;
	s1<-a+b;
	s2<-1;
	suma<-0;
	c<-1;
	
	Leer n;
	
	Mientras n>0 Hacer
		termino<-s1/s2;
		suma<-suma+termino;
		
		a<-b;
		b<-s1;
		
		s1<-a+b;
		
		c<-c+1;
		s2<-s2*c;
		
		n<-n-1;
	FinMientras
	
	Mostrar suma;
FinAlgoritmo
