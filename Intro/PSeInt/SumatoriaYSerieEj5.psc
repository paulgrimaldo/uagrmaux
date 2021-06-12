Algoritmo SumatoriaYSerieEj5
	Definir s1, s2, n, c Como Entero; 
	Definir termino, suma Como Real;
	Definir sw Como Logico; 
	
	
	s1<-1;
	c<-1;
	s2<-1;
	suma<-0;
	sw<- Verdadero; 
	
	
	Leer n;
	
	Mientras n>0 Hacer
		Si sw = Verdadero Entonces
			termino<-s1/s2;
			sw<-Falso;
		SiNo
			termino<-s2/s1;
			sw<-Verdadero;
		FinSi
	
		suma<-suma+termino;
		
		c<-c+1;
		s1<-s1*c;
		
		s2<-s2 * 2;
		
		n<-n-1;
	FinMientras
	Mostrar suma;
	
FinAlgoritmo
