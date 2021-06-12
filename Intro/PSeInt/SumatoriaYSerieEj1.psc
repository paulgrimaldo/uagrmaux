Algoritmo SumatoriaYSerieEj1
	Definir suma,termino Como Real
	Definir  s1, s2, n Como Entero
	
	s1<- 1;
	s2<-2;
	suma<-0;
	
	Leer n
	
	
	Mientras n>0 Hacer
		termino<- s1/s2;
		suma<-suma+termino;
		
		s1<-s1+1;
		s2<-s2+2;
		
		n<-n-1;
	FinMientras
	
	Mostrar suma;
FinAlgoritmo
